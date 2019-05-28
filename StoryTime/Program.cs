using System;

namespace StoryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE TRI-FORKED ROAD, WHAT IS YOUR NAME?");
            string answer = Console.ReadLine();
            Console.Clear();

            if (answer == "Chosen One")
            {
                Console.WriteLine("Hello, Chosen One. I have been waiting for you. I am an all powerful Wizard, and I appear to you with" +
                    " a proposition. And depending on your" +
                    " choice, you may find great fortune, or not. This quest is a game of choice and chance, as you stand at the tri-forked road. Now you must choose your path. Do so wisely.");


          

            }



            else
            {
                Console.WriteLine("That name is unrecognized. Come back and try again.");
                
            }


            

            if (answer == "Chosen One")
            {
                Console.WriteLine("YOU CAN CHOOSE FROM THESE THREE ROADS: FAIRWEATHER LANE, THE PERILOUS ROAD, AND THE " +
                    " PATH LESS TAKEN. FAIRWEATHER LANE IS THE MIDDLE LANE. IT IS WHERE EVERYTHING IS SUNSHINE AND RAINBOWS AND ALSO VERY EASY TO " +
                    " COMPLETE. BUT IS THE LEAST REWARDING OF THE THREE PATHS. THE PERILOUS ROAD IS EXACTLY HOW IT SOUNDS, IT IS THE HARDEST ROAD" +
                    " TO TRAVERSE, AND YOU HAVE A 50/50 CHANCE OF FINDING SOMETHING MOST REWARDING. BUT THE ENTIRE PATH COULD ALSO BE FOR NOTHING," +
                    " IT IS A FLIP OF A COIN, AND IT IS THE ROAD TO THE RIGHT. THEN THERE IS THE PATH LESS TAKEN, WHERE THERE IS LIKELY TO BE A MEDIUM TO HIGH QUALITY REWARD AT THE END." +
                    "BUT NOTHING IS GUARANTEED. NOT MUCH IS KNOWN ABOUT THIS PATH, BECAUSE OBVIOUSLY, IT IS LESS TAKEN. BUT A FEW PEOPLE DID COME BACK " +
                    "MORE FULFILLED...SAYING THAT THEY FOUND THEMSELVES. IT IS THE PATH TO YOUR LEFT. WHICH PATH WILL YOU CHOOSE? ");
            }
            
            string answer2 = Console.ReadLine();

            Console.ReadLine();
            Console.Clear();

            if (answer2 == "middle") 
            {
                Console.WriteLine("VERY WELL. YOU HAVE CHOSEN FAIRWEATHER LANE. WHERE YOUR ADVENTURE WILL BE SHORT AND UNFULFILLING.");

            }

            if (answer2 == "right")
            {
                Console.WriteLine("VERY WELL. YOU HAVE CHOSEN THE PERILOUS ROAD. THE HARD PATH WHERE" +
                    " IT IS POSSIBLE THE GREATEST REWARD LIES. MAY LUCK BE EVER IN YOU FAVOR.");

            }

            if (answer2 == "left")
            {
                Console.WriteLine("VERY WELL. YOU HAVE CHOSEN THE PATH LESS TAKEN. GOOD LUCK TO YOU.");

            }
            
            

            if (answer2 == "middle")
            {
                Console.WriteLine("You stroll down Fairweather Lane without nary a hiccup. While walking to the end" +
                    ", you had to step over some vines and rocks, but nothing you can't handle. At the end of the road lies a treasure chest. You hurry over" +
                    " and open it. You look inside to find a feather...only a feather. ");

            }

            if (answer2 == "left")
            {
                Console.WriteLine("You travel this mysterious path, with its twists and turns. The journey is long and you get" +
                    " a lot of time with yourself. One day passes. At the end of the road, there is a treasure chest. Inside, you see something shiny." +
                    " What is this? These are your hopes and dreams! You see yourself in the future, and its amazing. There's also 10,000 gold" +
                    " coins.  ");

            }

            if (answer2 == "right")
            {
                Console.WriteLine("You begin to doubt yourself as you walk the hard, unforgiving landscape. After weeks of walking, " +
                    "you finally come to what you've been looking for. There is the end! With the biggest treasure chest you've ever seen." +
                    " You open it slowly. Inside, you find some gold coins. 5000 coins to be exact. ");

            }

            else
            {
                Console.WriteLine("YOUR ROAD ENDS HERE, GOODBYE.");
            }
        }

    }
}
