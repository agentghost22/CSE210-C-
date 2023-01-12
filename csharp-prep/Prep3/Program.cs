using System;

class Program
{
    static void Main(string[] args)
    { 
        Random randomGenerator = new Random();
        //int number = randomGenerator.Next(1, 120);
        int number = 5;
        int guess = -2;

        while ( guess != number )
        {
            Console.Write("what is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if ( number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if ( number < guess) 
            {
                Console.WriteLine("Lower");
            }
        }
       
        Console.WriteLine("You Guessed right!!!!");
    }
}