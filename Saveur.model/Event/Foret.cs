using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.Event
{
    public class Foret
    {
        public string AventureForet(string objetrouver, int Dice, int chance)
        {

            int rollthedice(int chance)
            {
                Random ren = new Random();

                int mort = ren.Next(1, 100);
                mort = mort + chance;
                return mort;
            }

            if (Dice >= 1 & Dice <= 50)
            {

                Console.WriteLine(@"

                                  {}     Bon bien...
                                 .--.
                                /.--.\
                                |====|
                                |`::`|
                            .-;`\..../`;-.
                           /  |...::...|  \
                          |   /'''::'''\   |
                          ;--'\   ::   /\--;
                          <__>,>._::_.<,<__>
                          |  |/   ^^   \|  |
                          \::/|        |\::/
                          |||\|        |/|||
                          ''' |___/\___| '''
                               \_ || _/
                               <_ >< _>
                               |  ||  |
                               |  ||  |
                              _\.:||:./_
                             /____/\____\");


                Console.WriteLine("vous trouver RIEN ! ");
                objetrouver = "rien";
                Console.ReadLine();

            }
            else if (Dice >= 51 & Dice <= 80)
            {
                Console.WriteLine(@"

                                                     /
                   tu veux te bater ?         ,~~   /
                                          _  <=)  _/_
                        o                /I\.=""==.{>
                       (Y==o---          \I/-\T/-'
                       /_\                   /_\
                       / >                  // \\_
                                           _I    /     
           8-------------------------------------------------------------8
");

                Console.WriteLine("vous trouver un brigand ! ");
                Console.WriteLine("Lancer un dé pour savoir si vous le tuer ");
                Console.ReadLine();
                int estmort = rollthedice(chance);
                if (estmort >= 40)
                {
                    Console.WriteLine("Bravo vous avez gagner de l'or !");
                    objetrouver = "Or";
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("oh Non il est partie et en plus il a pris votre dignité ! ");
                    objetrouver = "rien";
                    Console.ReadLine();
                }
            }
            else if (Dice >= 81 & Dice <= 95)
            {
                Console.WriteLine(@"

                       __                       __
                     __\_\___               ___/_/__
                    /_______ \___       ___/\_______\
                       \_\  \/__/\_____/\__\/  /_/
                                \/_____\/                      __
                                 \o | o/_____ ________________/\_\
                                  \ | /_______\_______________\/
                                   \_/        /               |
                                             /\           _   |
                                            / /\_________/ |__|
                                           / /             / /
                                          /_/             /_/
                                          \ \             \ \
                                           \ \             \_\
                                            \_\            /_/
                                            /_/            |_|

");

                Console.WriteLine("vous trouver un cerf ! ");
                Console.WriteLine("Lancer un dé pour savoir si vous le tuer ");
                Console.ReadLine();
                int estmort = rollthedice(chance);
                if (estmort >= 20)
                {
                    Console.WriteLine("Et PAN le Bambie !");
                    objetrouver = "Viande de Cerf";
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("oh Non il est partie...");
                    objetrouver = "rien";
                    Console.ReadLine();
                }

            }

            else if (Dice >= 96 & Dice <= 99)
            {



                Console.WriteLine(@"

                                         )\   /|
                                          .-/'-|_/ |
                       __            __,-' (   / \/          
                   .-'""  ""'-..__,-'""""          -o.`-._   
                  /                                   '/
          *--._ ./                                 _.-- 
                |                              _.-' 
                :                           .-/   
                 \                       )_ /
                  \                _)   / \(
                    `.   /-.___.---'(  /   \\
                     (  /   \\       \(     L\
                      \(     L\       \\
                       \\              \\
                        L\              L\
                ");
                Console.WriteLine("vous trouver une graine de Sainte Carotte ! ");
                Console.WriteLine("Lancer un dé pour savoir si vous le tuer ");
                Console.ReadLine();
                int estmort = rollthedice(chance);
                if (estmort >= 10)
                {
                    Console.WriteLine("Et PAN le babe !");
                    objetrouver = "Viande de Sanglier";
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("oh Non il est partie...");
                    objetrouver = "rien";
                    Console.ReadLine();
                }


            }
            else if (Dice == 100)
            {
                Console.WriteLine(@"

                       ___
               `-._\ /     `~~""--.,_
              ------>|              `~~""--.,_
               _.-'/ '.____,,,,----""""""~~```'



                ");
                Console.WriteLine("vous trouver une Sainte Carotte ! ");
                objetrouver = "Carotte";

            }

            return objetrouver;




        }
    }
}
