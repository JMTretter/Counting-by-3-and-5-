using System;

namespace CountingBy3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            
            for (num = 0; num <= 100;  num++)
            {
                if (num % 5 == 0 & num % 3 == 0)
                    Console.WriteLine(num + " FizzBuzz");

                if (num % 3 == 0)
                    Console.WriteLine(num + " Fizz");
                
                if (num % 5 == 0)
                    Console.WriteLine(num + " Buzz");
            }
            Console.ReadLine();

        }
    }
}
