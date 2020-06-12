using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{

    class Program
    {
        // This will not be ran with my program.

        /*
         * This is a comment block
         * Everytime I hit enter, it adds a new line
         */

        static void Main(string[] args) // green will not affect the code.
        {
            int followTrail;

            Console.WriteLine("Your name is Malcolm and you are a knight for a kingdom called Coraden. " +
                "You have been on a trail for half a day, and are searching for the prince who ran away a day ago. " +
                "As you are walking you stumble across some footprints that head towards a cave off the trail,they dont look to be the princes." +
                "Do you follow the unknown footprints?\n\n" +
                "1 Follow the footprints.\n" +
                "2 Continue on the trail.");

        Question:
            followTrail = Convert.ToInt32(Console.ReadLine());

            switch (followTrail)
            {
                case 1:
                    TheMystery();
                    break;

                case 2:
                    Continuing();
                    break;

                default:
                    Console.WriteLine("you take a second to think.");
                    goto Question;
            }

        }

        static void TheMystery()
        {
            int theTest;

            Console.Clear();
            Console.WriteLine("You choose to follow the unknown footprints.\n\n Press a key to continue.");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Curiosity gets the best of you and you follow the unknown footprints." +
                "You stop for a moment infront of the cave." +
                "It seemes to be surrounded by old vines and tress are looming over the enterence with peeps of light shining through." +
                "You think to yourself that it looks like a good hideout." +
                "As you enter the cave you see some straw and follow it to find Just a pile of mud." +
                "The mud seems to be odly shaped into a pyramid.\n\n" +
                "1 Exit the cave");

            Boo:
            theTest = Convert.ToInt32(Console.ReadLine());

            switch (theTest)
            {
                case 1:
                    Continuing();
                    break;

                case 2:
                    TheTest();
                    break;

                default:
                    Console.WriteLine("You stop to rethink");
                    goto Boo;

            }
        }


        static void Continuing()
        {
            int theDark;
            Console.Clear();
            Console.WriteLine("You continue on the trail and leave the footprints.\n\n Press a key to continue");
            
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("After You decide to continue on the trail you jogg forword a little bit making sure that whatever left the footprints coyuldnt reach you." +
                "As you keep walking it seems as if the tress are getting more and more dense around you. You also start to realise the light getting blocked around you." +
                "When you turn around you can still see the light of day shining on the trail." +
                "On the right of you there is a mountain, On the left there is a steep decline off a ledge, and infront of you the trail gets darker and foggy." +
                "Do you choose to go Right or Forwards?\n\n" +
                "1 Right\n" +
                "2 Forward ");

            Console.ReadKey();
            Idea:
            theDark = Convert.ToInt32(Console.ReadLine());

            switch (theDark)
            {
                case 1:
                    TheChild();
                    break;

                case 2:
                    TheDark();
                    break;

                default:
                    Console.WriteLine("You rethink");
                    goto Idea;
            }
        }

        static void TheChild()
        {
            int What; 
            Console.WriteLine("You go right\n Click Enter to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You turn Right deciding not to go towards the dark part of the trail coverd in dense fog. As you start climbing the side of the mountain," +
                "you see a tree above your head. It seems to be floating? You stay still staring for a moment and quickley climb up to the trunk of the tree." +
                "You climb around the trunk until you reach a ledge on the side of the mountain. You then see the tree was really floating." +
                "Then you see a blue glowing orb looking thing on a tree root. you reach forwards and grab the orb. Then the tree drops slowley down to the trail." +
                "The only way you can head is right above the trail coverd in the dark dense fog along the ledge.You are making your way accross the ledge and slip" +
                "falling through the trees into the dark fog.\n\n There is nothing left to do in the cave.\n\n" +
                "1 Forward");
           
            Console.ReadKey();
          Oof:
            What = Convert.ToInt32(Console.ReadLine());

          switch (What)
            {
                case 1:
                    Console.WriteLine("You head forword");
                    break;

                default:
                    Console.WriteLine("You stay still to think even tho you need to leave");
                    goto Oof;
            }
        }

        static void TheDark()
        {
            int Beans;
            Console.WriteLine("You head towards the dark foggy trail ahead./n/n press a key to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("As you keep going forwards, the trees completley cover any light above you." +
                "It soon begins to get foggy and hard to see anything infront of you. You nervousley continue walking forwards" +
                "Then you slip on some wet mud and roll down a hill as mud gets stuck all over you. You stand up after the fall " +
                "and see a pocket of light to your right with some vines. in front of you its extremly dark and seems to be colder." +
                "/n/n Do you wish to go Forwards or to the Right up the vines?/n/n" +
                "1 Forward/n" +
                "2 Right");

            Console.ReadKey();
        water:
            Beans = Convert.ToInt32(Console.ReadLine());

            switch (Beans)
            {
                case 1:
                    Console.WriteLine("you decide to go forwards into the dark.");
                    break;

                case 2:
                    Console.WriteLine("You decide to climb the vines out of the dark.");
                    break;

                default:
                    Console.WriteLine("You take a moment to rethink your options.");
                    goto water;
            }

           
        }

        static void TheTest()
        {
            int Danger;
            Console.Clear();
            Console.WriteLine("You decide to leave he cave.\n\n Press enter to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("As you leave the cave with the thought of mud you decide to continue the trail, as the footprints were nothing." +
                "The trail that you are following seemes to be getting dimmer and dimmer as you continue. You continue walking forward and see dense fog" +
                "not to mention the pitch black trail ahead. To your left there is a steep cliff, the right a mountain that seems climbable," +
                "And the thick fog infront of you.\n\n Do you choose to go forword or left?\n\n" +
                "1 Left\n" +
                "2 Forward");
            Console.ReadKey();
           Thought:
            Danger = Convert.ToInt32(Console.ReadLine());
            switch (Danger)
            {
                case 1:
                    TheChild();
                    break;

                case 2:
                    Forward();
                    break;

                default:
                    Console.WriteLine("You stop to think for a second");
                    goto Thought;
            }

            
        }
        static void Forward()
        {
            Console.WriteLine("You decide to continue forward");
            Console.Clear();
            Console.ReadKey();



        }
    }
}



//Random numberGenerator = new Random();

//int num1 = numberGenerator.Next(1, 11);
//int num2 = numberGenerator.Next(1, 11);

//Start:

//            int chosenItem;

//Console.WriteLine("Take the sword or shield?\n" +
//                " 1 Sword\n" +
//                " 2 Shield");

//            chosenItem = Convert.ToInt32(Console.ReadLine());

//            switch (chosenItem)
//            {
//                case 1:
//                    Console.WriteLine("You take the sword");
//                    break;

//                case 2:
                    
//                    break;

//                default:
//                    Console.WriteLine("You keep on your way and leave the items be.");
//                    break;
//            }

//            //if (chosenItem == 1)
//            //{
//            //    Console.WriteLine("You grabbed the Sword.");
//            //}
//            //else if (chosenItem == 2)
//            //{
//            //    Console.WriteLine("You grabbed the Shield.");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("You keep on your way and leave the items be.");
//            //}


//            goto Start;

//            Console.ReadKey(); 
