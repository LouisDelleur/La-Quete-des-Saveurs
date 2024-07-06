using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model
{
    public class intro
    {
        public void Intro() 
        {
            

            var panel = new Panel("\nNous sommes en l'an 456.\n" +
                "Vous êtes l'un des courageux chevaliers du roi Carotte (et non pas du piniouf roi Patate).\n")
             .Header("intro")
             .Border(BoxBorder.Ascii);
            
            AnsiConsole.Write(panel);

            Console.ReadLine();
            Console.Clear();

            var panel2 = new Panel("\n Votre mission,\n noble et vitale, est de parcourir le royaume à la recherche des 10 Sainte Carottes pour notre bon roi.\n " +
                "Ces précieuses reliques sont essentielles pour préserver la paix et la prospérité de notre terre.\n")
            .Header("intro")
            .Border(BoxBorder.Ascii);

            AnsiConsole.Write(panel2);

            Console.ReadLine();

        }



    }
}
