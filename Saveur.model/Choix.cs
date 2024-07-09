using Microsoft.VisualBasic.FileIO;
using Spectre.Console;
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
     * Dormir
     * prairie
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

                while (!isSelected) // camp ok 
                {
                    Console.ResetColor();
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine("\n \n \nBienvenue au campement, chevalier. \n" +
                        "Ici, vous trouverez tout ce dont vous avez besoin pour vous reposer et vous préparer à votre quête. \n" +
                        "Installez-vous près du feu de camp, échangez des histoires avec vos compagnons et rechargez vos forces avant de repartir à l'aventure.");
                    Console.ForegroundColor = ConsoleColor.Green;


                    Console.Write("\n\n\n");
                    Console.WriteLine($"{(option == 1 ? color : "  ")}Aller voir le roi Carotte \u001b[32m");
                    Console.WriteLine($"{(option == 2 ? color : "  ")}Aller dans le potager\u001b[32m"); //  = champ 
                    Console.WriteLine($"{(option == 3 ? color : "  ")}Aller au marcher\u001b[32m");
                    Console.WriteLine($"{(option == 4 ? color : "  ")}Aller dans la prairie\u001b[32m");
                    Console.WriteLine($"{(option == 5 ? color : "  ")}Aller dans la foret\u001b[32m");
                    Console.WriteLine($"{(option == 6 ? color : "  ")}Aller dormir\u001b[32m");
                    Console.WriteLine($"{(option == 7 ? color : "  ")}Faire ca popote (cuisiner)\u001b[32m");
                    Console.WriteLine($"{(option == 8 ? color : "  ")}Manger\u001b[32m");

                    key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            option = (option == 8 ? 1 : option + 1);
                            break;
                        case ConsoleKey.UpArrow:
                            option = (option == 1 ? 8 : option - 1);
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
                    case 8:
                        textEvent = "manger";
                        break;
                }
            }
            else if (textEvent == "roi")
            {
                while (!isSelected)
                {
                    Console.ResetColor();
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine("\n \n \nBienvenue, chevalier, au grand hall du roi Carotte. \n" +
                        "Le roi, assis sur son trône majestueux, vous accueille avec un regard solennel. Il vous rappelle l'importance de votre quête : \n" +
                        "Trouver les 10 Sainte Carottes pour préserver la prospérité du royaume.");
                    Console.ForegroundColor = ConsoleColor.Green;


                    Console.Write("\n\n\n");
                    Console.WriteLine($"{(option == 1 ? color : "  ")}Aller au camp \u001b[32m");
                    Console.WriteLine($"{(option == 2 ? color : "  ")}Aller au marcher\u001b[32m");
                    Console.WriteLine($"{(option == 3 ? color : "  ")}donner les sainte carottes\u001b[32m");


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
                        textEvent = "donner";
                        break;
                }

            } // ok 
            else if (textEvent == "marcher")
            {
                while (!isSelected)
                {
                    Console.ResetColor();
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine("\n \n \nBienvenue au marché, l'épicentre du commerce et de la vie sociale du royaume. \n" +
                        "Parcourez les étals colorés, rencontrez des marchands exotiques et trouvez des trésors inattendus.  \n" +
                        "C'est l'endroit idéal pour se procurer objets de chance et vendre vos ressources");
                    Console.ForegroundColor = ConsoleColor.Green;


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
            else if (textEvent == "dormir")
            {

                Console.WriteLine("\n \n \n Après une longue journée de quête et d'aventures, \n " +
                    "il est temps de fermer les yeux et de se reposer. Trouvez un coin confortable, \n" +
                    "laissez vos soucis derrière vous et plongez dans un sommeil réparateur. \n" +
                    "Demain est un nouveau jour rempli de nouvelles opportunités et défis. ");
                Console.WriteLine("Appuyez sur n'importe quel touche pour continuer ");

                textEvent = "camp";



            }
            else if (textEvent == "foret")
            {

            }
            else if (textEvent == "prairie")
            {

            }
            else if (textEvent == "craft")
            {

            }
            else if (textEvent == "vendre")
            {
                while (!isSelected)
                {
                    Console.ResetColor();
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine("\n \n \n Ah, bienvenue, noble chevalier !\n" +
                        "Si vous avez des objets dont vous n'avez plus besoin, je suis prêt à vous les racheter à bon prix.\n" +
                        "Chaque pièce a de la valeur ici au marché. Échangez vos trouvailles contre de l'or pour vous aider dans votre quête !\"");
                    Console.ForegroundColor = ConsoleColor.Green;


                    Console.Write("\n\n\n");
                    Console.WriteLine($"{(option == 1 ? color : "  ")}Vendre Carrotte  \u001b[32m");
                    Console.WriteLine($"{(option == 2 ? color : "  ")}Vendre Navet \u001b[32m");
                    Console.WriteLine($"{(option == 3 ? color : "  ")}Vendre Viande de Cerf \u001b[32m");
                    Console.WriteLine($"{(option == 4 ? color : "  ")}Vendre Viande de Sanglier\u001b[32m");
                    Console.WriteLine($"{(option == 5 ? color : "  ")}Vendre Queue de Lézard\u001b[32m");
                    Console.WriteLine($"{(option == 6 ? color : "  ")}Vendre Carotte Grillée\u001b[32m");
                    Console.WriteLine($"{(option == 7 ? color : "  ")}Vendre Navet Grillé\u001b[32m");
                    Console.WriteLine($"{(option == 8 ? color : "  ")}Vendre Cerf Grillé\u001b[32m");
                    Console.WriteLine($"{(option == 9 ? color : "  ")}Vendre Sanglier Grillé\u001b[32m");
                    Console.WriteLine($"{(option == 10 ? color : "  ")}Vendre Lézard Grillé\u001b[32m");
                    Console.WriteLine($"{(option == 11 ? color : "  ")}Vendre Ragoût de Cerf\u001b[32m");
                    Console.WriteLine($"{(option == 12 ? color : "  ")}Vendre Ragoût de Sanglier\u001b[32m");
                    Console.WriteLine($"{(option == 13 ? color : "  ")}Vendre Ragoût de Lézard\u001b[32m");
                    Console.WriteLine($"{(option == 14 ? color : "  ")}Vendre Graine de Carotte\u001b[32m");
                    Console.WriteLine($"{(option == 15 ? color : "  ")}Vendre Graine de Navet\u001b[32m");
                    Console.WriteLine($"{(option == 16 ? color : "  ")}Retour\u001b[32m");



                    key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            option = (option == 16 ? 1 : option + 1);
                            break;
                        case ConsoleKey.UpArrow:
                            option = (option == 1 ? 16 : option - 1);
                            break;
                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;
                    }


                    switch (option)
                    {
                        case 1:
                            textEvent = "Carotte";
                            break;
                        case 2:
                            textEvent = "Navet";
                            break;
                        case 3:
                            textEvent = "Viande de Cerf";
                            break;
                        case 4:
                            textEvent = "Viande de sanglier";
                            break;
                        case 5:
                            textEvent = "Queue de lézard";
                            break;
                        case 6:
                            textEvent = "Carotte Grillée";
                            break;
                        case 7:
                            textEvent = "Navet Grillé";
                            break;
                        case 8:
                            textEvent = "Cerf Grillé";
                            break;
                        case 9:
                            textEvent = "Sanglier Grillé";
                            break;
                        case 10:
                            textEvent = "Lézard Grillé";
                            break;
                        case 11:
                            textEvent = "Ragoût de Cerf";
                            break;
                        case 12:
                            textEvent = "Ragoût de Sanglier";
                            break;
                        case 13:
                            textEvent = "Ragoût de Lézard";
                            break;
                        case 14:
                            textEvent = "Graine de Carotte";
                            break;
                        case 15:
                            textEvent = "Graine de Navet";
                            break;
                        case 16:
                            textEvent = "marcher";
                            break;
                    }




















                }
            }// ok 
            else if (textEvent == "acheter")
            {
                while (!isSelected)
                {
                    Console.ResetColor();
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine("\n \n \nBienvenue, vaillant chevalier ! Aujourd'hui, \n" +
                        " j'ai des objets rares et précieux à vous offrir : des porte-bonheur et talismans enchantés.  \n" +
                        "Ces trésors augmentent votre chance et peuvent faire la différence entre la victoire et la défaite. \n" +
                        "Jetez un œil et trouvez l'objet de chance qui vous accompagnera dans vos aventures !");
                    Console.ForegroundColor = ConsoleColor.Green;


                    Console.Write("\n\n\n");
                    Console.WriteLine($"{(option == 1 ? color : "  ")}Acheter Trèfle à 4 feuilles \u001b[32m");
                    Console.WriteLine($"{(option == 2 ? color : "  ")}Acheter Fer à cheval \u001b[32m");
                    Console.WriteLine($"{(option == 3 ? color : "  ")}Acheter Bracelet de chance\u001b[32m");
                    Console.WriteLine($"{(option == 4 ? color : "  ")}Acheter Os de poulet \u001b[32m");
                    Console.WriteLine($"{(option == 5 ? color : "  ")}Acheter Chapeau de chance \u001b[32m");



                    key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            option = (option == 5 ? 1 : option + 1);
                            break;
                        case ConsoleKey.UpArrow:
                            option = (option == 1 ? 5 : option - 1);
                            break;
                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;
                    }
                }

                switch (option)
                {
                    case 1:
                        textEvent = "feuilles";
                        break;
                    case 2:
                        textEvent = "cheval";
                        break;
                    case 3:
                        textEvent = "Bracelet";
                        break;
                    case 4:
                        textEvent = "poulet";
                        break;
                    case 5:
                        textEvent = "Chapeau";
                        break;
                }

            }
            else if (textEvent == "manger")
            {
                while (!isSelected)
                {
                    Console.ResetColor();
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine("\n \n \n Aaaaah, Que vous dégustiez un ragoût savoureux,\n" +
                        "ou une viande grillée à la perfection, chaque repas est un festin pour les sens.\n" +
                        "Prenez le temps de savourer chaque bouchée, car un ventre plein rend un chevalier plus fort et plus vaillant!\"");
                    Console.ForegroundColor = ConsoleColor.Green;


                    Console.Write("\n\n\n");
                    Console.WriteLine($"{(option == 1 ? color : "  ")}Manger Carrotte  \u001b[32m");
                    Console.WriteLine($"{(option == 2 ? color : "  ")}Manger Navet \u001b[32m");
                    Console.WriteLine($"{(option == 3 ? color : "  ")}Manger Viande de Cerf \u001b[32m");
                    Console.WriteLine($"{(option == 4 ? color : "  ")}Manger Viande de Sanglier\u001b[32m");
                    Console.WriteLine($"{(option == 5 ? color : "  ")}Manger Queue de Lézard\u001b[32m");
                    Console.WriteLine($"{(option == 6 ? color : "  ")}Manger Carotte Grillée\u001b[32m");
                    Console.WriteLine($"{(option == 7 ? color : "  ")}Manger Navet Grillé\u001b[32m");
                    Console.WriteLine($"{(option == 8 ? color : "  ")}Manger Cerf Grillé\u001b[32m");
                    Console.WriteLine($"{(option == 9 ? color : "  ")}Manger Sanglier Grillé\u001b[32m");
                    Console.WriteLine($"{(option == 10 ? color : "  ")}Manger Lézard Grillé\u001b[32m");
                    Console.WriteLine($"{(option == 11 ? color : "  ")}Manger Ragoût de Cerf\u001b[32m");
                    Console.WriteLine($"{(option == 12 ? color : "  ")}Manger Ragoût de Sanglier\u001b[32m");
                    Console.WriteLine($"{(option == 13 ? color : "  ")}Manger Ragoût de Lézard\u001b[32m");
                    Console.WriteLine($"{(option == 14 ? color : "  ")}Retour\u001b[32m");



                    key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            option = (option == 14 ? 1 : option + 1);
                            break;
                        case ConsoleKey.UpArrow:
                            option = (option == 1 ? 14 : option - 1);
                            break;
                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;
                    }


                    switch (option)
                    {
                        case 1:
                            textEvent = "Carotte";
                            break;
                        case 2:
                            textEvent = "Navet";
                            break;
                        case 3:
                            textEvent = "Viande de Cerf";
                            break;
                        case 4:
                            textEvent = "Viande de sanglier";
                            break;
                        case 5:
                            textEvent = "Queue de lézard";
                            break;
                        case 6:
                            textEvent = "Carotte Grillée";
                            break;
                        case 7:
                            textEvent = "Navet Grillé";
                            break;
                        case 8:
                            textEvent = "Cerf Grillé";
                            break;
                        case 9:
                            textEvent = "Sanglier Grillé";
                            break;
                        case 10:
                            textEvent = "Lézard Grillé";
                            break;
                        case 11:
                            textEvent = "Ragoût de Cerf";
                            break;
                        case 12:
                            textEvent = "Ragoût de Sanglier";
                            break;
                        case 13:
                            textEvent = "Ragoût de Lézard";
                            break;
                        case 14:
                            textEvent = "camp";
                            break;



                    }
                }
            }
            // choix si hero donne carrote ou non 
            else if (textEvent == "chatiment")
            {
                Ascii.chatiment();
                var panel = new Panel("\n\"Chevalier, votre quête est inachevée!\n" +
                "Le roi Carotte est profondément déçu de votre échec à rassembler les 10 Sainte Carottes.\n" +
                "En guise de châtiment, vous êtes condamné à poursuivre votre mission sans relâche!\n" +
                "Retournez sur les routes, affrontez de nouveaux défis, et ne revenez que lorsque vous aurez accompli cette noble tâche.\n ")
             .Header("intro")
             .Border(BoxBorder.Ascii);

                AnsiConsole.Write(panel);

                Console.ReadLine();
                Console.Clear();
                textEvent = "roi";


            } // ok 
            else if (textEvent == "win")
            {
                Ascii.kinghtWin();
                var panel = new Panel("\n\"Chevalier vaillant,votre quête est accomplie !\n" +
                "Vous avez bravé mille dangers et surmonté d'innombrables défis pour réunir les 10 Sainte Carottes.\n" +
                "Le roi Carotte et tout le royaume vous en sont éternellement reconnaissants.\n" +
                "Mais n'oubliez pas, de nouvelles aventures palpitantes et de mystérieuses quêtes vous attendent encore.\n " +
                "Préparez-vous à écrire la suite de votre légende !\n")
             .Header("intro")
             .Border(BoxBorder.Ascii);

                AnsiConsole.Write(panel);

                Console.ReadLine();
                Console.Clear();
            } // ok 
            
            
            // retrun l'info en foction de
            return textEvent;
        }
    }
}


