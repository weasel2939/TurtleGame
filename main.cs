using System;
using System.Collections.Generic;
// The player is going to play as a baby turtle, whose wellbeing will be determined by the choices made by the player. There will be several endings and stories, essentially a life simulator.

// "Main" method is at bottom of page.

public static class Global
{
  // determine what levels play
  public static bool lose = false;
  public static bool win = false;
  public static int age = 0;
  // control ending sequences
  public static bool endLoop = false;
  public static string status = "null";
  public static string location = "null";
  // controls which route the player is on
  public static string route = "a";
  // trophy System
  public static List<string> trophy = new List<string>();
        // Gullible
        // Coward
        // Pacifist
        // Loyal
        // Cruel hearted  
        // Helpful

  // Fact System
  public static int factNum = 0;
  public static string[] factList =
  {"\n[F] Did you know, it is estimated that only one out of 1,000 hatchlings survives to be an adult.\t\n",
  "\n[F] Did you know, some sea turtles migrate very long distances while others stay close to home.\t\n",
  "\n[F] Did you know, sea turtles don’t have a favorite food (though most will eat jellyfish.)\t\n",
  "\n[F] Did you know, it is found that at least 8 million tons of plastic end up in our oceans every year.\t\n",
  "\n[F] as of 2020, estimates show us that there are nearly 6.5 million sea turtles left in the wild.\t\n",
  " "};
}

class MainClass {

  // Resets all global varaiables
  // Plays when the user restarts the game in end()
  static void Reset()
  {
    Global.lose = false;
    Global.win = false;
    Global.age = 0;
    Global.endLoop = false;
    Global. status = "null";
    Global.location = "null";
    Global.route = "x";
    Global.trophy.Clear();
    Global.factNum = 0;
  }

  // fact placer
  static void Fact()
  {
    int speed = 50;
    Console.ForegroundColor = ConsoleColor.Magenta;
    // prints the fact slower
    foreach (char c in Global.factList[Global.factNum])
    {
      Console.Write (c);
      System.Threading.Thread.Sleep(speed);
    }
    Console.WriteLine ();
    Global.factNum++;
  }   

      // slowest print
      public static void slowerPrint(string text, int speed = 58)
      {
        foreach (char c in text)
        {
          Console.Write (c);
          System.Threading.Thread.Sleep(speed);
        }
        Console.WriteLine ();
      }

      // slow print
      public static void slowPrint(string text, int speed = 45)
      {
        foreach (char c in text)
        {
          Console.Write (c);
          System.Threading.Thread.Sleep(speed);
        }
        Console.WriteLine ();
      }

      // medium print
      public static void fastPrint(string text, int speed = 30)
      {
        foreach (char c in text)
        {
          Console.Write (c);
          System.Threading.Thread.Sleep(speed);
        }
        Console.WriteLine ();
      }

      // speedy print
      public static void speedPrint(string text, int speed = 5)
      {
        foreach (char c in text)
        {
          Console.Write (c);
          System.Threading.Thread.Sleep(speed);
        }
        Console.WriteLine ();
      }

      // A template for expansion
      // The ammount of options is expandable
  // static void Level()
  // {
  //  try{
  //      Level information with an image
  //      A scenario, ask what user wants to do
  //      while (Global.age == {age} & Global.lose == false)
  //      {
  //        Console.ForegroundColor = ConsoleColor.Blue;
  //        slowPrint("A. {?}.\nB. {?}.\nC. {?}.");
  //        Console.ForegroundColor = ConsoleColor.Yellow;
  //        slowPrint("A, B, or C");
  //        string ans = Console.ReadLine();
  //        ans = ans.ToLower();
  //            
  //        if (ans == "{a}")       a "good" option
  //        {
  //          Console.ForegroundColor = ConsoleColor.Gray;
  //          slowerPrint("\n+ - - - - - +");
  //          Console.ForegroundColor = ConsoleColor.Yellow;
  //          slowPrint("\n What the player does");
  //          Console.ForegroundColor = ConsoleColor.Gray;
  //          slowerPrint("\n+ - - - - - +");
  //          Global.age = {?};
  //        }
  //
  //        else if (ans == "{b}")      causes death
  //        {
  //          Console.ForegroundColor = ConsoleColor.Green;
  //          slowPrint("\n What the player does    ");
  //          Console.ForegroundColor = ConsoleColor.DarkYellow;
  //          slowPrint("Result    ");
  //          Global.trophy.Add("Optional");
  //          Global.location = "location";
  //          Global.status = "status";
  //          Global.lose = true;
  //        }
  //        
  //        else if (ans == "{c}")      causes death
  //        {
  //          ~~~~~~~
  //        }
  //
  //        else      invalid input
  //        {
  //          Console.ForegroundColor = ConsoleColor.DarkYellow;
  //          fastPrint("\nInvalid Answer\n");
  //        }
  //    }
  //  }
  //  catch (Exception e){
  //  Console.ForegroundColor = ConsoleColor.Red;
  //  Console.Write (e.Message);
  //  }
  //}

  // always plays first - Birth Sequence
  static void Birth()
  {
    try{
      // starting scenario
      Console.ForegroundColor = ConsoleColor.Gray;
      slowerPrint("\n+ - - - - - +   ");
      Console.ForegroundColor = ConsoleColor.Green;
      slowPrint("\nYou emerge from the sand, and the rays of the hot sun touch your shell for the first time.");
      Console.ForegroundColor = ConsoleColor.Gray;
      speedPrint(@"                        .:~~--__                __--~~:.
                      ,:;'~'-,__~~--..,---..--~~__,-`~`::.
                    ,:;'        ''-,_ (. .)_,-``        `::.
                  ,;'                \ `\)/                `:.
                 '                    `--'                    `
   __._                       _.._                 _._
-~~    ~~--..__.._-~~~--..--~~    ~~--.__.---...-'~   ~~---...-.         ");
      Console.ForegroundColor = ConsoleColor.Green;
      slowPrint("\nA loud and high pitched noise echos as a strange creature flies towards you.\nWhat do you do?");
      // User input, determines survival of the turtle.
      while (Global.age == 0 & Global.lose == false)
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        slowPrint("A. Hide in terror.\nB. Make a new friend!\nC. Head for the ocean.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        fastPrint("A, B, or C");
        // ensures user can answer upper or lower case answer.
        string ans = ("filler");
        ans = Console.ReadLine();
        ans = ans.ToLower();
        // All death outcomes are the same, so these are set outside the if statements
        Global.location = "Beach";
        Global.status = "Lunch";
        // All except "c" result in death.
        if (ans == "c")
        {
          Console.ForegroundColor = ConsoleColor.Green;;
          slowPrint("\nYou rush to the ocean, finally reaching the cool solitude and safety that will be your home for the majority of your life.");
          Console.ForegroundColor = ConsoleColor.Gray;
          slowerPrint("\n+ - - - - - +");
          Global.age = 10;
        }
        //
        else if (ans == "a")
        {
          Console.ForegroundColor = ConsoleColor.Green;
          slowPrint("\nYou return to the sand, scurrying downward in the search of safety.    ");
          Console.ForegroundColor = ConsoleColor.DarkYellow;
          slowPrint("The beast caught and ate you.     ");
          Global.trophy.Add("Coward");
          Death();
          Global.lose = true;
        }
        //
        else if (ans == "b")
        {
          Console.ForegroundColor = ConsoleColor.Green;
          slowPrint("\nYou greet the new creature, welcoming them into your loving and innocent heart.");
          Console.ForegroundColor = ConsoleColor.DarkYellow;
          slowerPrint("Your kindness was not returned.");
          Global.trophy.Add("Pacifist");
          Global.lose = true;
        }
        //
        else
        {
          Console.ForegroundColor = ConsoleColor.DarkYellow;
          fastPrint("\nInvalid Answer\n");
        }
      }
    }
    catch (Exception e){
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write (e.Message);
    }
  }

  //Turtles take roughly ten years to mature - Only runs if user input was c
  static void Ten()
  {
    try{
      Console.ForegroundColor = ConsoleColor.Gray;
      slowerPrint("+ - - - - - +   ");
      // scenario 2
      Console.ForegroundColor = ConsoleColor.Green;
      slowPrint("\n\nAfter roughly 10 years of shore-bound life, it is time for you to finally leave your home.\nAs the urge to leave the shore builds up inside you, you think of where you want to go.");
      // User input, determines survival of the turtle.
      while (Global.age == 10 & Global.lose == false)
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        slowPrint("A. Explore the nearby sea, spending your time near reefs and bays.\nB. Explore the ocean depths.\nC. Migrate with nearby turtles.\nD. Join a colony near a seaweed forest. ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        fastPrint("A, B, C, or D");
        string ans = ("filler");
        ans = Console.ReadLine();
        ans = ans.ToLower();
        // B and D are correct, different scenarios
        // Ocean depths  B
        if (ans == "b")
        {
          Console.ForegroundColor = ConsoleColor.Green;;
          slowPrint("\nYou decide to travel alone in search for food, living the life of a nomad.");
          Console.ForegroundColor = ConsoleColor.Gray;
          slowerPrint("\n+ - - - - - +   ");
          Global.age = 11;
          Global.route = "a";
        }
        // Seaweed  D
        else if (ans == "d")
        {
          Console.ForegroundColor = ConsoleColor.Green;
          slowPrint("\nYou decide to lay low in some kelp forests, living a peaceful life with plenty of food and space.");
          Console.ForegroundColor = ConsoleColor.Gray;
          slowerPrint("\n+ - - - - - +   ");
          Global.age = 11;
          Global.route = "b";
        }

        // Reefs A
        else if (ans == "a")
        {
          Console.ForegroundColor = ConsoleColor.Green;
          slowPrint("\nYou decide to remain around the nearby reefs and bays, feeding off of as much food as you can find.");
          Console.ForegroundColor = ConsoleColor.White;
          speedPrint(@"

                ,   
                }\    
      )    \  .'  `\  
     (     }}<   ( 6>   )
    ) )    /  `,  .'   (   (
   ( (          }/      )   )
    ) )         '      (   (
   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
          Console.ForegroundColor = ConsoleColor.Green;
          slowPrint("Hungry and alert, as always, you see a small fish staying relatively still nearby. You approach slowly and quickly force it into your mouth, only to be yanked up by a mysterious force.");
          Console.ForegroundColor = ConsoleColor.DarkYellow;
          slowPrint("You were caught by mistake, and left for dead");
          Global.location = "Off-catch disposal";
          Global.status = "Poached";
          Global.trophy.Add ("Gullible");
          Console.ForegroundColor = ConsoleColor.DarkYellow;
          Global.lose = true;
        }
        
        // Oil  C
        else if (ans == "c")
        {
          Console.ForegroundColor = ConsoleColor.Green;
          slowPrint("\nYou decide to travel with a nearby group of fellow sea-turtles, with the hope of food and safety inspiring your journey.");
          // Options A and B for staying with colony or leaving, B loops to previous option B results.
          Console.ForegroundColor = ConsoleColor.Gray;
          slowerPrint("\n+ - - - - - +   ");
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Gray;
          slowerPrint("+ - - - - - +   ");
          Console.ForegroundColor = ConsoleColor.Green;
          slowPrint("\nAs you and your new bale travel in search for food near the ocean floor, a large cloud of strange black substance begins to leak out of a large object. Through the chaos, you notice some of your bale struggling to escape the cloud.\nWhat do you do?");
          while (Global.age == 10 & Global.lose == false)
          {
            Console.ForegroundColor = ConsoleColor.Blue;
            slowPrint("A. Stay with your bale to try help.\nB. Escape to explore the ocean alone.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            slowPrint("A or B");
            string oilAns = "x";
            oilAns = Console.ReadLine();
            oilAns = oilAns.ToLower();
            if (oilAns == "a")
            {
              Console.ForegroundColor = ConsoleColor.Green;
              slowPrint("\nYou stay with your bale, but unfortunately all suffer the same gruesome fate.");
              Console.ForegroundColor = ConsoleColor.DarkYellow;
              Global.location = "Oil spill";
              Global.status = "Oily";
              Global.trophy.Add ("Loyal");
              Console.ForegroundColor = ConsoleColor.DarkYellow;
              Global.lose = true;
            }
            else if (oilAns == "b")
            {
              Console.ForegroundColor = ConsoleColor.Green;
              slowPrint("\nYou escape, leaving your bale behind.");
              Global.trophy.Add ("Coward");
              Console.ForegroundColor = ConsoleColor.Gray;
              slowerPrint("\n+ - - - - - +   ");
              // will now proceed as if ans was b instead of c
              Global.age = 11;
              Global.route = "a";
            }
          }
        }

        // N/A Input
        else   
        {
          Console.ForegroundColor = ConsoleColor.DarkYellow;
          fastPrint("\nInvalid Answer\n");
        }
      }
    }
    catch (Exception e){
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write (e.Message);    }
  }
  // age 11 route a
  static void Ocean()
  {
    try{
      // B. Explore the ocean depths.
        Console.ForegroundColor = ConsoleColor.Gray;
        slowerPrint("\n+ - - - - - +   ");
        Console.ForegroundColor = ConsoleColor.White;
        speedPrint(@"        __.._
____...-`  \ /``'-..
`~-..`(.-~~~|    /  `-.
    : :   ,``. .<____/ `:_
    ` `..`   .` /   / \ /:`-.
     `. `. ,`  /    \_.'.`.,,:
      |`._`-.__\_.-``.-'  `._
      `.,,`-`....-.`~`.'`. c `.
                   `-. `,`. ._ )
                      ```  `--`");
        Console.ForegroundColor = ConsoleColor.Green;
        // Scenario 3a
        slowPrint("\nExploring the ocean for roughly 1 year, surviving on anything you could get your mouth on, you find another of your kind drifting in some sort of encasing web.\nCurious, you approach to find her struggling to move, what do you do?");
        Console.ForegroundColor = ConsoleColor.White;
        speedPrint(@"");
        while (Global.age == 11 & Global.lose == false)
        {
          Console.ForegroundColor = ConsoleColor.Blue;
          slowPrint("A. Laugh at her.\nB. Try to pull the net off of her.\nC. Carefully swim her to a shore, where you can better help her.");
          Console.ForegroundColor = ConsoleColor.Yellow;
          slowPrint("A, B, or C");
          // ensures user can answer upper or lower case answer.
          string ans = ("filler");
          ans = Console.ReadLine();
          ans = ans.ToLower();
          if (ans == "a")
          {
            Console.ForegroundColor = ConsoleColor.Green;
            slowPrint("\nFilled with joy, you laugh at the struggling fool, and with your over reaching joy you become distracted.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            slowPrint("A tiger shark caught and ate you.");
            Global.trophy.Add("Cruel hearted");
            Death();
            Global.lose = true;
          }

          //
          else if (ans == "b")
          {
            Console.ForegroundColor = ConsoleColor.Green;
            slowPrint("\nAttempting to help, you try your best to cut the strange net.    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            slowPrint("You became trapped yourself, and sank to the bottom of the ocean with your new friend.     ");
            Global.trophy.Add("Helpful");
            Death();
            Global.lose = true;
          }

          //
          else if (ans == "c")
          {
            Console.ForegroundColor = ConsoleColor.Green;
            slowPrint("\nYou asist your new acquaintance, taking her to a more secure place to help remove the net.");
            Console.ForegroundColor = ConsoleColor.Gray;
            slowerPrint("\n+ - - - - - +   ");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            slowPrint("\nAfter freeing your new found friend from the net, you decide to stick together for safety.");
            Global.location = "Beach";
            Global.status = "Alive";
            Global.age = 12;
            Global.win = true;
          } 

          //  N/A Input
          else
          {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            fastPrint("\nInvalid Answer\n");
          }
        }
    }
    catch (Exception e){
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write (e.Message);    } 
  }

  // age 11 route b
  static void Seaweed()
  {
    try{
        // D. Join a colony near a seaweed forest
        Console.ForegroundColor = ConsoleColor.Gray;
        slowerPrint("\n+ - - - - - +   ");
        Console.ForegroundColor = ConsoleColor.White;
        speedPrint(@"             .                                 .                   .
             :                :                :        :           :
         .   `.      '.       :  :             :    .    '.     O    :
   .'   .'  .  :  :   : .'   .'  :        o   .'   .O   .  :         '.
  .'   .'  .'O : .'   '.'   .'  .'  .       .'    .'  .' .'      .'   :
 .'   .'  .'  .' :    .'   .'O .'  ..   o  ./    .'  .' .'  .  O.'   .'
 :    :   . O.'  '.   ::   :   .' ..    ,,//;  ,/:O .' .'  :    :    :
 :   .'   :  :    :   '::  'O  :  :    o:333:://.'  :  :   '. O  :,/.'
.'   :    :O '.  .'  '. ::'    :  '.  >:33333:\\:  :   '.   :  ,,//;  ,/
:   . '.  '.  '. :    :  :: O  '.  ''   ''\\\' \'O '.   :  :  o:333:://
:   '. :    :  '.'.   .' ::     ,   :  :    \  :    ::  :  : >:33333:\\
 .   : :  O ::  :  : .'  :O   .:/   :  '.   :  O    ::   :  '. ''\\\':\
 :    ::     ::.' .' :  :: ,,///;,  ,/  :   '.:   .:/    '.  :  '. \  :
 `.  :'.O     ,:  :  :  :'o:33333::// . :    ::,,///;   ,/'. :   :  .:'
  ::.' ::   .:/: :'  '. :>:3333333:\\ ::     :o:33333:://  ::'   :. :' .'
   ::   :,,///;, :,/  : :: ''\\\\\' '\ :     >:3333333:\\  ::    ::'  .'
   ::   o:33333:://   '.::  : ';\  .  :'     ::''\\\\\' '\.:'    ::  .:
   ':..>:3333333:\\     ':.:'  '.,.:'' :     ':.. ';\ ,:' ':     '::.:'
    :::  ''\\\\\' '\     :::    .'',  ::      :::    .::.  ::      :::'
    :::  .: ';\ :'        :::  .:' . .:'       :::  .:' :.::'       :::
    ::: :::  ::::         ::: :::  ::::        ::: :::  ::::        ::::
OOo0O0oo0Oo0OOo0O0oo0Oo0OOo0O0oo0Oo0OOo0O0oo0Oo0OOo0O0oo0Oo0OOo0O0oo0Oo0OOo0");
        Console.ForegroundColor = ConsoleColor.Green;
        // Scenario 3b
        slowPrint("\nYour new home is bursting with life; Kelp and small fish are spread throughout the whole region.\nWith such a wide range of available options, what food do you prefer the most?");
        // User input
        while (Global.age == 11 & Global.lose == false)
        {
          bool foodChosen = false;
          while (foodChosen == false)
          {
            Console.ForegroundColor = ConsoleColor.Blue;
            slowPrint("A. Seaweed and Vegetation.\nB. Shellfish (crab).\nC. Invertebrates (Jelly fish, Sea Squirts).");
            Console.ForegroundColor = ConsoleColor.Yellow;
            slowPrint("A, B, or C");
            // ensures user can answer upper or lower case answer.
            string ans = ("filler");
            ans = Console.ReadLine();
            ans = ans.ToLower();
            // Kelp
            if (ans == "a")
            {
              Console.ForegroundColor = ConsoleColor.Gray;
              slowerPrint("\n+ - - - - - +   ");
              Console.ForegroundColor = ConsoleColor.Yellow;
              slowerPrint("\nSalad it is!\nSeaweed, Seagrass, and algae can be very nutricious for adult Turtles, and is often favoured by the Green Turtle.\t\t");
              foodChosen = true;
            }

            // Shellfish
            else if (ans == "b")
            {
              Console.ForegroundColor = ConsoleColor.Gray;
              slowerPrint("\n+ - - - - - +   "); 
              Console.ForegroundColor = ConsoleColor.Yellow;
              slowerPrint("\nShellfish it is!\nOften being preferred by the Loggerhead Turtle, a Shellfish diet requires a strong jaw and lots of determination.\t\t");
              foodChosen = true;
            }

            // Jelly fish
            else if (ans == "c")
            {
              Console.ForegroundColor = ConsoleColor.Gray;
              slowerPrint("\n+ - - - - - +   ");
              Console.ForegroundColor = ConsoleColor.Green;
              slowerPrint("\nSometimes being referred to as gelatinivores, the Leatherback Turtle's favourite food comes in the form of Jellyfish and other soft-bodied invertebrates.\nThat's you I guess!\t\t");
              foodChosen = true;
            } 

            else
            {
              Console.ForegroundColor = ConsoleColor.DarkYellow;
              fastPrint("\nInvalid Answer\n");
            }
            slowerPrint("\n+ - - - - - +   ");
          }
          // food has been chosen, stuff happens now
          while (Global.age == 11 & Global.lose == false)
          {
            Console.Clear();
            Fact(); 
            Console.ForegroundColor = ConsoleColor.Gray;
            slowerPrint("\n+ - - - - - +");
            Console.ForegroundColor = ConsoleColor.Green;
            slowPrint("A year into blah");
            Console.ForegroundColor = ConsoleColor.White;
            speedPrint(@"");
            while (Global.age == 11 & Global.lose == false)
            {
              Console.ForegroundColor = ConsoleColor.Blue;
              slowPrint("A. x.\nB. x.\nC. x.");
              Console.ForegroundColor = ConsoleColor.Yellow;
              slowPrint("A, B, or C");
              // ensures user can answer upper or lower case answer.
              string ans = ("filler");
              ans = Console.ReadLine();
              ans = ans.ToLower();
              //
              if (ans == "a")
              {
                
                
              }

              else if (ans == "b")
              {

              }

              else if (ans == "c")
              {

              }

              else
              {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                fastPrint("\nInvalid Answer\n");
              }
            }
          }
        }
    }
    catch (Exception e){
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write (e.Message);    } 
  }

  // plays when user dies
  static void Death()
    {
      Console.ForegroundColor = ConsoleColor.Gray;
      slowerPrint("\n");
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      // end stats (status, location, age)
      var endStat = ("\n[x] Status: " + Global.status + "\n[x] Location: " + Global.location + "\n[x] Age: " + Global.age);
      string statString = endStat.ToString();
      int statSpeed = 65;
      // this makes it write at the same speed as the trophies
      foreach (char c in statString)
      {
        Console.Write (c);
        System.Threading.Thread.Sleep(statSpeed);
      }
      slowerPrint("\n\n[x] Trophies Collected:");
      // prints out the trophy list
      if (Global.trophy.Count > 0)
      {
        for (int i = 0; i < Global.trophy.Count; i++)
        {
          Console.Write ("\t{0}: ", i+1);
          int speed = 65;
          foreach (char c in Global.trophy[i])
          {
            Console.Write ("{0}", c);
            System.Threading.Thread.Sleep(speed);
          }
          Console.Write (".\n");
        }
      }
      else
      {
        slowerPrint("\t [x] No trophies found");
      }
      Console.ForegroundColor = ConsoleColor.Gray;
      slowerPrint("\n+ - - - - - +           ");
    } 

  // end sequence
  static void end (string temp)
  {   
      // If an invalid input is endered the code will loop.
      temp = Console.ReadLine();
      temp = temp.ToLower();
      if (temp == "y")
      { // continues while loop
        Console.ForegroundColor = ConsoleColor.Cyan;
        slowerPrint("\nRestarting game...\n");
        Global.endLoop = true;
        Global.lose = false;
        Main();
      } 

      if (temp == "n")
      { // ends while loop
        Console.ForegroundColor = ConsoleColor.Green;
        slowPrint("\n\n\n\nThank you for playing the Turtle Life Simulator!\nWant more information on turtles and their wellbeing? Go to the Enviro Club!");
        Global.endLoop = true;
      }
    }

    // main class
  static void Main () 
  {
  try{
    // Will run until Death
    while (Global.lose == false & Global.win == false)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      fastPrint("\t\t-= Turtle Life Simulator =-\n");
      Console.ForegroundColor = ConsoleColor.Gray;
      speedPrint(@"               _,.---.---.---.--.._ 
           _.-' `--.`---.`---'-. _,`--.._
          /`--._ .'.     `.     `,`-.`-._\
         ||   \  `.`---.__`__..-`. ,'`-._/
    _  ,`\ `-._\   \    `.    `_.-`-._,``-.
 ,`   `-_ \/ `-.`--.\    _\_.-'\__.-`-.`-._`.
(_.o> ,--. `._/'--.-`,--`  \_.-'       \`-._ \
 `---'    `._ `---._/__,----`           `-. `-\
           /_, ,  _..-'                    `-._\
           \_, \/ ._(
            \_, \/ ._\
             `._,\/ ._\
               `._// ./`-._
                 `-._-_-_.-'");
      Console.ForegroundColor = ConsoleColor.Blue;
      fastPrint("\n\t\tPress anything to start:");
      Console.ReadKey();
      Reset();

      // age 0  
      while (Global.age == 0 & Global.lose == false)
      {
        Console.Clear();
        slowerPrint("The year is 1990.");
        Birth();
      }
      // takes 10 years to mature
      // age 10
      while (Global.age == 10 & Global.lose == false)
      {
        Console.Clear();
        Fact(); // F0
        Ten();
      }
      // age 11
      while (Global.age == 11 & Global.lose == false)
      {
        if (Global.route == "a")
        {
          Console.Clear();
          Fact(); // F1
          Ocean();
        }
        else if (Global.route == "b")
        {
          Console.Clear();
          Fact(); // F1
          Seaweed();
        }
      }
    }

    // win
    if (Global.win == true)
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Yellow;
      slowerPrint("            \n\t\t\t  -= Congratulations! =-\n\t* You have won Turtle Life Simulator 1! *");
      Console.ForegroundColor = ConsoleColor.Gray;
      slowPrint("\t\t -=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-");
      Death();
      Console.ForegroundColor = ConsoleColor.Yellow;
      slowerPrint("\nDo you want to go again? \ny / n        ");
      string retry = "x";
      while (Global.endLoop == false)
        {
          end(retry);
        }
    }

    // loss 
    if (Global.lose == true)
    {
      Death();
      Console.ForegroundColor = ConsoleColor.Yellow;
      slowerPrint("\nDo you want to go again? \ny / n");
      string retry = "x";
      while (Global.endLoop == false)
        {
          end(retry);
        }
    }
  }
  catch (Exception e)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write (e.Message);  }
  }
    
  }
                         