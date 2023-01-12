using System;

class Program
{
    static void Main(string[] args);

        static DisplayMessage()
    {
        DisplayWelcomeMessage();

        string UserName = PromptUserName();
        int usernumber = PromptUserNumber();

        int SquaredNumber = SquareNumber(usernumber);

        DisplayResult(UserName,SquaredNumber);
        {
            static void DisplayWelcomeMessage();
            console.WriteLine("Welcome to the Program");

            static string PromptUserName();
            console.Write("Please enter your name: ");
            string name = console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            console.Write("Please your favorite number: ");
            int number = int.parse(console.ReadLine());

            return number;
        }

        static int SquaredNumber()
        {
            int square = number * number;
            return square;

            static void DisplayResult(string name, int square);
            console.WriteLine($"{name}, the square of ypur number is {square} ")
        }
                
    }



    
}