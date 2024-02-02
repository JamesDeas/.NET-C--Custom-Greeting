using System;

namespace CustomMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Custom Greeting");
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date and Time: {now}");
            Int32 hour = now.Hour;
            // Int32 hour = 23;
            Console.WriteLine($"Current Hour: {hour}");
            if (hour >= 5 & hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (hour >= 12 & hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (hour >= 18 & hour < 22)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
