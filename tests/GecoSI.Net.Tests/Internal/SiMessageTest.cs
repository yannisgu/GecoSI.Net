using GecoSI.Net.Internal;
using NUnit.Framework;

namespace GecoSI.Net.Tests.Internal
{
    [TestFixture]
    internal class SiMessageTest
    {
        private readonly SiMessage message = new SiMessage(new byte[] {0x02, 0xF0, 0x01, 0x4D, 0x6D, 0x0A, 0x03});
        private readonly SiMessage crc_fail = new SiMessage(new byte[] {0x02, 0xF0, 0x01, 0x4D, 0x00, 0x00, 0x03});
        private readonly SiMessage bad_start = new SiMessage(new byte[] {0x00, 0xF0, 0x01, 0x4D, 0x00, 0x00, 0x03});
        private readonly SiMessage bad_end = new SiMessage(new byte[] {0x02, 0xF0, 0x01, 0x4D, 0x00, 0x00, 0x00});
        private readonly SiMessage bad_cmd = new SiMessage(new byte[] {0x02, 0x00, 0x01, 0x4D, 0x00, 0x00, 0x03});

        [Test]
        public void check()
        {
            Assert.True(message.Check(0xF0));
        }

        [Test]
        public void check_failsOnBadCommand()
        {
            Assert.False(bad_cmd.Check(0xF0));
        }

        [Test]
        public void check_failsOnBadStartOrBadEnd()
        {
            Assert.False(bad_start.Check(0xF0));
            Assert.False(bad_end.Check(0xF0));
        }

        [Test]
        public void check_failsOnCrcError()
        {
            Assert.False(crc_fail.Check(0xF0));
        }

        [Test]
        public void commandByte()
        {
            Assert.AreEqual(message.CommandByte(), 0xF0);
        }

        [Test]
        public void computeCRC()
        {
            Assert.AreEqual(message.ComputeCrc(), (0x6D0A));
        }

        [Test]
        public void extractCRC()
        {
            Assert.AreEqual(message.ExtractCrc(), (0x6D0A));
        }
    }
}