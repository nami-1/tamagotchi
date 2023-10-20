using Microsoft.VisualBasic;
using Namespace;


Console.WriteLine("Welcome to the Tamagotchi");

Tamagotchi tamy = new Tamagotchi();

Console.WriteLine("Choose a name for your Tamagotchi");

tamy.name = Console.ReadLine();

Console.WriteLine($"{tamy.name} is a excellent name!");


while (tamy.GetAlive() == true)
{

    Console.Clear();
    tamy.PrintStats();
    Console.WriteLine("What would you like to do with your pet?");
    Console.WriteLine($" 1. make {tamy.name} say a word?");
    Console.WriteLine($" 2. feed {tamy.name} some food?");
    Console.WriteLine($" 3. make {tamy.name} speak with you?");
    Console.WriteLine($" 4. do nothing.");

    string option = Console.ReadLine();
    if (option == "1")
    {
        Console.WriteLine($"Which word would you like {tamy.name} to say?");
        string word = Console.ReadLine();
        tamy.Teach(word);
    }
    if (option == "2")
    {
        tamy.Feed();
    }
    if (option == "3")
    {
        tamy.Hi();
    }
    else
    {
        Console.WriteLine("Does nothing...");
    }
    tamy.Tick();
}

Console.WriteLine("OH MY GOD HE/SHE IS DAED!!!!!!!");
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();

