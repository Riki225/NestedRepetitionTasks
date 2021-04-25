using System;

namespace nestedrepetitiontask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            int counter2 = 0;

            Console.WriteLine("Please Enter A Name:");
            string getName;
            getName = Console.ReadLine();

            Console.WriteLine("Please Enter Print Amount:");
            int getCounter;
            getCounter = int.Parse(Console.ReadLine());

            while (counter2 < getCounter) {
                counter = counter2;

                while (counter < getCounter) {
                    Console.Write(getName);
                    counter ++;
                }

                Console.WriteLine();
                counter2 ++;
            }

            Console.WriteLine("Goodbye " + getName);
        }
    }
}