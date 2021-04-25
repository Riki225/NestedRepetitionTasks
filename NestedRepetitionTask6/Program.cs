using System;

namespace nestedrepetitiontask6
{
    class Program
    {
        static void Main(string[] args)
        {
            string getName;
            Console.WriteLine("Please Enter a Name:");
            getName = Console.ReadLine();
 
            int num = 1;
            int counter = 0;
            int printAmount = 5;
 
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