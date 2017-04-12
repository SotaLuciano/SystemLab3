using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_5
{
    class Program
    {
        static ManualResetEvent waitHandle_1 = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            Thread st1 = new Thread(printEvent);
            st1.Start();

            Console.WriteLine("Thread_1 started");

            waitHandle_1.WaitOne();
            Console.WriteLine("Manual Reset Event Thread_1 signaled");

            waitHandle_1.Reset();

            Thread st2 = new Thread(printEvent);
            st2.Start();
            Console.WriteLine("Thread_2 started");
            waitHandle_1.WaitOne();
            Console.WriteLine("Manual Reset Event Thread_2 signaled");
        }

        static void printEvent()
        {
            Console.WriteLine("Print Event");
            waitHandle_1.Set();
        }


        //////////////////////////////////////////////////////////////////
        //static AutoResetEvent waitHandle_2 = new AutoResetEvent(false);
        //static void Main(string[] args)
        //{
        //    Thread st1 = new Thread(printEvent);
        //    st1.Start();

        //    Console.WriteLine("Thread_1 started");

        //    waitHandle_2.WaitOne();
        //    Console.WriteLine("Auto Reset Event Thread_1 signaled");

        //    Thread st2 = new Thread(printEvent);
        //    st2.Start();
        //    Console.WriteLine("Thread_2 started");
        //    waitHandle_2.WaitOne();
        //    Console.WriteLine("Auto Reset Event Thread_2 signaled");
        //}

        //static void printEvent()
        //{
        //    Console.WriteLine("Print Event");
        //    waitHandle_2.Set();
        //}

    }
}
