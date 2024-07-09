using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.Event
{
    public class prairie
    {

       public string AventurePraire(string objetrouver,int Dice,int chance)
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

                         /|
                      .-((--. 
                     ( '`^'; )
                     `;#    |
                      \#    |
                       \#   \
                        '-.  )
                           \(

");

                Console.WriteLine("vous trouver des graine de navet ! ");
                objetrouver = "Graine de Navet";
                Console.ReadLine();
            }
            else if (Dice >= 81 & Dice <= 95)
            {
                Console.WriteLine(@"

                                 ____...---...___
                ___.....---""""""        .       """"--..____
                     .                  .            .
                 .             _.--._       /|
                        .    .'()..()`.    / /
                            ( `-.__.-' )  ( (    .
                   .         \        /    \ \
                       .      \      /      ) )        .
                            .' -.__.- `.-.-'_.'
                 .        .'  /-____-\  `.-'       .
                          \  /-.____.-\  /-.
                           \ \`-.__.-'/ /\|\|           .
                          .'  `.    .'  `.
                          |/\/\|    |/\/\|

");

                Console.WriteLine("vous trouver un lezard ! ");
                Console.WriteLine("Lancer un dé pour savoir si vous le tuer ");
                Console.ReadLine();
                int estmort = rollthedice(chance);
                if (estmort >= 20)
                {
                    Console.WriteLine("Et PAN le Réxy !");
                    objetrouver = "Queue de Lézard";
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("oh Non il est partie...");
                    objetrouver = "rien";
                    Console.ReadLine();
                }

            }

            else if (Dice >=96 & Dice <= 99)
            {

                
                
                    Console.WriteLine(@"

                       ___
               `-._\ /     `~~""--.,_
              ------>|              `~~""--.,_
               _.-'/ '.____,,,,----""""""~~```'



                ");
                    Console.WriteLine("vous trouver une graine de Sainte Carotte ! ");
                    objetrouver = "Graine de Carotte";
                Console.ReadLine();

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
