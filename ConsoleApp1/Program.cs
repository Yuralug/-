using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;
            int Count = Convert.ToInt32(Console.ReadLine());
            do
            {
             
             input = Console.ReadKey();
                List<Thread> threads = new List<Thread>();
                for (int i = 0; i < Count; i++)
                {
                    threads.Add(new Thread(Method));
                    threads[i].IsBackground = true;
                    threads[i].Start();
                }

            } while (input.Key != ConsoleKey.Escape);
        }
        public static void Method()
        {
            while (true)
            {
                Console.WriteLine("Поток "+(Convert.ToInt32(Thread.CurrentThread.ManagedThreadId)-2));
                Thread.Sleep(2000);
            }
            }
        }
}
