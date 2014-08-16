using System.Threading;
using GecoSI.Net.Dataframe;
using Moq;
using NUnit.Framework;

namespace GecoSI.Net.Tests.Internal
{
    [TestFixture]
    public class SiDriverTest
    {
        [SetUp]
        public void setUp()
        {
            GecoSiLogger.Open();
        }

        private ISiPort siPort;

        private SiHandler siHandler;

        private void testRunDriver(SiDriver driver)
        {
            driver.Start();
            Thread.Sleep(100);
            driver.Interrupt();
        }

        [Test]
        public void readSiCard10_192Punches()
        {
            siPort = new MockCommPort(new[]
            {
                SiMessageFixtures.startup_answer, SiMessageFixtures.ok_ext_protocol_answer,
                SiMessageFixtures.si6_192_punches_answer,
                SiMessageFixtures.sicard10_detected, SiMessageFixtures.sicard10_b0_data,
                SiMessageFixtures.sicard10_b4_data,
                SiMessageFixtures.sicard5_removed
            });


            var siHandlerMock = new Mock<SiHandler>();
            siHandler = siHandlerMock.Object;

            siHandlerMock.Setup((si => si.Notify(It.IsAny<Si8PlusDataFrame>()))).Callback<ISiDataFrame>(si10 =>
            {
                ISiDataFrame si10Data = si10.StartingAt(0);
                Assert.AreEqual(si10Data.NbPunches, (3));
                Assert.AreEqual(si10Data.Punches[0].Code, (42));
                Assert.AreEqual(si10Data.Punches[2].Code, (32));
            });
        }

        [Test]
        public void readSiCard5()
        {
            siPort = new MockCommPort(new[]
            {
                SiMessageFixtures.startup_answer, SiMessageFixtures.ok_ext_protocol_answer,
                SiMessageFixtures.si6_64_punches_answer,
                SiMessageFixtures.sicard5_detected, SiMessageFixtures.sicard5_data, SiMessageFixtures.sicard5_removed
            });
            var siHandlerMock = new Mock<SiHandler>();
            siHandler = siHandlerMock.Object;

            testRunDriver(new SiDriver(siPort, siHandler));

            siHandlerMock.Verify(si => si.Notify(It.IsAny<Si5DataFrame>()));
        }

        [Test]
        public void readSiCard6_192Punches()
        {
            siPort = new MockCommPort(new[]
            {
                SiMessageFixtures.startup_answer, SiMessageFixtures.ok_ext_protocol_answer,
                SiMessageFixtures.si6_192_punches_answer,
                SiMessageFixtures.sicard6_detected, SiMessageFixtures.sicard6_192p_b0_data,
                SiMessageFixtures.sicard6_192p_b6_data, SiMessageFixtures.sicard6_192p_b7_data,
                SiMessageFixtures.sicard6_192p_b2_data,
                SiMessageFixtures.sicard6_192p_b3_data, SiMessageFixtures.sicard5_removed
            });
            var siHandlerMock = new Mock<SiHandler>();
            siHandler = siHandlerMock.Object;

            siHandlerMock.Setup(si => si.Notify(It.IsAny<Si6DataFrame>())).Callback<ISiDataFrame>(data =>
            {
                ISiDataFrame si6Data = data.StartingAt(0);
                Assert.AreEqual(si6Data.NbPunches, (101));
                Assert.AreEqual(si6Data.Punches[0].Code, (31));
                Assert.AreEqual(si6Data.Punches[100].Code, (634));
            });

            testRunDriver(new SiDriver(siPort, siHandler));
            siHandlerMock.Verify(si => si.Notify(It.IsAny<Si6DataFrame>()));
        }

        [Test]
        public void siCard5_removedBeforeRead()
        {
            siPort = new MockCommPort(new[]
            {
                SiMessageFixtures.startup_answer, SiMessageFixtures.ok_ext_protocol_answer,
                SiMessageFixtures.si6_64_punches_answer,
                SiMessageFixtures.sicard5_detected, SiMessageFixtures.sicard5_removed
            });

            var siHandlerMock = new Mock<SiHandler>();
            siHandler = siHandlerMock.Object;
            testRunDriver(new SiDriver(siPort, siHandler));
            siHandlerMock.Verify(si => si.Notify(CommStatus.ProcessingError));
        }

        [Test]
        public void startupProtocol_failsOnExtendedProtocolCheck()
        {
            siPort =
                new MockCommPort(new[]
                {SiMessageFixtures.startup_answer, SiMessageFixtures.no_ext_protocol_answer});
            var siHandlerMock = new Mock<SiHandler>();
            siHandler = siHandlerMock.Object;
            testRunDriver(new SiDriver(siPort, siHandler));


            siHandlerMock.Verify(si => si.Notify(CommStatus.Starting));
            siHandlerMock.Verify(si => si.NotifyError((CommStatus.FatalError), It.IsAny<string>()));
            siHandlerMock.Verify(si => si.Notify(CommStatus.Off));
        }

        [Test]
        public void startupProtocol_failsOnTimeout()
        {
            siPort = new MockCommPort();

            var siHandlerMock = new Mock<SiHandler>();
            siHandler = siHandlerMock.Object;
            testRunDriver(new SiDriver(siPort, siHandler));
//TODO in order

            siHandlerMock.Verify(si => si.Notify(CommStatus.Starting));
            siHandlerMock.Verify(si => si.NotifyError(CommStatus.FatalError, It.IsAny<string>()));
            siHandlerMock.Verify(si => si.Notify(CommStatus.Off));
        }

        [Test]
        public void startupProtocol_succeeds()
        {
            siPort =
                new MockCommPort(new[]
                {
                    SiMessageFixtures.startup_answer, SiMessageFixtures.ok_ext_protocol_answer,
                    SiMessageFixtures.si6_64_punches_answer
                });
            var siHandlerMock = new Mock<SiHandler>();
            siHandler = siHandlerMock.Object;
            testRunDriver(new SiDriver(siPort, siHandler));
            //TODO in order

            siHandlerMock.Verify(si => si.Notify(CommStatus.Starting));
            siHandlerMock.Verify(si => si.Notify(CommStatus.Ready));
        }
    }
}