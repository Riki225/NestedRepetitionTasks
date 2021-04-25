using System;

namespace nestedrepetitiontask3
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

            while (counter2 < 5) {
                counter = counter2;

                while (counter < 5) {
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