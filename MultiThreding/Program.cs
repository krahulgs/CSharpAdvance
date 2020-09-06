using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        //Parallel.ForEach Method accepts 2 parameters, 1st is Ienumerable collection and second the action to be performed on each item in list
        //lets understand this with an example. 
        static void workOnItem(object item)
        {
            Console.WriteLine("start working on item " + item);
            Thread.Sleep(1000);
            Console.WriteLine("stop working on item " +item);

        }

        static void Main(string[] args)
        {
            Parallel.Invoke(() => task1(), () => task2(), () => task3());

            //lets call work on item mentos under Parallel.Foreach loop
            //lets define the item
            Console.WriteLine("********************* Parallel.ForEach() ****************************");
            var items =Enumerable.Range(0, 5).ToArray();
            Parallel.ForEach(items, item =>
            {
                workOnItem(item);
            });

            /**************************************************************************
             Parallel.For method is used to make parallel execution of for loop, which is govered by a control variable
            I am using the same method workOnItem to test Paralle.For() method, Iu takes 3 parameters
                    1- counter
                    2- length of the item
                    3- lambda expression, in which we pass a variable that counter value for each iteration
            **************************************************************************************/
            Console.WriteLine("********************* Parallel.For() ****************************");
            Parallel.For(0, items.Length, i =>
            {
                workOnItem(items[i]);
            }); 

            Console.WriteLine("Task Finished, Press any key to exit");
            Console.ReadKey();

        }
    }
}
