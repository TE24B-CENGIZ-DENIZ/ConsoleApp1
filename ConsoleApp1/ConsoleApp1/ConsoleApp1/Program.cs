using System.Net.WebSockets;
using System.Security.Cryptography;

bool isAlive = true;


Console.WriteLine("Welcome to the ship of DOOM this ship was made to test you and bunch of other people who sadly did not pass");
Console.WriteLine("click enter to proceed");

Console.ReadLine();

Console.WriteLine("your objektive is to find the correct path of doors and figure out password with the information you are given this information will be found all around the room you are in one a door closes you can never go back if you get stuck you die");
Console.WriteLine("click enter to proceed");

Console.ReadLine();


Console.WriteLine(" you are able to see two rooms where do you go left or right door?");

//  killer spaceship, tests and cake 

string answer = Console.ReadLine();

if (answer == "left")
{
    Console.WriteLine("welcome to your first objektive you must lead this simulated team to victory in your way stands an astroid and you cannot avoid it you have in your disposal a ray gun, a bomb and a portal which one would you like to use?  ");
    string cheese = Console.ReadLine();
    if (cheese == "bomb")
    {
        Console.WriteLine("turns out the bomb was too strong and you exploded restart the code");

        Console.ReadLine();
    }
    else if (cheese == "portal")
    {
        Console.WriteLine("the team has made it you pass");
    }
    else if (cheese == "ray gun")
    {
        Console.WriteLine("the hole was too small the astroit destroyed the ship rip");
    }


}





if (answer == "right")
{
    Console.WriteLine("you are presented with five objekts a blue cheeseburger, a red gun, a green apple and a yellow shirt. next to that is a paper that says gun, apple, cheeseburger, shirt. and in front of the next door stands some buttons that have the same colors what do you press? and in what order  also you see a cake");
    string response = Console.ReadLine();

    if (response == "first red then green then blue then yellow")
    {
        Console.WriteLine("congrats you win now go have fun in the ship before we get you");
    }
    else if (response == "cake")
    {
        Console.WriteLine("happy birth day you have the secret ending go fun having the cake now");
    }
    else if (response == "grey and white ")
    {
        Console.WriteLine(" sorry we do not have color blind mod yet so you have to die");
    }
    else if (response == "red,green,blue,yellow")
    {
        Console.WriteLine("congrats you win now go have fun in the ship before we get you");
    }
    else if (response == "red green blue yellow")
    {
        Console.WriteLine("congrats you win now go have fun in the ship before we get you");
    }
    else if (response == "red,green,blue and yellow")
    {
        Console.WriteLine("congrats you win now go have fun in the ship before we get you");
    }
    else if (response == "redgreenblueyellow")
    {
        Console.WriteLine("congrats you win now go have fun in the ship before we get you");
    }
    else
    {
        Console.WriteLine("you die lol");
    }
    
}



Console.ReadLine();


// ==  are they equal ?
//isAlive = 6 == 6;
//isAlive = 6 != 7;
// != isn´t equal to 
//{ } kod block doesnt effeck outside


//if block doesn´t current it gets skipt