﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread st1 = new Thread(printOdd);
            Thread st2 = new Thread(printEven);

            st1.Priority = ThreadPriority.AboveNormal;
            st2.Priority = ThreadPriority.BelowNormal;

            st1.Start();
            st2.Start();
        }

        static void printOdd()
        {

            for (int i = 1; i <= 500; i += 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i + " ");

            }
        }

        static void printEven()
        {

            for (int i = 0; i <= 500; i += 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i + " ");
            }
        }
    }
}
