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
            int Count = Convert.ToInt32(Console.ReadLine());
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < Count; i++)
            {
                threads.Add(new Thread(Method));
                threads[i].Start();
            }

        }
        public static void Method()
        {
            while (true)
            {
                Console.WriteLine("Поток");
                Thread.Sleep(2000);
            }
            }
        }
}
