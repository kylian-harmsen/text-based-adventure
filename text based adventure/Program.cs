using System.Runtime.InteropServices;
Boolean shack = false;
Boolean forest = false;
Boolean door = false;
Boolean GameOn = true;
Boolean lock1 = false;
Boolean lock2 = false;
Boolean lock3 = false;
Boolean smallKey = false;
Boolean mediumKey = false;
Boolean bigKey = false;

Console.WriteLine("Welcome to text based adventure\n\nDo you want to start y/n\n");
string Awnser = Console.ReadLine();
Console.WriteLine();

if (Awnser == "n" || Awnser == "N")
{
    Console.WriteLine("then why even start the program\n");
}

else if (Awnser == "y" || Awnser == "Y")
{
    Console.WriteLine("would you like to see the instructions first y/n\n");
    Awnser = Console.ReadLine();
    Console.WriteLine();
    if (Awnser == "y" || Awnser == "Y")
    {
        Console.WriteLine("Your goal is to find a way to get to your main objective the game will ask alot of questions.\nYou will find roadblocks where you need to explore and uncover a way to continue.\n");
    }

    Console.WriteLine("You are on a journy to find a magic stone rumored to be in this location that can cure any illnes.\nYou need the stone so that you may save your lover that has fallen ill.\npress enter to continue\n");
    Console.ReadLine();
    Console.WriteLine();
    
    while (GameOn == true)
    {
        Console.WriteLine("where would you like to go: abandoned shack/forest/strange door\n");
        Awnser = Console.ReadLine();
        Console.WriteLine();
        if (Awnser == "abandoned shack" || Awnser == "shack")
        {
            shack = true;
        }
        else if(Awnser == "forest")
        {
            forest = true;
        }
        else if (Awnser == "strange door" || Awnser == "door")
        {
            door = true;
        }
        else
        {
            Console.WriteLine("wrong awnser try again");
        }
        while (shack == true)
        {

        }
        while (forest == true)
        {

        }
        while (door == true)
        {
            if (lock1 == true && lock2 == true && lock3 == true)
            {
                Console.WriteLine("the door is open what do you want to do enter or leave\n");
            }
            else
            {
                Console.WriteLine("you see a big old door with 3 locks on it what do you want to investigate\nlock1\nlock2\nlock3\njust leave\n");
            }
            Awnser = Console.ReadLine();
            Console.WriteLine();

            if (Awnser == "lock1" && lock1 == false)
            {
                Console.WriteLine("you see a small key hole would you try putting something in it y/n\n");
                Awnser = Console.ReadLine();
                Console.WriteLine();
                if (Awnser == "y" || Awnser == "Y" && smallKey == false)
                {
                    Console.WriteLine("sorry you have nothing that fits this hole\n");
                }
                else if (Awnser == "n" || Awnser == "N" && smallKey == true)
                {
                    Console.WriteLine("you put the key in the hole and twist you hear a click\n");
                    lock1 = true;
                }
            }
            else if (Awnser == "lock1" && lock1 == true)
            {
                Console.WriteLine("you thin to yourself that you already did this lock\n");
            }
            else if (Awnser == "lock2" && lock2 == false)
            {
                Console.WriteLine("you see a normal key hole would you try putting something in it y/n\n");
                Awnser = Console.ReadLine();
                Console.WriteLine();
                if (Awnser == "y" || Awnser == "Y" && mediumKey == false)
                {
                    Console.WriteLine("sorry you have nothing that fits this hole\n");
                }
                else if (Awnser == "n" || Awnser == "N" && mediumKey == true)
                {
                    Console.WriteLine("you put the key in the hole and twist you hear a click\n");
                    lock2 = true;
                }
            }
            else if (Awnser == "lock2" && lock2 == true)
            {
                Console.WriteLine("you thin to yourself that you already did this lock\n");
            }
            else if (Awnser == "lock3" && lock3 == false)
            {
                Console.WriteLine("you see a big key hole would you try putting something in it y/n\n");
                Awnser = Console.ReadLine();
                Console.WriteLine();
                if (Awnser == "y" || Awnser == "Y" && bigKey == false)
                {
                    Console.WriteLine("sorry you have nothing that fits this hole\n");
                }
                else if (Awnser == "n" || Awnser == "N" && bigKey == true)
                {
                    Console.WriteLine("you put the key in the hole and twist you hear a click\n");
                    lock3 = true;
                }
            }
            else if (Awnser == "lock2" && lock3 == true)
            {
                Console.WriteLine("you thin to yourself that you already did this lock\n");
            }
            else if (Awnser == "leave" && Awnser == "just leave")
            {
                door = false;
            }
            else
            {
                Console.WriteLine("wrong awnser try again");
            }
        }
    }
}

else
{
    Console.WriteLine("not a valid awnser");
}