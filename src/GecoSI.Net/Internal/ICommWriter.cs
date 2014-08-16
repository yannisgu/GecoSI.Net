using GecoSI.Net.Internal;

namespace GecoSI.Net
{
    public interface ICommWriter
    {
        void Write(SiMessage message);
    }
}