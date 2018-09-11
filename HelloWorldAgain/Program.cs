using System;

namespace HelloWorldAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int userAge;
            string favQuote;
            string quoteBy;
            string answer;

            Console.WriteLine("Hello User! What is your name?");
            userName = Console.ReadLine();

            Console.WriteLine("Cool name, {0}! How old are you?", userName);
            userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("That's interesting! I thought... Nevermind. I love words! What's your favorite quote?");
            favQuote = Console.ReadLine();

            Console.WriteLine("Nice! Who is that quote by?");
            quoteBy = Console.ReadLine();

            Console.WriteLine("I think you're pretty cool! Let's see if I remember these things. Your name is {0}. You are {1} years old and {2} by {3} is your favorite quote.  Am I right? (y/n)", userName, userAge, favQuote, quoteBy);
            answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.WriteLine("Yay! Can we be best friends?");
            } else
            {
                Console.WriteLine("Wow... well you're a sucky programmer!");
            }
            Console.ReadLine();

        }
    }
}
