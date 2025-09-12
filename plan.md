# TODO

    - Write a simple text based game, where players have to choose to open right or left door.
    The purpose with the code is to get comfortable with simple bools,
    YES/NO, RIGHT/LEFT. And to get a understanding of how to code.
    First door, option to go left or right,
    second door, third door and fourth door.
    Each door leads to either progression or death until the right combination of doors have been found.
    When player dies or escapes, (YOU DIED) or (YOU ESCAPED) will write in terminal. When player dies or escapes, terminal will ask player
    (PLAY AGIN? Y/N) and the player must type Y or N to either stop playing and exit the program, or play another round. When player Chooses N The terminal will write (YOUR BLOODLINE IS WEAK) and exit program. If player choose Y terminal will write (NEW GAME)

     If time allows and I am able to code the program, I will try to first find a way to randomize order of the rooms. As for my current plan, the rooms have been drawn up as a map with all the answers. EXAMPLE, all rooms are in order, 1R, 1L, 2RR, 2LL as in 2RightRight and 2LeftLeft, are the number of the rooms. I want it to be as when player goes in room 4RR in "vanilla" it has an equal chance of going to door 4LRL. The Naming and structure of rooms will make sense on the visual map. in the second room, player always will get either SWORD or SHIELD.[i have no plans for now to attempt make an inventory for now] If that is aslo very managable, room 3 should have an enemy, where player depending on what what item picked up. The terminal will just write
     (A GUARD APPEARS) with the text (YOU KILLED A GUARD) or (YOUR SHIELD BLOCKED AN ATTACK, YOU COUNTER AND KILLED THE GUARD) depending on what item you got.

     With some additional input from Jhonatan, I will make som QOL changes to the map.
     The name structure and a visual overhaul to simplify and make readability easier, will be changed.




     today was somewhat harder that yesterday. I am still fresh, and my understanding is limited.
    As mentioned my goal is to make a text based dungeon game, with if else statements.
    strings and boold and such. I dont understand the coding enoug yet, so i have
    used copilot to somewhat guide me through some steps on the way,
    but using to much AI will inhibit my learning. And still trying to figure out how
    I should use the tool available without cheating to much can be hard.

    I have come to understand some things today.
    How I can code options as if, else, else if. and the inputs start to get in to my brain
    and make sense, its a small step, but a step in the right direction.

    The code now starts in a room, and the player get a question to pick up, go left and go right.
    pick up leads to choosing one of two items, and then returns to the title where player must choose
    between pick up, go left og go right.
    When choosing left, the player gets the message You have chosen the left door.
    But it still returns to the title and do not enter the next room yet.
    There is still much to figure out.

    I think i now understand what static void does.
    it separates the code so in my instance, void 1 is void main, and void 2 is
    static void EnterLeftRoom, where if i understand correctly,
    the code does not read the main section longer, and a new section of code is now reading.
    In short:
    void main is room 1, and void EnterLeftRoom is room 2.


    wednesday sept 10 11.00
    I think i was wrong about void structure.
    but I am learning slowly and steadily I think.
    The statements if, else if and else are starting to meke more sense to me.
    Inputs are starting to make more sense. As do variables and bools and how to use them.
    I still think focusing on back end was the right choice for me.
    Even it is not as "flashy" and visually appealing at first glance,
    there is something drawing me in there.
    I personally think there is more I can do in BE anf FE or FS that will be more meaningful
    to me and what I want to work with.
    I just have to get a deeper understanding.
    To compare this with photography and Photoshop,
    I was a bit slow at first, but after a while when I got The fundementals down,
    operating a camera and using photoshop became second nature.
    I think coding will work in the same way. It is harder to learn in some way as I
    am more used to work in a visual enviroment that gives me instant feedback.

    What i need to get a grip on today or soon, is difficult to explain, because I dont know how to.

    Thursday 9/11
    Still getting a grasp on things. I still struggle. But Im learning.
    Finding that hjerterom for stille studender is the place i code best. No distractions there.
    still struggling with the fundementals like syntax, operators control structures and such. But its a path Im not willing to give.
    I have made progress in my game. I have a clear route to where I want it to go. Just trying to learn from the AI and not copy it, changing keywords the AI gives me to my own, but i make mistakes like we all do. I hope i get more done tomorrow before innlevering. My brain dont understand english very well at the end of the day.


    Friday 12 september. Finally getting some grasp on this thing. I changed the name of ALL the rooms in my code. AI has helped me set up some of the flags/tags/naming(?) of rooms. it helped me get a better understanding, and made it WAY easier to name the rooms after colors. roomBlueOne, yellowFour and such. I understood what i had to do, and more of why it worked. Today has been the day i used AI the least. I asked it to help me color code the rooms, and after i read the code, i had no longer use for it. I just changed the naming of one room with help, and then I did the rest of the naming my self.
    When i started this project I was not sure what I can name, and what I cant. Now I understand better.

    The game has a story, and each of the branches has their own ending. Each has three options to enter a new room, if, if else and else.
    else is usually when player enter a wrong prompt, and the game gives a game related answer instead of try again, to make it more immersive.
    try for your self.

    The game itself was cut a bit shorter than planned. There are some rooms that did not make it. I could have spent more time coding rooms. But I fund it more interesting writing a better story that just left right yes no end.
    I have leared much this week. I still find the best room to code is hjerterom for rolige studenter the best place to be. I can focus better and I dont get distracted. Not very social, but that it what fridays are for.

    Hope you enjoy my Text based, rouge like, souls like game.

# pseudocode

    ```csharp
        // file: Program.cs
        // Variables
        YES/NO
        LEFT/RIGHT

    // Classes
