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
                EnterLeftDoor();
            }

            {
                Console.WriteLine("You have chosen the Left door");
            }
            else if (input == "go right")
            {
                EnterRightDoor();
            }
            {
                Console.WriteLine("you have chosen the Right door");
            }
            else if (input == "pick up")
            {
                HandlePickup();
            }
            {
                Console.WriteLine("picked up two items, you can only bring one, shield or sword");
                string itemChoice = Console.ReadLine().Trim().ToLower();

                if (itemChoice == "shield")
                {
                    Console.WriteLine("Youo picked up the shield, It is an old wooden shield, not much, but better than nothing");

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


            else
            {
                Console.WriteLine("Try again");
            }

        }


    }
    static void EnterLeftDoor()
        {
            Console.WriteLine("You Enter the left door, there is a guard. You have a weapon, and kill the guard. Go through the left or right door?");
            string action = Console.ReadLine().Trim().ToLower();
        }
}
