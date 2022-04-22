using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
        
             
            if(number % 2 == 0) {
                Console.WriteLine("Not Prime Number");
            } else {
                Console.WriteLine("Prime number");
            }


            Console.ReadLine();
        }
    }
}
