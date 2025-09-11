using System.Linq.Expressions;

namespace DoDProject;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        bool validChoice = false;
        bool weaponPickedUp = false;

        while (!validChoice)
        {
            Console.WriteLine("You have woken up in a dungeon. You can see two doors, left and right, and something on the floor");
            Console.WriteLine("What will you do? go left, go right or pick up?");

            input = Console.ReadLine().Trim().ToLower();

            if (input == "go left")
            {
                Console.WriteLine("You have chosen the Left door");
                EnterLeftDoorTwoOne();
                validChoice = true;
            }


            else if (input == "go right")
            {
                Console.WriteLine("you have chosen the Right door");
                EnterRightDoorTwoTwo();
                validChoice = true;
            }

            else if (input == "pick up")
            {
                Console.WriteLine("picked up two items, you can only bring one, shield or sword");
                weaponPickedUp = HandlePickup();
                
            }
            else
            {
                Console.WriteLine("try again");
            }
            if (weaponPickedUp && !validChoice)
            {
                bool doorChosen = false;
                while (!doorChosen)
                {
                    Console.WriteLine("You have chosen your weapon, you must choose a door");
                    string doorChoise = Console.ReadLine().Trim().ToLower();

                    if (doorChoise == "go left")
                    {
                        Console.WriteLine("You have chosen the left door. Time will tell if this was wise");
                        EnterLeftDoorTwoOne();
                        doorChosen = true;
                        validChoice = true;
                    }
                    else if (doorChoise == "go right")
                    {
                        Console.WriteLine("You went for the right door and wonder if this will take you to freedom");
                        EnterRightDoorTwoTwo();
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

    }
    static void EnterLeftDoorTwoOne()
    {


        Console.WriteLine("You entered the left door");
        Console.WriteLine("Your memories from before this are ethereal, like a dream you remeber from childhood");
        Console.WriteLine("There is an old diary on the floor. Read it? Y/N");

        bool validResponse = false;
        bool readDiary = false;

        while (!validResponse)
        {
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "y" || input == "yes")
            {
                readDiary = true;
                validResponse = true;
            }
            else if (input == "n" || input == "no")

            {
                readDiary = false;
                validResponse = true;
            }


            else
            {
                Console.WriteLine("Y/N");
            }
        }
        if (readDiary)
        {
            Console.WriteLine("the diary seems ancient, not something you would forget. it has been here a long time, the leather it is bound in seems unatural, you dont understand the language, but somehow you can still read it.");
            Console.WriteLine("I was born from nothing in the shadows and crawled up from black soil covered in ash. Ancient magick rites brought me from beyond to this world to serve. I made it clear that i serve no master before i touched the sorcerer and he perished...");
            Console.WriteLine("The diary seems cursed, better put it down");
        }
        else
        {
            Console.WriteLine("As you walk by the diary, a faint whisper can be heard. The language seems not from this world, the room feels colder now. I think it wants to be read. Visions of some kind of ancient ritual flashed before your eyes");
        }
        Console.WriteLine("You continue to walk in darkness, no sign of light or life. Only damp and moldy air surrounds you until...");
        Console.WriteLine("Another set of two doors. It feels like you are beeing watched by some entity, like rats in a maze. Still, you must pick LEFT or RIGHT.");

        bool thirdRoomChosen = false;
        while (!thirdRoomChosen)
        {
            string thirdRoom = Console.ReadLine().Trim().ToLower();

            if (thirdRoom == "left")
            {
                EnterRoomThreeOne();
                thirdRoomChosen = true;
            }
            else if (thirdRoom == "right")
            {
                EnterRightDoorTwoTwo();
                thirdRoomChosen = true;
            }
            else
            {
                Console.WriteLine("You must pick a path forward. left or right. Being stuck in this void is no option");
            }
        }
    }
    static void EnterRightDoorTwoTwo()
    {
        Console.WriteLine("You entered the room, something does not seem right.");
        Console.WriteLine("You look around, and a large piece of the ceiling if falling, it barely misses you.");
    }

    static bool HandlePickup()
    {
        bool itemChosen = false;

        while (!itemChosen)
        {
            string itemChoice = Console.ReadLine().Trim().ToLower();

            if (itemChoice == "shield")
            {
                Console.WriteLine("You picked up an old wooden SHIELD.");
                itemChosen = true;
            }
            else if (itemChoice == "sword")
            {
                Console.WriteLine("You picked up a rusty old SWORD.");
                itemChosen = true;
            }
            else
            {
                Console.WriteLine("You must pick either SWORD or SHIELD");
            }
        }

        return true;

        static void EnterRoomThreeOne()
        {
            Console.WriteLine("");
        }

    }

}
