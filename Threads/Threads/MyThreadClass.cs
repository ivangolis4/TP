using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            Thread thread1 = Thread.CurrentThread;
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Name of Thread: " + thread1.Name + " Process = " + i);

                Thread.Sleep(500);
            }
            Console.WriteLine($"The thread 0x{thread1.ManagedThreadId:X} has exited with code 0 (0x0).");



        }

        public static void Thread2()
        {
            Thread thread2 = Thread.CurrentThread;
            
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Name of Thread: " + thread2.Name + " Process = " + i);

                Thread.Sleep(1000);
            }
            
            Console.WriteLine($"The thread 0x{thread2.ManagedThreadId:X} has exited with code 0 (0x0).");


        }
    }
}
