using System;
using GecoSI.Net.Dataframe;

namespace GecoSI.Net.ConsoleApplication
{
    public class ConsoleListener : ISiListener
    {
        public void HandleEcard(ISiDataFrame dataFrame)
        {
            dataFrame.PrintString();
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));
        }

        public void Notify(CommStatus status)
        {
            Console.WriteLine("Status" + DateTime.Now.ToString("hh:mm:ss.fff") + " -> " + status);
        }

        public void Notify(CommStatus errorStatus, String errorMessage)
        {
            Console.WriteLine("Error -> " + errorStatus + " " + errorMessage);
        }

        public bool OnEcardDown(string siNumber)
        {
            Console.WriteLine(siNumber);
            return false;
        }
    }
}