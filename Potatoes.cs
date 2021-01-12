using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hot_Potato
{
    public class Potatoes
    {
        public int FindDiff(int binNumGuess, int randGenBinNum)
        {
            return Math.Abs(binNumGuess - randGenBinNum);
        }


        public int PotatoCloserOrFurther(int maxBin, int potatoBinCurrDiff, int potatoBinPrevDiff)
        {
            if (potatoBinPrevDiff > maxBin)
            {
                return 3;
            }
            else if (potatoBinCurrDiff > maxBin) {
                return 4;
            }
            else if (potatoBinCurrDiff < potatoBinPrevDiff)
            {
                return 1;
                //Return 1 if your guess is closer than last time
            }
            else if (potatoBinCurrDiff == potatoBinPrevDiff)
            {
                return 0;
                //return 0 if they entered the same bin again.
            }
            else if (potatoBinCurrDiff > potatoBinPrevDiff)
            {
                return 2;
                //Return 2 if their guess is further away than last time
            }
            else
            {
                return 5;
            }
        }
        public void PotatoProximityCheckMessage(int closerOrFurther)
        {
            if (closerOrFurther == 0)
            {
                Console.WriteLine("You entered the same bin number as last time.");
            }
            else if (closerOrFurther == 1)
            {
                Console.WriteLine("This bin is closer to your potato than your last guess.");
            }
            else if (closerOrFurther == 2)
            {
                Console.WriteLine("This bin is further away from your potato than your last guess.");
            }
            else if (closerOrFurther == 3)
            {
                Console.WriteLine("But...this is only your first guess, so you're doing great!");
            }
            else if (closerOrFurther == 4)
            {
                Console.WriteLine("There are no bins with that number. You have to try again.");
            }
        }

        public bool PotatoBinSearch ()
        {
            Random random = new Random();
            PotatoUI potatoUI = new PotatoUI();

            int maxPotatoBin = 100;
            int actualPotatoBin = random.Next(1, maxPotatoBin);


            //
            // For diagnostics
            //
            //Console.WriteLine("Actual Bin: {0}", actualPotatoBin);
            //Console.ReadLine();

            int potatoBinCurrDiff = 0;
            int potatoBinPrevDiff;
            int binNumGuess = 0;


            for (int guessCounter = 1; guessCounter <= 10; guessCounter++)
            {
                Console.Clear();
                Console.WriteLine("\nTime is ticking. You get 10 guesses before your");
                Console.WriteLine("potato gets cold and you won't be able to find it.\n");

                if ((guessCounter > 1) && (binNumGuess > 0))
                {
                    Console.WriteLine("*** Your last guess was {0}. ***", binNumGuess);
                }
                Console.WriteLine("*** This is guess number {0}. ***", guessCounter);
                Console.Write("\nWhat bin number are you going to check? ");

                string getBinNumberGuess = Console.ReadLine();

                if (int.TryParse(getBinNumberGuess, out _) == false)
                {
                    potatoUI.PotatoUIMessageAndPrompt("Your guess is out of range. Please try again.");
                    continue;
                } else {
                    binNumGuess = Int32.Parse(getBinNumberGuess);
                }

                if (guessCounter == 1)
                {
                    //
                    // set potatoBinPrevDiff to anything here as long as its outside of your total search range
                    //
                    potatoBinPrevDiff = 101;
                    potatoBinCurrDiff = FindDiff(binNumGuess, actualPotatoBin);
                } 
                else if ((guessCounter > 1) && (binNumGuess > maxPotatoBin)) 
                {
                    potatoUI.PotatoUIMessageAndPrompt("Your guess is out of range. Please try again.");
                    continue;
                }
                else
                {
                    potatoBinPrevDiff = potatoBinCurrDiff;
                    potatoBinCurrDiff = FindDiff(binNumGuess, actualPotatoBin);
                }

                //
                // For diagnostics
                //
                // Console.WriteLine("Actual Bin: {0}", actualPotatoBin);
                // Console.WriteLine("Prev Bin: {0}", potatoBinPrevDiff);
                // Console.WriteLine("Curr Bin: {0}", potatoBinCurrDiff);
                // Console.ReadLine();
                
                if (actualPotatoBin == binNumGuess)
                {
                    Console.Clear();
                    Console.WriteLine("\n********************************************************************************");
                    Console.WriteLine(" You found the bin that contains your potato. But they all look alike!");
                    Console.WriteLine("********************************************************************************");
                    potatoUI.PotatoUIMessageAndPrompt("Get into the bin and find your specific hot potato! Ugh!");
                    return true;
                }
                else if (potatoBinCurrDiff <= 3)
                {

                    Console.Clear();
                    Console.WriteLine("\nYour potato isn't here, but this bin is very very warm.");
                    Console.WriteLine("You can tell your hot potato probably skipped through this bin,");
                    Console.WriteLine("and into another bin that is close. (Within 3 bins)");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoBin,potatoBinCurrDiff, potatoBinPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                else if ((potatoBinCurrDiff >= 1) && (potatoBinCurrDiff <= 10))
                {
                    Console.Clear();
                    Console.WriteLine("\nYour potato isn't here, but this bin is luke warm.");
                    Console.WriteLine("Your potato probably flew close to this bin.");
                    Console.WriteLine("You could be up to 10 bins away from your potato's bin!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoBin,potatoBinCurrDiff, potatoBinPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                else if ((potatoBinCurrDiff >= 11) && (potatoBinCurrDiff <= 50))
                {
                    Console.Clear();
                    Console.WriteLine("\nThis bin is cold. You do however sense the presence of your potato. Its still warm.");
                    Console.WriteLine("You could be up to 50 bins away from your potato's bin!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoBin,potatoBinCurrDiff, potatoBinPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                else if ((potatoBinCurrDiff >= 51) && (potatoBinCurrDiff <= 100))
                {
                    Console.Clear();
                    Console.WriteLine("\nYou aren't even close to your potato. Its depressing and you're hungry. Your potato is getting colder.");
                    Console.WriteLine("You could be up to 100 bins away from your potato's bin!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoBin,potatoBinCurrDiff, potatoBinPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                else
                {
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoBin, potatoBinCurrDiff, potatoBinPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
            }
            return false;
        }

        public bool IndividualPotatoSearch()
        {
               Random random = new Random();
               PotatoUI potatoUI = new PotatoUI();

                int maxPotatoNum = 1000;
                int actualPotatoNum = random.Next(1, maxPotatoNum);

                //
                // For diagnostics
                //
                // Console.WriteLine("Actual Potato: {0}", actualPotatoNum);
                // Console.ReadLine();

                int potatoNumCurrDiff = 0;
                int potatoNumPrevDiff;
                int potatoNumGuess = 0;

             for (int guessCounter = 1; guessCounter <= 10; guessCounter++)

             {
                Console.Clear();
                Console.WriteLine("\nTime is ticking. You get 10 guesses before your");
                Console.WriteLine("potato gets cold and you won't be able to find it.\n");

                if ((guessCounter > 1) && (potatoNumGuess > 0))
                {
                    Console.WriteLine("*** Your last guess was {0}. ***", potatoNumGuess);
                }
                Console.WriteLine("*** This is guess number {0}. ***", guessCounter);
                Console.Write("\nWhat bin number are you going to check? ");

                string getPotatoNumGuess = Console.ReadLine();

                if (int.TryParse(getPotatoNumGuess, out _) == false)
                {
                    potatoUI.PotatoUIMessageAndPrompt("Your guess is out of range. Please try again.");
                    continue;
                }
                else
                {
                    potatoNumGuess = Int32.Parse(getPotatoNumGuess);
                }

                if (guessCounter == 1)
                {
                    //
                    // set potatoBinPrevDiff to anything here as long as its outside of your total search range
                    //
                    potatoNumPrevDiff = 1001;
                    potatoNumCurrDiff = FindDiff(potatoNumGuess, actualPotatoNum);
                } 
                else if ((guessCounter > 1) && (potatoNumGuess > maxPotatoNum)) 
                {
                    potatoUI.PotatoUIMessageAndPrompt(" Your guess is out of range. Please try again.");
                    continue;
                }
                else
                {
                    potatoNumPrevDiff = potatoNumCurrDiff;
                    potatoNumCurrDiff = FindDiff(potatoNumGuess, actualPotatoNum);
                }

                //
                // For diagnostics
                //
                // Console.WriteLine("Actual Bin: {0}", actualPotatoBin);
                // Console.WriteLine("Prev Bin: {0}", potatoBinPrevDiff);
                // Console.WriteLine("Curr Bin: {0}", potatoBinCurrDiff);
                // Console.ReadLine();
                
                if (actualPotatoNum == potatoNumGuess)
                {
                    Console.Clear();
                    Console.WriteLine("\n********************************************************************************");
                    Console.WriteLine(" Hooray! You and your potato are a \"mash\" made in heaven. Here it is! Enjoy!!");
                    potatoUI.HotPotato();
                    potatoUI.PotatoUIMessageAndPrompt("");
                    return true;
                }
                else if (potatoNumCurrDiff <= 3)
                {
                    Console.Clear();
                    Console.WriteLine("\nThis isn't your potato, but this potato has come into contact with YOUR potato.");
                    Console.WriteLine("Your potato is very EXTREMELY CLOSE! YOU CAN ALMOST TASTE IT! (Within 1 and 3 potatos)");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum, potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                else if (potatoNumCurrDiff <= 10)
                {

                    Console.Clear();
                    Console.WriteLine("\nThis isn't your potato, but this potato has come into contact with YOUR potato.");
                    Console.WriteLine("Your potato is very close! (Within 1 and 10)");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum,potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                else if ((potatoNumCurrDiff >= 11) && (potatoNumCurrDiff <= 50))
                {
                    Console.Clear();
                    Console.WriteLine("\nThis potato is warm, but it's not yours! You do however sense the presence of your potato.");
                    Console.WriteLine("You're getting much closer to your potato! You could be up to 50 potatos away from your potato!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum, potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                else if ((potatoNumCurrDiff >= 51) && (potatoNumCurrDiff <= 100))
                {
                    Console.Clear();
                    Console.WriteLine("\nThis potato is warm, but it's not yours! You do however sense the presence of your potato.");
                    Console.WriteLine("You're getting much closer to your potato! You could be up to 100 potatos away from your potato!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum,potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                else if ((potatoNumCurrDiff >= 101) && (potatoNumCurrDiff <= 200))
                {
                    Console.Clear();
                    Console.WriteLine("\nThis potato is luke-warm.");
                    Console.WriteLine("You could be up to 200 potatos away from your potato!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum,potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                     else if ((potatoNumCurrDiff >= 201) && (potatoNumCurrDiff <= 300))
                {
                    Console.Clear();
                    Console.WriteLine("\nYou aren't even close to your potato. Its depressing and you're hungry. Your potato is getting colder.");
                    Console.WriteLine("You could be up to 300 potatos away from your potato!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum,potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                     else if ((potatoNumCurrDiff >= 301) && (potatoNumCurrDiff <= 400))
                {
                    Console.Clear();
                    Console.WriteLine("\nYou aren't even close to your potato. Its depressing and you're hungry. Your potato is getting colder.");
                    Console.WriteLine("You could be up to 400 potatos away from your potato!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum,potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                     else if ((potatoNumCurrDiff >= 401) && (potatoNumCurrDiff <= 500))
                {
                    Console.Clear();
                    Console.WriteLine("\nYou aren't even close to your potato. Its depressing and you're hungry. Your potato is getting colder.");
                    Console.WriteLine("You could be up to 500 potatos away from your potato!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum,potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                     else if ((potatoNumCurrDiff >= 501) && (potatoNumCurrDiff <= 600))
                {
                    Console.Clear();
                    Console.WriteLine("\nYou aren't even close to your potato. Its depressing and you're hungry. Your potato is getting colder.");
                    Console.WriteLine("You could be up to 600 potatos away from your potato!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum,potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                     else if ((potatoNumCurrDiff >= 601) && (potatoNumCurrDiff <= 700))
                {
                    Console.Clear();
                    Console.WriteLine("\nYou aren't even close to your potato. Its depressing and you're hungry. Your potato is getting colder.");
                    Console.WriteLine("You could be up to 700 potatos away from your potato!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum,potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                     else if ((potatoNumCurrDiff >= 701) && (potatoNumCurrDiff <= 800))
                {
                    Console.Clear();
                    Console.WriteLine("\nYou're pretty far from your potato! Hurry! Your lunch break is almost over!.");
                    Console.WriteLine("You could be up to 800 potatos away from your potato!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum,potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                     else if ((potatoNumCurrDiff >= 801) && (potatoNumCurrDiff <= 900))
                {
                    Console.Clear();
                    Console.WriteLine("\nYou're pretty far from your potato! Hunger is setting in, dont give up now!");
                    Console.WriteLine("You could be up to 900 potatos away from your potato!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum,potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }
                     else if ((potatoNumCurrDiff >= 901) && (potatoNumCurrDiff <= 1000))
                {
                    Console.Clear();
                    Console.WriteLine("\nYou're the furthest you could be from your potato! You're in a dark place thinking about your potato.");
                    Console.WriteLine("You could be up to 1000 potatos away from your potato!");
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum,potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }

                else
                {
                    PotatoProximityCheckMessage(PotatoCloserOrFurther(maxPotatoNum, potatoNumCurrDiff, potatoNumPrevDiff));
                    potatoUI.PotatoUIMessageAndPrompt("");
                }

              
             }
             return false;
        }

    }
}
