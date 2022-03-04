using System;
using System.Collections.Generic;
using System.Threading;


namespace ProblematicProblem
{
    
    class Program 
    {

        //static bool cont;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)

{
            bool cont;
            Random rng = new Random();
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            //bool cont = bool.Parse(Console.ReadLine());
            string response = Console.ReadLine();

            
                if (response.ToLower() == "yes")
                { cont = true; }
                else
                {
                    cont = false;
                }
                if (cont == false)
                {
                    Console.WriteLine("Thank you for joining. Good bye.");
                System.Environment.Exit(0);
            }
            
                
            

            
    Console.WriteLine();
    Console.Write("We are going to need your information first! What is your name? ");
    string userName = Console.ReadLine();
    Console.WriteLine();
    Console.Write("What is your age? ");
    int userAge = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            bool seeList; //= bool.Parse(Console.ReadLine());
            string response1 = Console.ReadLine();
            
                if (response1.ToLower() == "sure")
                { seeList = true; }
                else
                {
                    seeList = false;
                }


            if (seeList == true)
    {
        foreach (string activity in activities)
        {
            Console.Write($"{activity} ");
            Thread.Sleep(250);
        }
        Console.WriteLine();
        Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList; //= bool.Parse(Console.ReadLine());
                string response2 = Console.ReadLine();

                if (response2.ToLower() == "yes")
                { addToList = true; }
                else
                {
                    addToList = false;
                }
                Console.WriteLine();
                while (addToList == true)
        {
                    More:
            Console.Write("What would you like to add? ");
            string userAddition = Console.ReadLine();
            activities.Add(userAddition);
            foreach (string activity in activities)
            {
                Console.Write($"{activity} ");
                Thread.Sleep(250);
            }
            Console.WriteLine();
            Console.WriteLine("Would you like to add more? yes/no: ");
                    string more = Console.ReadLine();
                    if (more.ToLower() == "yes")
                    { goto More; }
                    else { goto Less; }
            //string addToList = bool.Parse(Console.ReadLine());
        }
    }

  Less:  //while (cont)
    {
        Console.Write("Connecting to the database");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
                Console.WriteLine();
                Console.Write("Choosing your random activity");
        for (int i = 0; i < 9; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
           Redo:     Console.WriteLine();
                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];
                if (userAge < 21 && randomActivity == "Wine Tasting")
        {
            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
            Console.WriteLine("Pick something else!");
            activities.Remove(randomActivity);
            //string randomNumber = rng.Next(activities.Count);
           // string randomActivity = activities[randomNumber];
        }
                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                string response2  = Console.ReadLine();
                {
                    if (response2.ToLower() == "keep")
                    { goto Keep; }
                    else { goto Redo; }
                }
          Keep:      Console.WriteLine($"We hope you enjoy your activty!");

                
        //bool cont = bool.Parse(Console.ReadLine());
    }
}
    }
}