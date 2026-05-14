namespace Variables_Exercise;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, what is your name?");
        
        string userName = Console.ReadLine();
        
        Console.WriteLine($"Welcome to the survey {userName}, my name is Richard");

        Console.WriteLine("What is the intial of your last name");

        char lastInitial = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine($"Thank you {userName} {lastInitial}");
        
        Console.WriteLine("Before we start I must ask.");
        Console.WriteLine("How old are you?");
        
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ok, great.Let's get started");
        
        Console.WriteLine("I will be asking financial questions. Are you ok with that?");
        
        string input = Console.ReadLine();

        bool question;
        if (input == "yes")

         
            Console.WriteLine("On average how many times do you go out for food in a month?");
        else 
                Console.WriteLine("Thank you for your time.");
        
        double averageTimes = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("And how much do you typically spend on food when you go out?");
        
        decimal moneySpent = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("Great! That will do it for our quick survey.");

        Console.WriteLine($"Thank you {userName} {lastInitial} for taking the time to help us out");
        
     }
}