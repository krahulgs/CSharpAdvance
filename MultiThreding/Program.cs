using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreding
{
    class Program
    {
        static void task1()
        {
            Console.WriteLine("Task 1 started");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 finished");
        }
        static void task2()
        {
            Console.WriteLine("Task 2 started");
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 finished");
        }
        static void task3()
        {
            Console.WriteLine("Task 3 started");
            Thread.Sleep(3000);
            Console.WriteLine("Task 3 finished");
        }
        static void Main(string[] args)
        {
            Parallel.Invoke(() => task1(), () => task2(),()=>task3());
            Console.WriteLine("Task Finished, Press any key to exit");
            Console.ReadKey();
        }
    }
}
