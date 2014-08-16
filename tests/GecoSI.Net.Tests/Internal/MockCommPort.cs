using System.Linq;
using GecoSI.Net.Internal;

namespace GecoSI.Net.Tests.Internal
{
    public class MockCommPort : ISiPort
    {
        private readonly MockComm comm;

        private readonly SiMessageQueue messageQueue;

        /**
	 * Constructor for timeout (empty queue)
	 */

        public MockCommPort()
            : this(new SiMessage[0])
        {
        }

        public MockCommPort(SiMessage[] siMessages)
        {
            comm = new MockComm();
            messageQueue = new SiMessageQueue(siMessages.Length + 1, 1);
            siMessages.ToList().ForEach(messageQueue.Add);
        }

        public SiMessageQueue CreateMessageQueue()
        {
            return messageQueue;
        }

        public ICommWriter CreateWriter()
        {
            return comm;
        }

        public void SetupHighSpeed()
        {
        }

        public void SetupLowSpeed()
        {
        }

        public void Close()
        {
            // TODO test always closed/called
        }

        public class MockComm : ICommWriter
        {
            public void Write(SiMessage message)
            {
            }
        }
    }
}