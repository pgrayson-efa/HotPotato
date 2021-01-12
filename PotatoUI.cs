using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hot_Potato
{
    public class PotatoUI
    {
        public void PotatoUIMessageAndPrompt(string message)
        {
            if (message != "")
            {
                Console.WriteLine("\n{0}", message);
            }
            Console.WriteLine("\n [Return To Continue]\n");
            Console.ReadLine();
        }

        public void HotPotato()
        {


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("                                                                                ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                      \\\\     //    \\\\   //   \\\\   //     //   \\\\        ");
            Console.WriteLine("                      //     \\\\    //   \\\\   //   \\\\     \\\\   //        ");
            Console.WriteLine("                      \\\\     //    \\\\   //   \\\\   //     //   \\\\        ");
            Console.WriteLine("                      //     \\\\    //   \\\\   //   \\\\     \\\\   //        ");
            Console.WriteLine("                                                  //     //   \\\\              ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("                      ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("/*/,*,*,(**///***,**,**");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("               ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("/**(*/#,,/(,,.*,,*,,(****.,.,*,,/*//,*");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("             ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("* ((**/,, *#**#*,*,.....//**,*,.*,,*(,.*,****,,*,**");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("*#**/*(((***#/##*/,,,**/#**./**/,/,*,/,,,*.***,.,,,**/,");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("//**//////*/*//*,****/(,/*/,*((,/*(,,/*.**,**/,./,,,***/*");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("             ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" *//#//*//**/////(((*(**,,/**/*((#///(#(,*//,,,**,,,,/*(*/");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("             ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("/ (**//****/*/****#///*//*/#*/((/(((#((*(//,*#************ ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("               ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("***(*, **/***/**/ (%/*/*,*(%(%(///*/***/******,****,,** ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                 ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("*****,,**//*//*&(((##(#%,*///*/**/*,/*////*****,**,");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                    ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("..///((##((*/(&(#(****#****/**//**(//*,,#,,/,,");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                       ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("..,, ***/#&%%&#(///**///(/*(/(///////** ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                             ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("....,,,, ***/#%%/****,,,...");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                                ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
        }

        public void PotatoUIMenuItemActiveOrInactive (bool isActive, string prompt)
        {
            if (isActive == true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("  <<ACTIVE>>  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("  *  ");
                Console.WriteLine("{0}", prompt);
            }
            if (isActive == false)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("<<NOT ACTIVE>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("  *  ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("{0}", prompt);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                         HHH   HHH  OOOOOOO  TTTTTTTTT");
            Console.WriteLine("                         HHH   HHH OOOOOOOOO TTTTTTTTT");
            Console.WriteLine("                         HHH   HHH OOO   OOO    TTT   ");
            Console.WriteLine("                         HHHHHHHHH OOO   OOO    TTT   ");
            Console.WriteLine("                         HHHHHHHHH OOO   OOO    TTT   ");
            Console.WriteLine("                         HHH   HHH OOO   OOO    TTT   ");
            Console.WriteLine("                         HHH   HHH OOOOOOOOO    TTT   ");
            Console.WriteLine("                         HHH   HHH  OOOOOOO     TTT   ");
            Console.WriteLine("");
            Console.WriteLine("PPPPPPPPP  OOOOOOO  TTTTTTTTT    AAA    TTTTTTTTT    AAA    TTTTTTTTT  OOOOOOO ");
            Console.WriteLine("PPPPPPPPP OOOOOOOOO TTTTTTTTT   AAAAA   TTTTTTTTT   AAAAA   TTTTTTTTT OOOOOOOOO");
            Console.WriteLine("PPP   PPP OOO   OOO    TTT     AA   AA     TTT     AA   AA     TTT    OOO   OOO");
            Console.WriteLine("PPP   PPP OOO   OOO    TTT    AAA   AAA    TTT    AAA   AAA    TTT    OOO   OOO");
            Console.WriteLine("PPPPPPPPP OOO   OOO    TTT    AAAAAAAAA    TTT    AAAAAAAAA    TTT    OOO   OOO");
            Console.WriteLine("PPPPPPPPP OOO   OOO    TTT    AAAAAAAAA    TTT    AAAAAAAAA    TTT    OOO   OOO");
            Console.WriteLine("PPP       OOOOOOOOO    TTT    AAA   AAA    TTT    AAA   AAA    TTT    OOOOOOOOO");
            Console.WriteLine("PPP        OOOOOOO     TTT    AAA   AAA    TTT    AAA   AAA    TTT     OOOOOOO ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************************************************************************");
            HotPotato();
            PotatoUIMessageAndPrompt("");


            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine(" Welcome to Hot Potato. You are a potato processor in a Russet potato plant.");
            Console.WriteLine(" At lunch time you decided to enjoy one of the benefits of your job which is");
            Console.WriteLine(" selecting your very own potato to enjoy. You of course choose the biggest");
            Console.WriteLine(" potato you could find.\n");

            Console.WriteLine(" While microwaving your lunch potato in the lunchroom overlooking the potato");
            Console.WriteLine(" processing floor, the microwave explodes, launching your hot potato through the");
            Console.WriteLine(" window and back out onto the processing center floor somewhere.\n");

            Console.WriteLine(" There are 100 bins, and 1000 potatoes per bin out on the processing");
            Console.WriteLine(" main floor. You're hungry and you want that potato. You have to find the bin");
            Console.WriteLine(" that contains your potato, and then dig through that bin to find your specific");
            Console.WriteLine(" potato or you are likely to starve. You only have time for 10 guesses");
            Console.WriteLine(" on your bin, and 10 guesses to find your specific potato number in the bin");
            Console.WriteLine(" before your potato gets cold.\n");
            Console.WriteLine("");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            PotatoUIMessageAndPrompt("");

            //
            // Declare and/or set some useful things starting here
            //
            Potatoes potato = new Potatoes();

            bool menuActive = true;
            string potatoMenu = "";
            bool potatoBinSearchMenuActive = true;
            bool potatoIndividualSearchMenuActive = false;
            bool potatoReset = false;
                    

            //
            // Change colors of active selections on menu depending on other logic down below
            //
            while (menuActive == true)
            {
                Console.Clear();
                Console.WriteLine("**********************************************************");
                Console.WriteLine("                    POTATO SEARCH MENU");
                Console.WriteLine("**********************************************************");

                if ((potatoBinSearchMenuActive == false) && (potatoIndividualSearchMenuActive == false))
                {
                    potatoReset = true;
                } else
                {
                    potatoReset = false;
                }
                if (potatoBinSearchMenuActive == true)
                {
                    PotatoUIMenuItemActiveOrInactive(true, "1. Find The Bin Containing Your Potato");
                } 

                if (potatoBinSearchMenuActive == false)
                {
                    PotatoUIMenuItemActiveOrInactive(false, "1. Find The Bin Containing Your Potato");
                }

                if (potatoIndividualSearchMenuActive == true)
                {
                    PotatoUIMenuItemActiveOrInactive(true, "2. Search The Bin For Your Potato");
                }

                if (potatoIndividualSearchMenuActive == false)
                {
                    PotatoUIMenuItemActiveOrInactive(false, "2. Search The Bin For Your Potato");
                }

                if (potatoReset == true)
                {
                    PotatoUIMenuItemActiveOrInactive(true, "3. Microwave New Potato");
                }
                if (potatoReset == false)
                {
                    PotatoUIMenuItemActiveOrInactive(false, "3. Microwave New Potato");
                }
                PotatoUIMenuItemActiveOrInactive(true, "4. Exit");

                Console.WriteLine("**********************************************************\n");
                Console.Write(" Enter Selection (1-4) : ");

                potatoMenu=Console.ReadLine();

                //
                // Cycle menu availability to change UI concole colors setup above
                //
                switch (potatoMenu)
                {
                    case "1":
                        if (potatoBinSearchMenuActive == false)
                        {
                            PotatoUIMessageAndPrompt(" This menu option is <<NOT ACTIVE>>. Perhaps you could try one that is <<ACTIVE>>");
                            break;
                        }
                        
                        if (potatoBinSearchMenuActive == true)
                        {
                            potatoBinSearchMenuActive = potato.PotatoBinSearch();
                            if (potatoBinSearchMenuActive == true)
                            {
                                potatoBinSearchMenuActive = false;
                                potatoIndividualSearchMenuActive = true;
                            }
                        }
                        break;
                    case "2":
                        if (potatoIndividualSearchMenuActive == false)
                        {
                            PotatoUIMessageAndPrompt(" This menu option is <<NOT ACTIVE>>. Perhaps you could try one that is <<ACTIVE>>");
                            break;
                        }

                        if (potatoIndividualSearchMenuActive == true)
                        {
                            potatoIndividualSearchMenuActive = potato.IndividualPotatoSearch();
                            if (potatoIndividualSearchMenuActive == true)
                            {
                                potatoBinSearchMenuActive = false;
                                potatoIndividualSearchMenuActive = false;
                                potatoReset = true;
                            }
                            break;
                        }
                        break;

                    case "3":
                        if (potatoReset == true)
                        {
                            Console.Clear();
                            potatoBinSearchMenuActive = true;
                            potatoIndividualSearchMenuActive = false;
                            potatoReset = false;
                            PotatoUIMessageAndPrompt(" Your new potato has exploded out onto the potato processing floor! Good luck!");
                            continue;
                        }
                        else
                        {
                            PotatoUIMessageAndPrompt(" This menu option is <<NOT ACTIVE>>. Perhaps you could try one that is <<ACTIVE>>");
                            potatoReset = false;
                            continue;
                        }

                    case "4":
                        menuActive = false;
                        break;
                    default:
                        PotatoUIMessageAndPrompt(" Please select a valid option for the good of your potato.");
                        break;
                }
            }
        }
        public void Run()
        {
            Menu();
        }
    }
}
