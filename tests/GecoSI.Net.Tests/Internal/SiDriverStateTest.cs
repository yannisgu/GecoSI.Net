using System;
using GecoSI.Net.Dataframe;
using GecoSI.Net.Internal;
using Moq;
using NUnit.Framework;

namespace GecoSI.Net.Tests.Internal
{
    internal class SiDriverStateTest
    {
        private SiMessageQueue queue;


        private SiHandler siHandler;

        private Mock<SiHandler> siHandlerMock;
        private ICommWriter writer;

        private Mock<ICommWriter> writerMock;


        [SetUp]
        public void setUp()
        {
            siHandlerMock = new Mock<SiHandler>();
            siHandler = siHandlerMock.Object;
            writerMock = new Mock<ICommWriter>();
            writer = writerMock.Object;

            queue = new SiMessageQueue(10, 1);
            SiDriverState.setSicard6_192PunchesMode(false);
            GecoSiLogger.Open();
        }

        [Test]
        public void STARTUP_CHECK()
        {
            queue.Add(SiMessageFixtures.startup_answer);
            SiDriverState nextState = SiDriverState.STARTUP_CHECK.Receive(queue, writer, siHandler);

            Assert.AreEqual(nextState, (SiDriverState.CONFIG_CHECK));
            writerMock.Verify(w => w.Write(SiMessage.GET_PROTOCOL_CONFIGURATION));
        }

        [Test]
        [ExpectedException(typeof (TimeoutException))]
        public void STARTUP_CHECK_throwsTimeoutException()
        {
            SiDriverState.STARTUP_CHECK.Receive(queue, writer, siHandler);
        }

        [Test]
        [ExpectedException(typeof (InvalidMessage))]
        public void STARTUP_CHECK_throwsInvalidMessage()
        {
            queue.Add(SiMessage.ACK_SEQUENCE);
            SiDriverState.STARTUP_CHECK.Receive(queue, writer, siHandler);
        }

        [Test]
        public void CONFIG_CHECK()
        {
            queue.Add(SiMessageFixtures.ok_ext_protocol_answer);
            SiDriverState nextState = SiDriverState.CONFIG_CHECK.Receive(queue, writer, siHandler);

            Assert.AreEqual(nextState, (SiDriverState.SI6_CARDBLOCKS_SETTING));
        }

        [Test]
        public void CONFIG_CHECK_failsOnExtendedProtocol()
        {
            queue.Add(SiMessageFixtures.no_ext_protocol_answer);
            SiDriverState nextState = SiDriverState.CONFIG_CHECK.Receive(queue, writer, siHandler);

            Assert.AreEqual(nextState, (SiDriverState.EXTENDED_PROTOCOL_ERROR));
        }

        [Test]
        public void CONFIG_CHECK_failsOnHandshakeMode()
        {
            queue.Add(SiMessageFixtures.no_handshake_answer);
            SiDriverState nextState = SiDriverState.CONFIG_CHECK.Receive(queue, writer, siHandler);

            Assert.AreEqual(nextState, (SiDriverState.HANDSHAKE_MODE_ERROR));
        }

        [Test]
        public void SI6_CARDBLOCKS_SETTING_64PunchesMode()
        {
            queue.Add(SiMessageFixtures.si6_64_punches_answer);
            SiDriverState nextState = SiDriverState.SI6_CARDBLOCKS_SETTING.Receive(queue, writer, siHandler);

            siHandlerMock.Verify(s => s.Notify(CommStatus.On));
            Assert.False(SiDriverState.sicard6_192PunchesMode());
            Assert.AreEqual(nextState, (SiDriverState.DISPATCH_READY));
        }

        [Test]
        public void SI6_CARDBLOCKS_SETTING_192PunchesMode()
        {
            queue.Add(SiMessageFixtures.si6_192_punches_answer);
            SiDriverState nextState = SiDriverState.SI6_CARDBLOCKS_SETTING.Receive(queue, writer, siHandler);

            siHandlerMock.Verify(s => s.Notify(CommStatus.On));
            Assert.True(SiDriverState.sicard6_192PunchesMode());
            Assert.AreEqual(nextState, (SiDriverState.DISPATCH_READY));
        }

        [Test]
        public void DISPATCH_READY()
        {
            queue.Add(SiMessageFixtures.sicard5_detected);
            SiDriverState.DISPATCH_READY.Receive(queue, writer, siHandler);
            siHandlerMock.Verify(s => s.Notify(CommStatus.Ready));
        }

        [Test]
        public void DISPATCH_READY_dispatchesSiCard5()
        {
            queue.Add(SiMessageFixtures.sicard5_detected);
            SiDriverState.DISPATCH_READY.Receive(queue, writer, siHandler);
            writerMock.Verify(w => w.Write(SiMessage.READ_SICARD_5));
        }

        [Test]
        public void RETRIEVE_SICARD_5_DATA()
        {
            queue.Add(SiMessageFixtures.sicard5_data);
            SiDriverState nextState = SiDriverState.RETRIEVE_SICARD_5_DATA.Retrieve(queue, writer, siHandler);

            writerMock.Verify(w => w.Write(SiMessage.ACK_SEQUENCE));
            siHandlerMock.Verify(s => s.Notify(It.IsAny<Si5DataFrame>()));
            Assert.AreEqual(nextState, (SiDriverState.WAIT_SICARD_REMOVAL));
        }

        [Test]
        public void RETRIEVE_SICARD_5_DATA_earlySiCardRemovalFallbackToDispatchReady()
        {
            queue.Add(SiMessageFixtures.sicard5_removed);
            SiDriverState nextState = SiDriverState.RETRIEVE_SICARD_5_DATA.Retrieve(queue, writer, siHandler);

            siHandlerMock.Verify(s => s.Notify(CommStatus.ProcessingError));
            Assert.AreEqual(nextState, (SiDriverState.DISPATCH_READY));
        }

        [Test]
        public void RETRIEVE_SICARD_5_DATA_timeoutFallbackToDispatchReady()
        {
            SiDriverState nextState = SiDriverState.RETRIEVE_SICARD_5_DATA.Retrieve(queue, writer, siHandler);

            siHandlerMock.Verify(s => s.Notify(CommStatus.ProcessingError));
            Assert.AreEqual(nextState, (SiDriverState.DISPATCH_READY));
        }

        [Test]
        public void DISPATCH_READY_dispatchesSiCard6()
        {
            queue.Add(SiMessageFixtures.sicard6_detected);
            SiDriverState.DISPATCH_READY.Receive(queue, writer, siHandler);
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_6_B0));
        }

        [Test]
        public void DISPATCH_READY_dispatchesSiCard6Star()
        {
            queue.Add(SiMessageFixtures.sicard6Star_detected);
            SiDriverState.DISPATCH_READY.Receive(queue, writer, siHandler);
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_6_B0));
        }

        [Test]
        public void DISPATCH_READY_dispatchesSiCard6In192PunchesMode()
        {
            SiDriverState.setSicard6_192PunchesMode(true);

            queue.Add(SiMessageFixtures.sicard6_detected);
            SiDriverState.DISPATCH_READY.Receive(queue, writer, siHandler);
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_6_B0));
        }

        [Test]
        public void RETRIEVE_SICARD_6_DATA()
        {
            queue.Add(SiMessageFixtures.sicard6_b0_data);
            queue.Add(SiMessageFixtures.sicard6_b6_data);
            queue.Add(SiMessageFixtures.sicard6_b7_data);
            SiDriverState nextState = SiDriverState.RETRIEVE_SICARD_6_DATA.Retrieve(queue, writer, siHandler);

            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_6_B0));
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_6_B6));
            // TODO never
            //writerMock.Verify(s => s.write(SiMessage.read_sicard_6_b7));
            writerMock.Verify(s => s.Write(SiMessage.ACK_SEQUENCE));
            siHandlerMock.Verify(s => s.Notify(It.IsAny<Si6DataFrame>()));
            Assert.AreEqual(nextState, (SiDriverState.WAIT_SICARD_REMOVAL));
        }

        [Test]
        public void RETRIEVE_SICARD_6_8BLOCKS_DATA()
        {
            queue.Add(SiMessageFixtures.sicard6_192p_b0_data);
            queue.Add(SiMessageFixtures.sicard6_192p_b1_data);
            queue.Add(SiMessageFixtures.sicard6_192p_b2_data);
            queue.Add(SiMessageFixtures.sicard6_192p_b3_data);
            queue.Add(SiMessageFixtures.sicard6_192p_b4_data);
            queue.Add(SiMessageFixtures.sicard6_192p_b5_data);
            queue.Add(SiMessageFixtures.sicard6_192p_b6_data);
            queue.Add(SiMessageFixtures.sicard6_192p_b7_data);
            SiDriverState nextState = SiDriverState.RETRIEVE_SICARD_6_DATA.Retrieve(queue, writer, siHandler);
//TODO in order
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_6_B0));
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_6_B6));
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_6_B7));
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_6_PLUS_B2));
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_6_PLUS_B3));
            //TODO never
            //writerMock.Verify(s => s never()).write(SiMessage.read_sicard_6_plus_b4));
            // TODO never
            //		writerMock.Verify(s => s never()).write(SiMessage.read_sicard_6_plus_b5));
            writerMock.Verify(s => s.Write(SiMessage.ACK_SEQUENCE));
            siHandlerMock.Verify(s => s.Notify(It.IsAny<Si6DataFrame>()));
            Assert.AreEqual(nextState, (SiDriverState.WAIT_SICARD_REMOVAL));
        }

        [Test]
        public void DISPATCH_READY_dispatchesSiCard8()
        {
            queue.Add(SiMessageFixtures.sicard8_detected);
            SiDriverState.DISPATCH_READY.Receive(queue, writer, siHandler);
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_8_PLUS_B0));
        }

        [Test]
        public void RETRIEVE_SICARD_8_9_DATA()
        {
            queue.Add(SiMessageFixtures.sicard9_b0_data);
            queue.Add(SiMessageFixtures.sicard9_b1_data);
            SiDriverState nextState = SiDriverState.RETRIEVE_SICARD_8_9_DATA.Retrieve(queue, writer, siHandler);

            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_8_PLUS_B0));
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_8_PLUS_B1));
            writerMock.Verify(s => s.Write(SiMessage.ACK_SEQUENCE));
            siHandlerMock.Verify(s => s.Notify(It.IsAny<Si8PlusDataFrame>()));
            Assert.AreEqual(nextState, (SiDriverState.WAIT_SICARD_REMOVAL));
        }

        [Test]
        public void DISPATCH_READY_dispatchesSiCard10()
        {
            queue.Add(SiMessageFixtures.sicard10_detected);
            SiDriverState.DISPATCH_READY.Receive(queue, writer, siHandler);
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_10_PLUS_B0));
        }

        [Test]
        public void DISPATCH_READY_dispatchesSiCard11()
        {
            queue.Add(SiMessageFixtures.sicard11_detected);
            SiDriverState.DISPATCH_READY.Receive(queue, writer, siHandler);
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_10_PLUS_B0));
        }

        [Test]
        public void DISPATCH_READY_dispatchesSiCard10PlusIn192PunchesMode()
        {
            SiDriverState.setSicard6_192PunchesMode(true);

            queue.Add(SiMessageFixtures.sicard10_detected);
            SiDriverState.DISPATCH_READY.Receive(queue, writer, siHandler);
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_10_PLUS_B0));
        }

        [Test]
        public void RETRIEVE_SICARD_10_PLUS_DATA()
        {
            queue.Add(SiMessageFixtures.sicard10_b0_data);
            queue.Add(SiMessageFixtures.sicard10_b4_data);
            queue.Add(SiMessageFixtures.sicard10_b5_data);
            queue.Add(SiMessageFixtures.sicard10_b6_data);
            queue.Add(SiMessageFixtures.sicard10_b7_data);
            SiDriverState nextState = SiDriverState.RETRIEVE_SICARD_10_PLUS_DATA.Retrieve(queue, writer, siHandler);

//TODO in order
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_10_PLUS_B0));
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_10_PLUS_B4));
            //TODO never
            //writerMock.Verify(s => s never()).write(SiMessage.read_sicard_10_plus_b5));
            //writerMock.Verify(s => s never()).write(SiMessage.read_sicard_10_plus_b6));
            //writerMock.Verify(s => s never()).write(SiMessage.read_sicard_10_plus_b7));
            writerMock.Verify(s => s.Write(SiMessage.ACK_SEQUENCE));
            siHandlerMock.Verify(s => s.Notify(It.IsAny<Si8PlusDataFrame>()));
            Assert.AreEqual(nextState, (SiDriverState.WAIT_SICARD_REMOVAL));
        }

        [Test]
        public void RETRIEVE_SICARD_10_PLUS_DATA_192_MODE()
        {
            queue.Add(SiMessageFixtures.sicard10_b0_data);
            queue.Add(SiMessageFixtures.sicard10_b1_data);
            queue.Add(SiMessageFixtures.sicard10_b2_data);
            queue.Add(SiMessageFixtures.sicard10_b3_data);
            queue.Add(SiMessageFixtures.sicard10_b4_data);
            queue.Add(SiMessageFixtures.sicard10_b5_data);
            queue.Add(SiMessageFixtures.sicard10_b6_data);
            queue.Add(SiMessageFixtures.sicard10_b7_data);
            SiDriverState nextState = SiDriverState.RETRIEVE_SICARD_10_PLUS_DATA.Retrieve(queue, writer, siHandler);

            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_10_PLUS_B0));
            writerMock.Verify(s => s.Write(SiMessage.READ_SICARD_10_PLUS_B4));
            //TODO never
            //writerMock.Verify(s => s never()).write(SiMessage.read_sicard_10_plus_b5));
            //writerMock.Verify(s => s never()).write(SiMessage.read_sicard_10_plus_b6));
            //writerMock.Verify(s => s never()).write(SiMessage.read_sicard_10_plus_b7));
            writerMock.Verify(s => s.Write(SiMessage.ACK_SEQUENCE));
            siHandlerMock.Verify(s => s.Notify(It.IsAny<Si8PlusDataFrame>()));
            Assert.AreEqual(nextState, (SiDriverState.WAIT_SICARD_REMOVAL));
        }

        [Test]
        public void WAIT_SICARD_REMOVAL()
        {
            queue.Add(SiMessageFixtures.sicard5_removed);
            SiDriverState nextState = SiDriverState.WAIT_SICARD_REMOVAL.Receive(queue, writer, siHandler);

            Assert.AreEqual(nextState, (SiDriverState.DISPATCH_READY));
        }

        [Test]
        public void WAIT_SICARD_REMOVAL_timeoutFallbackToDispatchReady()
        {
            SiDriverState nextState = SiDriverState.WAIT_SICARD_REMOVAL.Receive(queue, writer, siHandler);

            Assert.AreEqual(nextState, (SiDriverState.DISPATCH_READY));
        }
    }
}