namespace GecoSI.Net
{
    public interface ISiPort
    {
        SiMessageQueue CreateMessageQueue();

        ICommWriter CreateWriter();

        void SetupHighSpeed();

        void SetupLowSpeed();

        void Close();
    }
}