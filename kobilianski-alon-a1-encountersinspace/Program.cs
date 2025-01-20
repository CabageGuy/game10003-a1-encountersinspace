
//Intro to the game
using System.Dynamic;
using System.Runtime.CompilerServices;

Console.WriteLine("The Year is 0067 on the Central Fusion calandar, space is the new frontier many people found refuge around the stars creating colonies.");
Console.WriteLine("However, the EPF Earth Protection Forces have been earth policies for too long, governing the spacenoids for too long, this begining a long fought war over the stars");
Console.WriteLine("Who do you wish to fight for? the right to earthkind?[1]");
Console.WriteLine("Or The peace for all spacenoids?[2]");


//route 1 the earth forces 
String choice = Console.ReadLine();
if (choice == "1")
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

            String dialogue2a = Console.ReadLine();
            if (dialogue2a == "1")
            {
                Console.WriteLine("[You run to the change room to get your suit on, after a bit of time you rush back to the hanger without delay you hop in the cockpit and launch]");
                Console.WriteLine("[Space, so vast and empty, but beautiful all the same, you take a moment to gaze out into the stars when suddenly your navigation system goes off, 5 enemy suits are heading your way fast]");
                Console.WriteLine("1. [Engage all 5 head on, I fight for the people of earth this is for them!]");
                Console.WriteLine("2. [Fire a few shots from your rifle to split them off]");

                String dialogue3a = Console.ReadLine();
                //this is where combat begins in the scenario
                if (dialogue3a == "1")
                {
                    Console.WriteLine("[As you bravely engage all 5 enemies, unfortunately for you the overwhelm you and cut through your cockpit]");
                    Console.WriteLine("GAME OVER");
                }
                else if (dialogue3a == "2")
                {
                    Console.WriteLine("[As you shoot a few rounds in their direction, you notice 4 of them split off leaving you face to face with a red suit]");
                    Console.WriteLine("1. [Think over everything, one wrong move and it's over]");
                    Console.WriteLine("2. [Engage in an honorable duel with the red suit]");
                    String dialouge3b = Console.ReadLine();
                    if (dialouge3b == "1")
                    {
                        Console.WriteLine("[As you you think of all the battle strategies you can think of, you notice the red suit approaching fast you very clumsily ready yourself for the worst]");
                        Console.WriteLine("[You unfortunately could not prepare for his assault leading to your cockpit being damaged.......You fought bravely]");
                        Console.WriteLine("GAME OVER");
                    }
                    else if (dialouge3b == "2")
                    {
                        Console.WriteLine("[You stand your guard requesting a duel, in this deep void the only thing that stands before you is the red suit itself]");
                        Console.WriteLine("[As you face the red suit head on you notice something strange...You can hear the pilot in your head]");
                        Console.WriteLine("Well,well welll, aren't you quite a capable fighter, come then let's have a spectacular duel");
                        Console.WriteLine("1. [Unsheath your beam saber and go for slashes to the cockpit]");
                        Console.WriteLine("2. [Start off from afar, try to shoot him down]");

                        String dialogue4a = Console.ReadLine();
                        if (dialogue4a == "1")
                        {
                            Console.WriteLine("[You continue to clash blades with the red suit nothing seems to make him crack]");
                            Console.WriteLine("[Your battle rages on still, when suddenly an explosion goes off before you, blowing you away from the red suit]");
                            Console.WriteLine("[Before you now stands a large mobile suit, one no one has ever seen, as points its rifles at the both of you it tells you] CEASEFIRE NOW");
                            Console.WriteLine("TO BE CONTINUED");
                        }
                        else if (dialogue4a == "2")
                        {
                            Console.WriteLine("[As you aim and fire at the red suit you notice hes dodging every shot flawlessly, slowly getting closer.......Until nothing]");
                            Console.WriteLine("GAME OVER");
                        }

                    }

                }
              
            }
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
        String dialogue1c = Console.ReadLine();
        if (dialogue1c == "1")
        {
            Console.WriteLine("[It seems your ignorance caused you to slip and fall, you mange to activate the launch sequence causing a major accident...You dont survive]");
            Console.WriteLine("GAME OVER");

        }
    }
}
else
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
        Console.WriteLine("Of course, the squad is ready and waiting for launch sequence right now, your special flash model is also ready and waiting");
        Console.WriteLine("[Before standing tall is your red suit, your nickname the Red Nova matches this suit perfectly, you waste no time and prepare to launch]");
        Console.WriteLine("1. [Launch!]");
        string space1a = Console.ReadLine();
        if (space1a == "1")
        {
            Console.WriteLine("[Space is a beautiful void, all you see before you now is your enemies how do you deal with 4 enemy suits]");
            Console.WriteLine("1. [Engage with your team spreading out, take each one, one on one]");

            String sapce2a = Console.ReadLine();
            if (sapce2a == "1")
            {
                Console.WriteLine("[As your team splits off, you notice shots coming your way, a new white suit stands ahead of you, you charge in and attack it]");
                Console.WriteLine("[You realize that this pilot is just like you, an Advanced Human, those that have reached the full potential of their brain]");
                Console.WriteLine("[You engage in a one sided conversation, you know he can hear you but you dont know if he can respond, when suddenly an explosion goes off before you, blowing you away from the White suit]");
                Console.WriteLine("[Before you now stands a large mobile suit, one no one has ever seen, as points its rifles at the both of you it tells you] CEASEFIRE NOW");
                Console.WriteLine("TO BE CONTINUED");
            }
            else if (spacechoice1 == "2")
            {
                Console.WriteLine("My mistake sir! We are ready to move out when you are");
                Console.WriteLine("[As you prepare to launch something inside you calls out to the far reaches of spac, you notice someone out there is calling to you, calling to fight]");
                Console.WriteLine("[After launching you fly out to see a single suit, a white suit standing before you, you only have one choice engage]");
                Console.WriteLine("1. [Let's go]");

                String space3 = Console.ReadLine();
                if (space3 == "1")
                {
                    Console.WriteLine("[You fight this white suit but something seems off....Really off, it can evade any and all of your attacks, it speeds around your view, it wont stop]");
                    Console.WriteLine("[Suddenly a ringing in your head plays, and you hear the voice of the pilot] Die space scum");
                    Console.WriteLine("GAME OVER");
                }
            }
        }
    }
}




