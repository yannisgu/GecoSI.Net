using GecoSI.Net.Dataframe;
using Moq;
using NUnit.Framework;

namespace GecoSI.Net.Tests
{
    [TestFixture]
    public class SIHandlerTest
    {
        [Test]
        public void notifySiCard5()
        {
            ISiListener listener;
            var listenerMock = new Mock<ISiListener>();
            var sicard5Mock = new Mock<Si5DataFrame>();
            var siHandler = new SiHandler(listenerMock.Object);
            siHandler.SetZeroHour(10000L);
            siHandler.Notify(sicard5Mock.Object);


            sicard5Mock.Verify(si => si.StartingAt(10000L));
        }
    }
}