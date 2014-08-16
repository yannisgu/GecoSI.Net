using GecoSI.Net.Internal;

namespace GecoSI.Net.Adapter.LogFie
{
    public class NullCommWriter : ICommWriter
    {
        public void Write(SiMessage message)
        {
        }
    }
}