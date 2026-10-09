using System;

namespace MyTeamCityProject
{
    public class Program
    {
        public static string GetGreeting()
        {
            return "Hello, TeamCity!";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(GetGreeting());
        }
    }
}
