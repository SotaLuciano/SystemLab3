using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Chapter_4
{
    class Program
    {
        static ConsoleKeyInfo keyInfo;
        static void Main(string[] args)
        {
            Thread st1 = new Thread(PrintPrimes);
            

            st1.Priority = ThreadPriority.Normal;
            
            st1.Start();
            do
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.P)
                {
                    st1.Suspend();
                }
                else if (keyInfo.Key == ConsoleKey.R)
                {
                    st1.Resume();
                }
            }
            while (keyInfo.Key != ConsoleKey.Escape);

            st1.Abort();

        }

        private static bool isSimple(int N)
        {
            for (int i = 2; i < (int)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }

        static void PrintPrimes()
        {
                for (int i = 2; i <= 1000000; i++)
                {
                    if (isSimple(i))
                    {
                        Console.Write(i.ToString() + ",");
                    }
                
                Thread.Sleep(200);
                }
        }
    }
}
