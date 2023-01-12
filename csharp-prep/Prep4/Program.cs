using System;
using System.collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        list<int> numbers = new List<int>();

        int usernumber = -1;

        while (usernumber ! = 0) 
        {
            console.Write("Enter a list of numbers (type 0 to quit): ");
            string Response = console.ReadLine();
            Response = int.parse(Response);

            if (Response ! = 0)

        }
            nummbers.Add(Response);
        {
            int(sum) = 0;
            foreach (int number in Response)
            {
                sum += number;
            }
            console.WriteLine($"The sum is: {sum}");

            float Ave = ((float)sum) / numbers.count;
            console.WriteLine($"The Average is: {Ave}");

            int max = numbers[0];
            foreach (int number in numbers)
                {
                    if (number > max)
                
                    max = number;
                }

                console.WriteLine($"The max is: {max}");
    }
}