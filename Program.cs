using System;

namespace task_3._4._3
{
    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green =300
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Semaphore.Red + "\n" + Semaphore.Yellow + "\n" + Semaphore.Green);

            Console.ReadLine();
        }
    }
}
