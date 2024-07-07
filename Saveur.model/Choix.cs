using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model
{
    /* mot clé pour les choix pour le string 
     * camp 
     * foret 
 
     * plaine
     * roi
     * 
    */
    public class Choix
    {
        public string Textechoix( string textEvent)
        {
            ConsoleKeyInfo key;
            int option = 1;
            bool isSelected = false;
            bool estcompleter = false;
            (int left, int top) = Console.GetCursorPosition();
            string color = "0 \u001b[0m";
            if (textEvent == "camp")
            {
                
                Console.CursorVisible = false;

                while (!isSelected)
                {
                    Console.SetCursorPosition(left, top);


                    Console.Write("\n\n\n");
                    Console.WriteLine($"{(option == 1 ? color : "  ")}Aller voir le roi Carotte \u001b[32m");
                    Console.WriteLine($"{(option == 2 ? color : "  ")}Aller dans le potager\u001b[32m"); //  = champ 
                    Console.WriteLine($"{(option == 3 ? color : "  ")}Aller au marcher\u001b[32m");
                    Console.WriteLine($"{(option == 4 ? color : "  ")}Aller dans la prairie\u001b[32m");
                    Console.WriteLine($"{(option == 5 ? color : "  ")}Aller dans la foret\u001b[32m");
                    Console.WriteLine($"{(option == 6 ? color : "  ")}Aller dormir\u001b[32m");
                    Console.WriteLine($"{(option == 7 ? color : "  ")}Faire ca popote (cuisiner)\u001b[32m");

                    key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            option = (option == 7 ? 1 : option + 1);
                            break;
                        case ConsoleKey.UpArrow:
                            option = (option == 1 ? 7 : option - 1);
                            break;
                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;
                    }
                }

                switch (option)
                {
                    case 1:
                        textEvent = "roi";
                        break;
                    case 2:
                        textEvent = "champ";
                        break;
                    case 3:
                        textEvent = "marcher";
                        break;
                    case 4:
                        textEvent = "prairie";
                        break;
                    case 5:
                        textEvent = "foret";
                        break;
                    case 6:
                        textEvent = "dormir";
                        break;
                    case 7:
                        textEvent = "craft";
                        break;
                }
            }
            else if (textEvent == "roi")
            {
                while (!isSelected)
                {
                    Console.SetCursorPosition(left, top);


                    Console.Write("\n\n\n");
                    Console.WriteLine($"{(option == 1 ? color : "  ")}Aller au camp \u001b[32m");
                    Console.WriteLine($"{(option == 2 ? color : "  ")}Aller au marcher\u001b[32m");
                    Console.WriteLine($"{(option == 3 ? color : "  ")}Aller donner les sainte carottes\u001b[32m");
                    

                    key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            option = (option == 3 ? 1 : option + 1);
                            break;
                        case ConsoleKey.UpArrow:
                            option = (option == 1 ? 3 : option - 1);
                            break;
                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;
                    }
                }

                switch (option)
                {
                    case 1:
                        textEvent = "camp";
                        break;
                    case 2:
                        textEvent = "marcher";
                        break;
                    case 3:
                        textEvent = "dormir";
                        break;
                }

            }
            else if (textEvent == "marcher")
            {
                while (!isSelected)
                {
                    Console.SetCursorPosition(left, top);


                    Console.Write("\n\n\n");
                    Console.WriteLine($"{(option == 1 ? color : "  ")}Vendre votre nouriture \u001b[32m");
                    Console.WriteLine($"{(option == 2 ? color : "  ")}Acheter des objets \u001b[32m");
                    Console.WriteLine($"{(option == 3 ? color : "  ")}Aller au camp\u001b[32m");


                    key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            option = (option == 3 ? 1 : option + 1);
                            break;
                        case ConsoleKey.UpArrow:
                            option = (option == 1 ? 3 : option - 1);
                            break;
                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;
                    }
                }

                switch (option)
                {
                    case 1:
                        textEvent = "vendre";
                        break;
                    case 2:
                        textEvent = "acheter";
                        break;
                    case 3:
                        textEvent = "camp";
                        break;
                }

            }
           
            return textEvent;
        }
    }
}


