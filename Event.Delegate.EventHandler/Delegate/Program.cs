using System;

namespace Delegate
{
    public delegate void WorkerPerformedHandler(int age, string name);
    class Program
    {

        static void Main(string[] args)
        {

            WorkerPerformedHandler del1 = new WorkerPerformedHandler(Worker1);
            WorkerPerformedHandler del2 = new WorkerPerformedHandler(Worker2);
            WorkerPerformedHandler del3 = new WorkerPerformedHandler(Worker3);
            del1(10, "marco");
            del2(15, "favio");

            DoWork(del1);

            Console.WriteLine("***********************");
            del1 += del2;
            del1 += del3;

            del1(50, "Grande");
            Console.ReadKey();
        }


        static void DoWork(WorkerPerformedHandler workerPerformedHandler)
        {
            workerPerformedHandler(20, "Name by default");
        }

        static void Worker1(int age, string name)
        {
            Console.WriteLine($"Perform1 Age:{age} Name {name}");
        }

        static void Worker2(int age, string name)
        {
            Console.WriteLine($"Perform2 Age:{age} Name {name}");
        }
        static void Worker3(int age, string name)
        {
            Console.WriteLine($"Perform3 Age:{age} Name {name}");
        }
    }
}
