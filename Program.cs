using System.Linq.Expressions;

namespace DoDProject;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        bool validChoice = false;

        while (!validChoice)
        {
            Console.WriteLine("You have woken up in a dungeon. You can see two doors, left and right, and something on the floor");
            Console.WriteLine("What will you do? go left, go right or pick up?");

            input = Console.ReadLine().Trim().ToLower();

            if (input == "go left")
            {
                Console.WriteLine("You have chosen the Left door");
                EnterLeftDoor();
                validChoice = true;
            }


            else if (input == "go right")
            {
                Console.WriteLine("you have chosen the Right door");
                EnterRightDoor();
                validChoice = true;
            }

            else if (input == "pick up")
            {
                Console.WriteLine("picked up two items, you can only bring one, shield or sword");
                HandlePickup();
                validChoice = true;
            }
            {
                string itemChoice = Console.ReadLine().Trim().ToLower();

                if (itemChoice == "shield")
                {
                    Console.WriteLine("You picked up the shield, It is an old wooden shield, not much, but better than nothing");

                }
                else if (itemChoice == "sword")
                {
                    Console.WriteLine("you picked up a sword, it is rusty and probably been here for ages");
                }
                else
                {
                    Console.WriteLine("Try something else");
                }                 
            }
            bool doorChosen = false;
            while (!doorChosen)

            {
                Console.WriteLine("You have chosen your weapon, you must choose a door");
                string doorChoise = Console.ReadLine().Trim().ToLower();

                if (doorChoise == "go left")
                {
                    Console.WriteLine("You have chosen the left door. Time will tell if this was wise");
                    EnterLeftDoor();
                    doorChosen = true;
                    validChoice = true;
                }
                else if (doorChoise == "go right")
                {
                    Console.WriteLine("You went for the right door and wonder if this will take you to freedom");
                    EnterRightDoor();
                    doorChosen = true;
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }

        } 
    static void EnterLeftDoor()
    {
        Console.WriteLine("You entered the left door");    
    }
    static void EnterRightDoor()
    {
        Console.WriteLine("You entered the right door");
    }
    static void HandlePickup()
    {
        string itemChoice = Console.ReadLine().Trim().ToLower();

        if (itemChoice == "shield")
        {
            Console.WriteLine("You picked up a old wooden SHIELD. It is not much, but still better than nothing.");
        }
        else if (itemChoice == "sword")
        {
            Console.WriteLine("You picked up a rusty old SWORD, it is not sharp by any means, but might be useful");
        }
        else
        {
            Console.WriteLine("Try again");
        }
    }
}
