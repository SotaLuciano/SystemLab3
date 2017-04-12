using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_2_Event
{
    class Program
    {
        static AutoResetEvent waitHandle = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Thread st1 = new Thread(printOdd);
            Thread st2 = new Thread(printEven);

            st1.Start();
            st2.Start();
        }

        static void printOdd()
        {
            waitHandle.WaitOne();
            Console.WriteLine();
            for (int i = 1; i <= 500; i += 2)
            {
                Console.Write(i + " ");
            }
        }

        static void printEven()
        {
            
            for (int i = 0; i <= 500; i += 2)
            {
                Console.Write(i + " ");
            }

            waitHandle.Set();
        }
    }
}
