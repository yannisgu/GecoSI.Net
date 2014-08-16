using System;
using System.IO;

namespace GecoSI.Net.ConsoleApplication
{
    internal class Program
    {
        private static int Main(string[] args)
        {
      
            if (args.Length == 0)
            {
                PrintUsage();
#if DEBUG
                System.Console.Read();
#endif
                return 0;
            }

            var handler = new SiHandler(new ConsoleListener());

            if (args.Length == 1)
            {
                try
                {
                    handler.Connect(args[0]);
                }
                catch (Exception e)
                {
                    e.PrintStackTrace();
#if DEBUG
                    System.Console.Read();
#endif
                }
            }
            else if (args.Length == 2 && args[0].Equals("--file"))
            {
                try
                {
                    handler.ReadLog(args[1]);
                }
                catch (IOException e)
                {
                    e.PrintStackTrace();
#if DEBUG
                    System.Console.Read();
#endif
                }
            }
            else
            {
                System.Console.WriteLine("Unknown command line option");
                PrintUsage();
#if DEBUG
                System.Console.Read();
#endif
                return (1);
            }

            return 0;

        }

        private static void PrintUsage()
        {
            System.Console.WriteLine("Usage: java net.gecosi.SiHandler <serial portname> | --file <log filename>");
        }

    }

    

}