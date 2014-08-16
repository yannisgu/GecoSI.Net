using GecoSI.Net.Internal;
using NUnit.Framework;

namespace GecoSI.Net.Tests
{
    [TestFixture]
    public class CRCCalculatorTest
    {
        [Test]
        public void TestSampleCRC()
        {
            byte[] sample =
            {
                0x53, 0x00, 0x05, 0x01,
                0x0F, 0xB5, 0x00, 0x00,
                0x1E, 0x08
            };
            int expected_crc = 0x2C12;
            Assert.AreEqual(CrcCalculator.Crc(sample), expected_crc);
        }

        [Test]
        public void test2AnswerStartupCrc()
        {
            int expected_crc = 0x0D11;
            byte[] sample = {(byte) 0xF0, 0x03, 0x00, 0x01, 0x4D};
            Assert.AreEqual(CrcCalculator.Crc(sample), (expected_crc));
        }

        [Test]
        public void testAnswerStartupCrc()
        {
            int expected_crc = 0x8B12;
            byte[] sample = {(byte) 0xF0, 0x03, 0x01, 0x01, 0x4D};
            Assert.AreEqual(CrcCalculator.Crc(sample), (expected_crc));
        }

        [Test]
        public void testGetCardBlocksCrc()
        {
            int expected_crc = 0x1611;
            byte[] sample = {(byte) 0x83, 0x02, 0x33, 0x01};
            Assert.AreEqual(CrcCalculator.Crc(sample), (expected_crc));
        }

        [Test]
        public void testGetProtocolModeCrc()
        {
            int expected_crc = 0x0414;
            byte[] sample = {(byte) 0x83, 0x02, 0x74, 0x01};
            Assert.AreEqual(CrcCalculator.Crc(sample), (expected_crc));
        }

        [Test]
        public void testReadSiCard10B8()
        {
            int expected_crc = 0xEA09;
            byte[] sample = {(byte) 0xEF, 0x01, 0x08};
            Assert.AreEqual(CrcCalculator.Crc(sample), (expected_crc));
        }

        [Test]
        public void testReadSiCard5()
        {
            int expected_crc = 0xB100;
            byte[] sample = {(byte) 0xB1, 0x00};
            Assert.AreEqual(CrcCalculator.Crc(sample), (expected_crc));
        }

        [Test]
        public void testReadSiCard6B8()
        {
            int expected_crc = 0x4E0A;
            byte[] sample = {(byte) 0xE1, 0x01, 0x08};
            Assert.AreEqual(CrcCalculator.Crc(sample), (expected_crc));
        }

        [Test]
        public void testReadSiCard6Bx()
        {
            int[] expected_crc = {0x460A, 0x440A, 0x450A, 0x420A, 0x430A, 0x400A, 0x410A};
            byte[] sample_byte = {0x00, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07};
            for (int i = 0; i < expected_crc.Length; i++)
            {
                byte[] sample = {(byte) 0xE1, 0x01, sample_byte[i]};
                Assert.AreEqual(CrcCalculator.Crc(sample), (object) (expected_crc[i]),
                    "CRC failed on Block " + sample_byte[i]);
            }
        }

        [Test]
        public void testReadSiCard8B0()
        {
            int expected_crc = 0xE209;
            byte[] sample = {(byte) 0xEF, 0x01, 0x00};
            Assert.AreEqual(CrcCalculator.Crc(sample), (expected_crc));
        }

        [Test]
        public void testReadSiCard8B1()
        {
            int expected_crc = 0xE309;
            byte[] sample = {(byte) 0xEF, 0x01, 0x01};
            Assert.AreEqual(CrcCalculator.Crc(sample), (expected_crc));
        }

        [Test]
        public void testReadSiCard8Bx()
        {
            int[] expected_crc = {0xE609, 0xE709, 0xE409, 0xE509};
            byte[] sample_byte = {0x04, 0x05, 0x06, 0x07};
            for (int i = 0; i < expected_crc.Length; i++)
            {
                byte[] sample = {(byte) 0xEF, 0x01, sample_byte[i]};
                Assert.AreEqual((object) CrcCalculator.Crc(sample), (expected_crc[i]),
                    "CRC failed on Block " + sample_byte[i]);
            }
        }

        [Test]
        public void testStartupCrc()
        {
            int expected_crc = 0x6D0A;
            byte[] sample = {(byte) 0xF0, 0x01, 0x4D};
            Assert.AreEqual(CrcCalculator.Crc(sample), (expected_crc));
        }
    }
}