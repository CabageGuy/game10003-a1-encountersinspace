
//Intro to the game
using System.Dynamic;

Console.WriteLine("The Year is 0067 on the Central Fusion calandar, space is the new frontier many people found refuge around the stars creating colonies.");
Console.WriteLine("However, the EPF Earth Protection Forces have been earth policies for too long, governing the spacenoids for too long, this begining a long fought war over the stars");
Console.WriteLine("who do you wish to fight for? The peace for all spacenoids?[1] or for the right to earthkind?[2]");

Console.ReadLine();
//route 1 the earth forces 
String choice = "2";
if (choice == "2")
{
    Console.WriteLine("Welcome to the team cadet, I hope your transfer to our ship wasn't too hard");
    Console.WriteLine("1. [No thank you for this oppurtunity captain]");
    Console.WriteLine("2. [it wasnt too bad sir! I will complete my mission to eliminate the enemy]");

    String dialouge1 = Console.ReadLine();
    if (dialouge1 == "1")
    {
        Console.WriteLine("Im happy your able to join us for this mission, Ive read your report, and I must say im quite impressed");
        Console.WriteLine("If you follow me this wat we have the mobile suit ready for you to test out");
        Console.WriteLine("[You follow the captain to the Bay, before you line many mobile suits all GMx-03s the basic models for war.");
        Console.WriteLine("[The both of you stop before a pristine white and blue suit, looking more advanced than any other suit]");
        Console.WriteLine("[something about the suit bugs you, like its......calling you]");

    }
    else if (dialouge1 == "2")
    {
        Console.WriteLine("Ah eager to start I see, one small bit of adive to you, dont get too carried away out there");
        Console.WriteLine("Dont ever let your strength get to your head, anyways please follow me, ill show you to your new suit");
        Console.WriteLine("[You follow the captain to the Bay, before you line many mobile suits all GMx-03s the basic models for war.");
        Console.WriteLine("[The both of you stop before a pristine white and blue suit, looking more advanced than any other suit]");
        Console.WriteLine("[something about the suit bugs you, like its......calling you]");
    }

}
else if (choice == "1")
{
    String spacenoid;


}
