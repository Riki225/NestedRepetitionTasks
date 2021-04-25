using System;

namespace nestedrepetitiontask5
{
    class Program
    {
        static void Main(string[] args)
        {
            string amount;
            Console.WriteLine("Please Enter Print Amount:");
            amount = Console.ReadLine();

            string getName;
            Console.WriteLine("Please Enter a Name:");
            getName = Console.ReadLine();
 
            int num = 1;
            int counter = 0;
            int printAmount = int.Parse(amount);
 
            while (num < printAmount)
            {  
                Console.WriteLine(getName);
 
                while(counter < num )
                {
                    Console.Write(getName);
                    counter++;
                }
 
                counter = counter - counter;
                num++;
            }
            Console.WriteLine(getName);
        }    
    }    
}
    
