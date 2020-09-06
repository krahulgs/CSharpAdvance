# CSharpAdvance
Multithreading

It is important to note that , your program cn not control the execution of thread. This is the Operating system which decides which tread will start first.
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
        static void Main(string[] args)
        {
            # INVOKE METHOD TAKES ARRAY OF ACTIONS AS A PARAMETER AND EXECUTES EACH OF THE ACTIONS IN PARALLEL
            Parallel.Invoke(() => task1(), () => task2());
            Console.WriteLine("Task Finished, Press any key to exit");
            Console.ReadKey();
        }
    }
