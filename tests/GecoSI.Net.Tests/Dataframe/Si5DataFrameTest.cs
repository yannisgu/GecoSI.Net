using GecoSI.Net.Dataframe;
using GecoSI.Net.Internal;
using NUnit.Framework;

namespace GecoSI.Net.Tests.Dataframe
{
    [TestFixture]
    public class Si5DataFrameTest
    {
        private ISiDataFrame subject304243()
        {
            return new Si5DataFrame(SiMessageFixtures.sicard5_data).StartingAt(0);
        }

        private ISiDataFrame subject36353()
        {
            return new Si5DataFrame(new SiMessage(new byte[]
            {
                0x02, 0xB1, 0x82, 0x00, 0x01, 0xAA, 0x2E, 0x00, 0x01, 0x8E, 0x01,
                0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x65, 0x10, 0x93, 0x04, 0xD2, 0x10, 0xE1, 0x25, 0x56,
                0x11, 0x5C, 0x28, 0x03,
                0xA6, 0x00, 0x07, 0x1F, 0x24, 0x9C, 0x7B, 0x26, 0x9C, 0x8C, 0x22,
                0x9C, 0x8D, 0x28, 0x9C,
                0x8F, 0x34, 0x9C, 0x9B, 0x20, 0x36, 0x9C, 0x9F, 0x33, 0x9C,
                0xA1, 0x35, 0x9C,
                0xA2, 0x3C, 0x9C, 0xA7, 0x3B, 0x9C, 0xA8, 0x21, 0x00, 0xEE,
                0xEE, 0x00, 0xEE,
                0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE,
                0xEE, 0x22, 0x00, 0xEE,
                0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE,
                0xEE, 0x00, 0xEE, 0xEE,
                0x23, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE,
                0x00, 0xEE, 0xEE,
                0x00, 0xEE, 0xEE, 0x24, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE,
                0x00, 0xEE, 0xEE,
                0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE
            })).StartingAt(0);
        }

        [Test]
        public void advanceTimePast_advancesBy12HoursStep()
        {
            var subject = (Si5DataFrame) subject36353();
            Assert.AreEqual(subject.AdvanceTimePast(0, 3600001), (43200000L));
            Assert.AreEqual(subject.AdvanceTimePast(3600000, 100000000L), (133200000L)); // + 36 hours
        }

        [Test]
        public void advanceTimePast_doesNotChangeTimeWhen()
        {
            var subject = (Si5DataFrame) subject36353();
            Assert.AreEqual((object) subject.AdvanceTimePast(1000, 0), (1000L), "Time already past Ref");
            Assert.AreEqual((object) subject.AdvanceTimePast(1000, 1500), (1000L), "Time less than 1 hour behind Ref");
            Assert.AreEqual((object) subject.AdvanceTimePast(1000, AbstractDataFrame.NO_TIME), (1000L),
                "No time for Ref");
        }

        [Test]
        public void advanceTimePast_returnsNoTime()
        {
            var subject = (Si5DataFrame) subject36353();
            Assert.AreEqual((object) subject.AdvanceTimePast(0xEEEE*1000, 0), (AbstractDataFrame.NO_TIME),
                "Time is unknown");
        }

        [Test]
        public void getCheckTime()
        {
            Assert.AreEqual(subject36353().CheckTime, (4444000L));
        }

        [Test]
        public void getFinishTime()
        {
            Assert.AreEqual(subject36353().FinishTime, (4321000L));
        }

        [Test]
        public void getNbPunches()
        {
            Assert.AreEqual(subject36353().NbPunches, (36));
        }

        [Test]
        public void getPunches()
        {
            SiPunch[] punches = subject36353().Punches;
            Assert.AreEqual(punches[0].Code, (36));
            Assert.AreEqual(punches[0].Timestamp, (40059000L));
            Assert.AreEqual(punches[9].Code, (59));
            Assert.AreEqual(punches[9].Timestamp, (40104000L));
        }

        [Test]
        public void getPunches_with36Punches()
        {
            SiPunch[] punches = subject36353().Punches;
            Assert.AreEqual(punches[30].Code, (31));
            Assert.AreEqual(punches[30].Timestamp, (AbstractDataFrame.NO_TIME));
            Assert.AreEqual(punches[35].Code, (36));
            Assert.AreEqual(punches[35].Timestamp, (AbstractDataFrame.NO_TIME));
        }

        [Test]
        public void getPunches_withZeroHourShift()
        {
            ISiDataFrame subject = subject36353().StartingAt(41400000L);
            Assert.AreEqual(subject.StartTime, (44434000L));
            Assert.AreEqual(subject.FinishTime, (47521000L));
            SiPunch[] punches = subject.Punches;
            Assert.AreEqual(punches[9].Timestamp, (83304000L));
            Assert.AreEqual(punches[10].Timestamp, (AbstractDataFrame.NO_TIME));
            Assert.AreEqual(punches[35].Timestamp, (AbstractDataFrame.NO_TIME));
        }

        [Test]
        public void getPunches_withoutStartTime()
        {
            ISiDataFrame subject = subject304243();
            Assert.AreEqual(subject.StartTime, (AbstractDataFrame.NO_TIME));
            Assert.AreEqual(subject.FinishTime, (43704000L));
            SiPunch[] punches = subject.Punches;
            Assert.AreEqual(punches[0].Timestamp, (40059000L));
            Assert.AreEqual(punches[9].Timestamp, (40104000L));
        }

        [Test]
        public void getPunches_withoutStartTime_withMidnightShift()
        {
            ISiDataFrame subject = subject304243().StartingAt(82800000L);
            Assert.AreEqual(subject.StartTime, (AbstractDataFrame.NO_TIME));
            Assert.AreEqual(subject.FinishTime, (86904000L));
            SiPunch[] punches = subject.Punches;
            Assert.AreEqual(punches[0].Timestamp, (83259000L));
            Assert.AreEqual(punches[9].Timestamp, (83304000L));
        }

        [Test]
        public void getSiCardNumber()
        {
            Assert.AreEqual(subject304243().SiNumber, ("304243"));
            Assert.AreEqual(subject36353().SiNumber, ("36353"));
        }

        [Test]
        public void getSiCardSeries()
        {
            Assert.AreEqual(subject36353().SiSeries, ("SiCard 5"));
        }

        [Test]
        public void getStartTime()
        {
            Assert.AreEqual(subject36353().StartTime, (1234000L));
        }
    }
}