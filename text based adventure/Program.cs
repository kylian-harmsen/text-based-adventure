using System.Runtime.InteropServices;
Boolean shack = false;
Boolean forest = false;
Boolean door = false;
Boolean bastment = false;
Boolean GameOn = true;
Boolean lock1 = false;
Boolean lock2 = false;
Boolean lock3 = false;
Boolean smallKey = false;
Boolean mediumKey = false;
Boolean bigKey = false;
Boolean shovel = false;
Boolean code = false;
Boolean bookshelf = false;
Boolean book = false;

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
            if (bookshelf == false)
            {
                Console.WriteLine("your indside the old abandoned shack you see a strangly placed bookshelf a safe and a rack of tools\n");
                Console.WriteLine("what do you wnnt to ivestigate shelf safe tools or just leave\n");
            }
            else if (bookshelf == true)
            {
                Console.WriteLine("your indside the old abandoned shack you see the stairs leading down to a basement a safe and a rack of tools\n");
                Console.WriteLine("what do you want to ivestigate stairs safe tools or just leave\n");
            }
            Awnser = Console.ReadLine();
            Console.WriteLine();
            if (Awnser == "shelf" && bookshelf == false && book == false)
            {
                Console.WriteLine("looking at the bookshelf you just cant shake the feeling its in such an od place and looking closer the entire thing still seems to be full of books exept for one place maby you could place something inside\n");
            }
            else if (Awnser == "shelf" && bookshelf == false && book == true)
            {
                Console.WriteLine("you place the book inside and just like that the closet starts moving on its own revealing a staircase to a bastment\n");
                bookshelf = true;
            }
            else if (Awnser == "tools" && shovel == false)
            {
                Console.WriteLine("you see a bunch of old worn out tools the shovel seems in good shape so you take it could be handy later\n");
                shovel = true;
            }
            else if (Awnser == "tools" && shovel == true)
            {
                Console.WriteLine("all the other tools either look to worn out or useless\n");
            }
            else if (Awnser == "safe" && code == false && book == false)
            {
                Console.WriteLine("a safe with a 5 didgit code on it you wonder whats inside but its no use guesing the combination\n");
            }
            else if (Awnser == "safe" && code == true && book == false)
            {
                Console.WriteLine("you open the safe and find a normal sized key and a book inside\n");
                mediumKey = true;
                book = true;
            }
            else if (Awnser == "safe" && code == true && book == true)
            {
                Console.WriteLine("just an empty safe now\n");
            }
            else if (Awnser == "stairs" && bookshelf == true)
            {
                Console.WriteLine("you go down the stairs and enter the bastment\n");
                bastment = true;
            }
            else if (Awnser == "leave" || Awnser == "just leave")
            {
                shack = false;
            }
            else
            {
                Console.WriteLine("not a valid awnser\n");
            }
            while (bastment == true)
            {
                Console.WriteLine("you enter the bastment and see a small room with a desk inside what do you want to do go to the desk or leave\n");
                Awnser = Console.ReadLine();
                Console.WriteLine();
                if (Awnser == "desk" && smallKey == false)
                {
                    Console.WriteLine("you walk up to the desk and open a drawr inside is a small key and a note the note reads as followed\nif you are here for the magic stone it comes at a cost grabing the stone will make you sick and your life would be cut rather short so you will have a choice use it on some one you love or save yourself\n");
                    smallKey = true;
                }
                else if (Awnser == "desk" && smallKey == true)
                {
                    Console.WriteLine("I dont want to read that note again");
                }
                else if (Awnser == "leave" || Awnser == "just leave")
                {
                    bastment = false;
                }
                else
                {
                    Console.WriteLine("wrong awnser try again\n");
                }
            }
        }

        while (forest == true)
        {
            Console.WriteLine("you walk into the forest looking around 2 things stick out an op patch of land and a hollow tree\n");
            Console.WriteLine("where would you like to look first patch, tree or just leave\n");
            Awnser = Console.ReadLine();
            Console.WriteLine();
            if (Awnser == "patch" && shovel == false)
            {
                Console.WriteLine("od patch of land you think something may be buried here\n");
            }
            else if (Awnser == "patch" && shovel == true && bigKey == false)
            {
                Console.WriteLine("you use the shovel you found to dig a hole you find a neet little box with a big key inside\n");
                bigKey = true;
            }
            else if (Awnser == "patch" && shovel == true && bigKey == true)
            {
                Console.WriteLine("I like digging holes but I dont see a point in digging any deeper than this\n");
            }
            else if (Awnser == "tree" && code == false)
            {
                Console.WriteLine("you walk up to the hollow tree and stick your arm inside you get a small wooden box with a code inside it\n");
                code = true;
            }
            else if (Awnser == "tree" && code == true)
            {
                Console.WriteLine("you put your arm down the hollow tree but dont find anything new\n");
            }
            else if (Awnser == "leave" || Awnser == "just leave")
            {
                forest = false;
            }
            else
            {
                Console.WriteLine("wrong awnser try again\n");
            }
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
                if (Awnser == "y" && smallKey == false)
                {
                    Console.WriteLine("sorry you have nothing that fits this hole\n");
                }
                else if (Awnser == "y" && smallKey == true)
                {
                    Console.WriteLine("you put the key in the hole and twist you hear a click\n");
                    lock1 = true;
                }
            }
            else if (Awnser == "lock1" && lock1 == true)
            {
                Console.WriteLine("you think to yourself that you already did this lock\n");
            }
            else if (Awnser == "lock2" && lock2 == false)
            {
                Console.WriteLine("you see a normal key hole would you try putting something in it y/n\n");
                Awnser = Console.ReadLine();
                Console.WriteLine();
                if (Awnser == "y" && mediumKey == false)
                {
                    Console.WriteLine("sorry you have nothing that fits this hole\n");
                }
                else if (Awnser == "y" && mediumKey == true)
                {
                    Console.WriteLine("you put the key in the hole and twist you hear a click\n");
                    lock2 = true;
                }
            }
            else if (Awnser == "lock2" && lock2 == true)
            {
                Console.WriteLine("you think to yourself that you already did this lock\n");
            }
            else if (Awnser == "lock3" && lock3 == false)
            {
                Console.WriteLine("you see a big key hole would you try putting something in it y/n\n");
                Awnser = Console.ReadLine();
                Console.WriteLine();
                if (Awnser == "y" && bigKey == false)
                {
                    Console.WriteLine("sorry you have nothing that fits this hole\n");
                }
                else if (Awnser == "y" && bigKey == true)
                {
                    Console.WriteLine("you put the key in the hole and twist you hear a click\n");
                    lock3 = true;
                }
            }
            else if (Awnser == "lock3" && lock3 == true)
            {
                Console.WriteLine("you think to yourself that you already did this lock\n");
            }
            else if (Awnser == "leave" || Awnser == "just leave")
            {
                door = false;
            }
            else
            {
                Console.WriteLine("wrong awnser try again\n");
            }
        }
    }
}

else
{
    Console.WriteLine("not a valid awnser\n");
}