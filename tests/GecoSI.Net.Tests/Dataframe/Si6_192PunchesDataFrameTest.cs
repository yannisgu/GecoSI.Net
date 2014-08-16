using GecoSI.Net.Dataframe;
using NUnit.Framework;

namespace GecoSI.Net.Tests.Dataframe
{
    internal class Si6_192PunchesDataFrameTest
    {
        [Test]
        public void getSiCardNumber()
        {
            Assert.AreEqual(subject821003_192p().SiNumber, ("821003"));
        }

        [Test]
        public void getSiCardSeries()
        {
            Assert.AreEqual(subject821003_192p().SiSeries, ("SiCard 6"));
        }

        [Test]
        public void getStartTime()
        {
            Assert.AreEqual(subject821003_192p().StartTime, (36752000L));
        }

        [Test]
        public void getFinishTime()
        {
            Assert.AreEqual(subject821003_192p().FinishTime, (48684000L));
        }

        [Test]
        public void getCheckTime()
        {
            Assert.AreEqual(subject821003_192p().CheckTime, (36750000L));
        }

        [Test]
        public void getNbPunches()
        {
            Assert.AreEqual(subject821003_192p().NbPunches, (101));
        }

        [Test]
        public void getPunches()
        {
            SiPunch[] punches = subject821003_192p().Punches;

            Assert.AreEqual(punches[0].Code, (31));
            Assert.AreEqual(punches[0].Timestamp, (36762000L));
            Assert.AreEqual(punches[1].Code, (32));
            Assert.AreEqual(punches[1].Timestamp, (36764000L));
            Assert.AreEqual(punches[32].Code, (33));
            Assert.AreEqual(punches[32].Timestamp, (36851000L));
            Assert.AreEqual(punches[63].Code, (34));
            Assert.AreEqual(punches[63].Timestamp, (36940000L));
            Assert.AreEqual(punches[99].Code, (35));
            Assert.AreEqual(punches[99].Timestamp, (37040000L));

            Assert.AreEqual(punches[100].Code, (634));
            Assert.AreEqual(punches[100].Timestamp, (48625000L));
        }

        private ISiDataFrame subject821003_192p()
        {
            return new Si6DataFrame(new[]
            {
                SiMessageFixtures.sicard6_192p_b0_data, SiMessageFixtures.sicard6_192p_b6_data,
                SiMessageFixtures.sicard6_192p_b7_data,
                SiMessageFixtures.sicard6_192p_b2_data, SiMessageFixtures.sicard6_192p_b3_data
            }).StartingAt(0);
        }
    }
}