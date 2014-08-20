//  
//  Copyright (c) 2013-2014 Simon Denier & Yannis Guedel
//  
namespace GecoSI.Net.Dataframe
{
    public abstract class SiAbstractDataFrame : AbstractDataFrame
    {
        protected static readonly long NO_SI_TIME = 1000L*0xEEEE;

        protected static readonly long TWELVE_HOURS = 1000L*12*3600;

        protected static readonly long ONE_DAY = 2*TWELVE_HOURS;

        protected byte[] dataFrame;

        protected int ByteAt(int i)
        {
            return dataFrame[i] & 0xFF;
        }

        protected int WordAt(int i)
        {
            return ByteAt(i) << 8 | ByteAt(i + 1);
        }

        protected int Block3At(int i)
        {
            return ByteAt(i) << 16 | WordAt(i + 1);
        }

        protected long TimestampAt(int i)
        {
            return 1000L*WordAt(i);
        }

        public long AdvanceTimePast(long timestamp, long refTime, long stepTime)
        {
            if (timestamp == NO_SI_TIME)
            {
                return NO_TIME;
            }
            if (refTime == NO_TIME)
            {
                return timestamp;
            }
            long newTimestamp = timestamp;
            // advance time until it is at least less than one hour before refTime
            // accomodates for drifting clocks or even controls with different daylight savings mode
            long baseTime = refTime - 3600000;
            while (newTimestamp < baseTime)
            {
                newTimestamp += stepTime;
            }
            return newTimestamp;
        }

        public long NewRefTime(long refTime, long punchTime)
        {
            return punchTime != NO_TIME ? punchTime : refTime;
        }
    }
}