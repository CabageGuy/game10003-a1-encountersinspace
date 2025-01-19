
//Intro to the game
using System.Dynamic;

Console.WriteLine("The Year is 0067 on the Central Fusion calandar, space is the new frontier many people found refuge around the stars creating colonies.");
Console.WriteLine("However, the EPF Earth Protection Forces have been earth policies for too long, governing the spacenoids for too long, this begining a long fought war over the stars");
Console.WriteLine("who do you wish to fight for? The peace for all spacenoids?[1]");
Console.WriteLine("Or for the right to earthkind?[2]");

Console.ReadLine();
//route 1 the earth forces 
String choice = "2";
if (choice == "2")
{
    Console.WriteLine("Welcome to the team cadet, I hope your transfer to our ship wasn't too hard");
    //every option is made with numbers 
    Console.WriteLine("1. [No thank you for this oppurtunity captain]");
    Console.WriteLine("2. [It wasnt too bad sir! I will complete my mission to eliminate the enemy]");
   
    String dialouge1 = Console.ReadLine();
    if (dialouge1 == "1")
    {
        Console.WriteLine("Im happy your able to join us for this mission, Ive read your report, and I must say im quite impressed");
        Console.WriteLine("If you follow me this wat we have the mobile suit ready for you to test out");
        Console.WriteLine("[You follow the captain to the Bay, before you line many mobile suits all GMx-03s the basic models for war.");
        Console.WriteLine("[The both of you stop before a pristine white and blue suit, looking more advanced than any other suit]");
        Console.WriteLine("[something about the suit bugs you, like its......calling you]");
        Console.WriteLine("Well here it is, your very own personal mobile suit, the RX-09e7 we dont have a proper name for it just yet but better take good care of it understood?");
        Console.WriteLine("1. [SIR!]");

        string dialouge1b = Console.ReadLine();
        if (dialouge1b == "1")
        {
            Console.WriteLine("[As you salute the captain goodbye you can't help but stare at the MS suddenly the alarms start blaring]");
            Console.WriteLine("MS team prepare to launch multiple suits inbound");
            Console.WriteLine("1. [Prepare to launch]");
            Console.WriteLine("2. [Ignore your orders, and find a place to relax]");

        }
        //extra option if you choose not to say anything
        else 
        {
            Console.WriteLine("[You ignore the Captain, you are too entracned by the MS infront of you]");
            Console.WriteLine("[Suddenly the alarms start to blare a voice speaks through the intercoms]");
            Console.WriteLine("MS team prepare to launch multiple suits inbound");
            Console.WriteLine("1. [Prepare to launch]");
            Console.WriteLine("2. [Ignore your orders, and find a place to relax]");
        }

    }
    //Second dialogue option for dialogue1
    else if (dialouge1 == "2")
    {
        Console.WriteLine("Ah eager to start I see, one small bit of adive to you, dont get too carried away out there");
        Console.WriteLine("Dont ever let your strength get to your head, anyways please follow me, ill show you to your new suit");
        Console.WriteLine("[You follow the captain to the Bay, before you line many mobile suits all GMx-03s the basic models for war.");
        Console.WriteLine("[The both of you stop before a pristine white and blue suit, looking more advanced than any other suit]");
        Console.WriteLine("[something about the suit bugs you, like its......calling you]");
        Console.WriteLine("Well here it is, your very own personal mobile suit, the RX-09e7 we dont have a proper name for it just yet but better take good care of it understood?");
        Console.WriteLine("1. [Whatever]");
    }

}
else if (choice == "1")
{
    String spacenoid;
    Console.WriteLine("[In the out reaches of space lays Colony 16, the Neo Zoids base of operations]");
    Console.WriteLine("[You have risen the ranks through blood sweat and tears, and now here you are an ace pilot and a lieutenant aboard the new Flagz warship]");
    Console.WriteLine("So glad you can make it lieutenant, I hope the trip wasn't too bad for you");
    Console.WriteLine("1. [Don't worry about me, how we looking? Is everyone ready to attack their new ship?]");
    Console.WriteLine("2. [Im fine thank you, please lets not waste anymore time and rid ourselves of the EPF and that new ship]");

    String spacechoice1 = Console.ReadLine();
    if (spacechoice1 == "1")
    {


    }
    else if (spacechoice1 == "2")
    { 
    
    }
}

