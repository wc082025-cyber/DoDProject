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

            if (input == "left")
            {
                Console.WriteLine("You have chosen the Left door");
                EnterPinkOne();
                validChoice = true;
            }


            else if (input == "right")
            {
                Console.WriteLine("you have chosen the Right door");
                EnterPinkTwo();
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
                        EnterPinkOne();
                        doorChosen = true;
                        validChoice = true;
                    }
                    else if (doorChoise == "go right")
                    {
                        Console.WriteLine("You went for the right door and wonder if this will take you to freedom");
                        EnterPinkTwo();
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
    static void EnterPinkOne()
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

        bool blueRoomChosen = false;
        while (!blueRoomChosen)
        {
            string blueRoom = Console.ReadLine().Trim().ToLower();

            if (blueRoom == "left")
            {
                EnterRoomBlueOne();
                blueRoomChosen = true;
            }
            else if (blueRoom == "right")
            {
                EnterRoomBlueTwo();
                blueRoomChosen = true;
            }
            else
            {
                Console.WriteLine("You must pick a path forward. left or right. Being stuck in this void is no option");
            }
        }
    }
    static void EnterPinkTwo()
    {
        Console.WriteLine("You entered the room, something does not seem right.");
        Console.WriteLine("You look around, and a large piece of the ceiling if falling.");
        Console.WriteLine("The rocks hit you hard. You feel the bones in you body being crushed... Bleeding out and nearly dead, you hear something...");
        Console.WriteLine("A diffent choice may have saved you from this painful death. You will die while I watch");
        Console.WriteLine("The entity looks disappointed at you, as if it had other plans for your life. But now you can atleast die in peace");
        Console.WriteLine("Life is over. Softly closing your eyes as the pain finally ends... You died... ");
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


    }
    static void EnterRoomBlueOne()
    {
        Console.WriteLine("After walking in darkness you do not feel the time pass. You do not know how long it has been. Time seems irrelevant here");
        Console.WriteLine("You can see a faint light, no windows, no candles, where does the light come from? Better not think to much about it");
        Console.WriteLine("A cruel joke, another set of doors. The left one seems old and rotten, the right feels cool to the touch. What to pick?");

        bool yellowRoomChosen = false;
        while (!yellowRoomChosen)
        {

            string yellowRoom = Console.ReadLine().Trim().ToLower();


            if (yellowRoom == "left")
            {
                EnterYellowRoomOne();
                yellowRoomChosen = true;
            }
            else if (yellowRoom == "right")
            {
                EnterRoomYellowTwo();
                yellowRoomChosen = true;
            }
            else
            {
                Console.WriteLine("Dread, panic and yet calm. Conflicting. Slipping in to madness? Visions of a void. Endless. Static noises.");
                Console.WriteLine("No love, no hate, no pain no memories. I must choose.");
            }

        }


    }
    static void EnterRoomBlueTwo()
    {
        Console.WriteLine("There is some ancient evil here, it must be. You do not remember how you ended up in this room, in fact, you do not remeber anything at all");
        Console.WriteLine("You are blinded by the lack of light, it feels like staring at the sun, but dark.");
        Console.WriteLine("Stumbling in the darkness you feel another set of doors, it feels like they are covered in ash, but not from burning. You must pick LEFT or RIGHT.");

        bool yellowRoomRightChosen = false;
        while (!yellowRoomRightChosen)
        {

            string yellowRoomRight = Console.ReadLine().Trim().ToLower();


            if (yellowRoomRight == "left")
            {
                EnterYellowRoomThree();
                yellowRoomRightChosen = true;
            }
            else if (yellowRoomRight == "right")
            {
                EnterRoomYellowFour();
                yellowRoomRightChosen = true;
            }
            else
            {
                Console.WriteLine("... Your mind and memories are fading. You no longer remember who you are. Some words that somehow seems familiar can be heard.");
                Console.WriteLine("...");
                Console.WriteLine("No love, no hate, no pain no memories. You must choose a path.");
            }

        }

    }



    static void EnterYellowRoomOne()
    {
        Console.WriteLine("A hole on the wall? Can it really be? You can see the sun. Yet it does not seem familiar. Joy does not fill you heart.");
        Console.WriteLine("You feel the presence of something ancient. Feel fear for the last time. An ashen arm appears slowly from nothing while it reaches for you...");
        Console.WriteLine("It feels like something is growing inside you now. Something primal. Something empty. Something hateful and dark...");
        Console.WriteLine("You ascend to something more. Your old vessel turn into dust and sand as you gaze upon the horrors of the world");
        Console.WriteLine("A voice can be heard in a language unfathomable to mortals. This plane of existence is not meant for the likes of us...");
    }

    static void EnterRoomYellowTwo()
    {
        Console.WriteLine("You enter a cold room. There is nothing in here. As you turn around, the door has disappeared.");
        Console.WriteLine("Something touches your shoulder. It is so cold it burns through your clothes and you are petrified...");
        Console.WriteLine("You feel a sharp pain in your back. A shadow of ash speaks, as you feel theese are the last moments of your life...");
        Console.WriteLine("Your life now belongs to the Void. To Nihil. For eternity. Life is a journey to death, and now your journey is over...");
    }



    static void EnterYellowRoomThree()
    {
        Console.WriteLine("Stepping in to a darkness. The floor gives in. You fall for what seems like eternety...");
        Console.WriteLine("As you are falling, you can see the ashen one. The entity holds you still in the air, and fills you with fear beyond comprehension.");
        Console.WriteLine("Petrified with horrors from beyond, your heart gave up.");
        Console.WriteLine("This journey was not meant for those weak of mind. in yout moment of death, you can only think of one thing.");
        Console.WriteLine("If I only had picked another door.");
        Console.WriteLine("YOU DIED");
    }

    static void EnterRoomYellowFour()
    {
        Console.WriteLine("A somewhat brighter room. You see a ladder to the light. As you climb to freedom, voices can be heard.");
        Console.WriteLine("The challenges you have faced was grim. Now you shall be given my curse...");
        Console.WriteLine("I dwell outside you time and space...");
        Console.WriteLine("I dwell in a reality far from your own...");
        Console.WriteLine("I dwell endlessly and without emotion in the void...");
        Console.WriteLine("I trust in all that does not live...");
        Console.WriteLine("I trust in darkness and death...");
        Console.WriteLine("I will breathe my breath of death, and give you life. For life is a journey to death...");
        Console.WriteLine("As death touches. You ascend to something more. Wanting to return to the void of Nihil.");
        Console.WriteLine("Not God. Not Human. Something else entirely. Something not meant to be found...");
    }

}
