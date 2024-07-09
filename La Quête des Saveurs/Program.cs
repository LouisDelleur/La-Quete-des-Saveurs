using System;
using System.Collections;
using System.Collections.Generic;
using Saveur.model;
using Saveur.model.Graine;
using Saveur.model.recettte;
using Spectre.Console;

/*
    "roi"
    "champ"
    "marcher"
    "prairie"
    "foret"
    "dormir" 
    "camp"
    "craft"

    Nourriture cae = new Carotte(); --> creation des aliment 
*/

Nourriture Carrotte = new Carotte();
Nourriture Navet = new Navet();
Nourriture Cerf = new Cerf();
Nourriture Sanglier = new Sanglier();
Nourriture Lezard = new Lezard();
Nourriture Grillcarotte = new GrillCarrotte();
Nourriture GrillNavet = new GrillNavet();
Nourriture GrillCref = new GrillCerf();
Nourriture Grillsanglier = new GrillSanglier();
Nourriture Grilllezard = new Grilllezard();
Nourriture Ragcerf = new RCerf();
Nourriture Ragsanglier = new RSanglier();
Nourriture Raglezard = new RLezard();
Nourriture GrCarotte = new GCarotte();
Nourriture Grnavet = new GNavet();



string voici = "Et voici mon brave !";
int x = 110;
int y = 0;
bool aLesCarottes = false;
List<bool> estacheter = new List<bool> { true, true, true, true, true };

Console.SetWindowSize(200, 40);  // Définir la taille de la console
bool rejouer = true;
int Faim = 100; // jauge de faim 
int Or = 0;
int chance = 0;
Inventaire inventaire = new Inventaire(); // cration de l'inventaire 
intro debut = new intro(); // creation de l'intro 

inventaire.AjouterNourriture(Ragcerf);
inventaire.AjouterNourriture(Carrotte);
inventaire.AjouterNourriture(Navet);


// intro 
debut.Intro(); 
Console.Clear();
// intro 

string textEvent = "camp";

while (rejouer)
{
    if (Faim >= 1)
    {
        Choix text = new Choix();

        if (textEvent == "camp")
        {

            LvSeeFood(Faim);
            sousou(Or);
            chancevisu(chance);
            inventaire.AfficherInventaire(x, y);
            Ascii.Camp();
            textEvent = text.Textechoix(textEvent);
            Console.ResetColor();
            Console.Clear();



        }
        else if (textEvent == "roi")
        {
            LvSeeFood(Faim);
            sousou(Or);
            chancevisu(chance);
            inventaire.AfficherInventaire(x, y);
            Ascii.king();
            textEvent = text.Textechoix(textEvent);
            Console.ResetColor();
            Console.Clear();
        }// ok 
        else if (textEvent == "champ")
        {

        }
        else if (textEvent == "marcher")// ok
        {
            LvSeeFood(Faim);
            sousou(Or);
            chancevisu(chance);
            inventaire.AfficherInventaire(x, y);
            Ascii.Marchant();
            textEvent = text.Textechoix(textEvent);
            Console.ResetColor();
            Console.Clear();

            if (textEvent == "vendre")
            {
                bool peuxvendre = false;
                LvSeeFood(Faim);
                sousou(Or);
                chancevisu(chance);
                inventaire.AfficherInventaire(x, y);
                Ascii.();
                textEvent = text.Textechoix(textEvent);
                peuxvendre = inventaire.CheckinventaireMarchant(peuxvendre, textEvent);
                if (peuxvendre == true)
                {
                    Nourriture item = new Nourriture();
                    item = ConvertToNourriture(textEvent);
                    Or = inventaire.SupprimerNourriture(Or, item);

                    Console.WriteLine($"votre {item.Nom} est vendu ");
                    textEvent = "marcher";

                }
                else if (peuxvendre == false)
                {
                    Console.WriteLine("vous ne pouvez pas vendre cela car vous n'avez pas ca enfin");
                    textEvent = "marcher";
                }
                Console.ResetColor();
                Console.Clear();

            }// ok 
            else if (textEvent == "acheter")
            {
                LvSeeFood(Faim);
                sousou(Or);
                chancevisu(chance);
                inventaire.AfficherInventaire(x, y);
                Ascii.achatpossible();
                textEvent = text.Textechoix(textEvent);
                if (textEvent == "feuilles" & estacheter[0] == true & Or >= 10)
                {
                    chance = chance + 8;
                    estacheter[0] = false;
                    Or -= 10;
                    textEvent = "marcher";
                    Console.Clear();
                    LvSeeFood(Faim);
                    sousou(Or);
                    chancevisu(chance);
                    inventaire.AfficherInventaire(x, y);
                    Ascii.Marchant();
                    Console.WriteLine(voici);
                    textEvent = "marcher";
                    Console.ReadLine();

                }
                else if (textEvent == "poulet" & estacheter[1] == true & Or >= 25)
                {
                    chance = chance + 10;
                    estacheter[1] = false;
                    Or -= 25;
                    textEvent = "marcher";
                    Console.Clear();
                    LvSeeFood(Faim);
                    sousou(Or);
                    chancevisu(chance);
                    inventaire.AfficherInventaire(x, y);
                    Ascii.Marchant();
                    Console.WriteLine(voici);
                    textEvent = "marcher";
                    Console.ReadLine();
                }
                else if (textEvent == "Bracelet" & estacheter[2] == true & Or >= 40)
                {
                    chance = chance + 15;
                    estacheter[2] = false;
                    Or -= 40;
                    textEvent = "marcher";
                    Console.Clear();
                    LvSeeFood(Faim);
                    sousou(Or);
                    chancevisu(chance);
                    inventaire.AfficherInventaire(x, y);
                    Ascii.Marchant();
                    Console.WriteLine(voici);
                    textEvent = "marcher";
                    Console.ReadLine();
                }
                else if (textEvent == "cheval" & estacheter[3] == true & Or >= 55)
                {
                    chance = chance + 20;
                    estacheter[3] = false;
                    Or -= 55;
                    textEvent = "marcher";
                    Console.Clear();
                    LvSeeFood(Faim);
                    sousou(Or);
                    chancevisu(chance);
                    inventaire.AfficherInventaire(x, y);
                    Ascii.Marchant();
                    Console.WriteLine(voici);
                    textEvent = "marcher";
                    Console.ReadLine();
                }
                else if (textEvent == "Chapeau" & estacheter[4] == true & Or >= 70)
                {
                    chance = chance + 30;
                    estacheter[4] = false;
                    Or -= 70;
                    textEvent = "marcher";

                    Console.Clear();
                    LvSeeFood(Faim);
                    sousou(Or);
                    chancevisu(chance);
                    inventaire.AfficherInventaire(x, y);
                    Ascii.Marchant();
                    Console.WriteLine(voici);
                    textEvent = "marcher";
                    Console.ReadLine();

                }
                else
                {
                    Console.Clear();
                    LvSeeFood(Faim);
                    sousou(Or);
                    chancevisu(chance);
                    inventaire.AfficherInventaire(x, y);
                    Ascii.Marchant();
                    Console.WriteLine("\n\n\nVous n'avez pas assez d'argent pour cet article, mon brave ! "); // check orto 
                    textEvent = "marcher";
                    Console.ReadLine();
                }

                Console.ResetColor();
                Console.Clear();



            }// acheter ok 


        }// ok
        else if (textEvent == "prairie")
        {

        }
        else if (textEvent == "foret")
        {

        }
        else if (textEvent == "manger") // manger ok 
        {
            bool peuxmanger = false;
            LvSeeFood(Faim);
            sousou(Or);
            chancevisu(chance);
            inventaire.AfficherInventaire(x, y);
            Ascii.Manger(); 
            textEvent = text.Textechoix(textEvent);
            // action de savoir si il peut manger et quoi 
            peuxmanger = inventaire.CheckinventaireMarchant(peuxmanger, textEvent);
            Console.Clear();
            if (peuxmanger == true && (textEvent != "Graine de Carotte" || textEvent!= "Graine de Navet"))
            {
                Nourriture item = new Nourriture();
                item = ConvertToNourriture(textEvent);
                // fonction de faim 
                Manger manger = new Manger();
                Faim = manger.Augmenterfaim(Faim,item);
                inventaire.SupprimerNourritureManger(item);
                textEvent = "manger";
                Console.Clear();
            }
            else if (textEvent != "camp" & peuxmanger == false)
            {

                LvSeeFood(Faim);
                sousou(Or);
                chancevisu(chance);
                inventaire.AfficherInventaire(x, y);
                Ascii.Manger(); 

                Console.WriteLine("Vous ne pouvez pas manger ca !");
                textEvent = "manger";
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                textEvent = "camp";
                Console.Clear();
            }
        }
        else if (textEvent == "dormir") // ok
        {
            LvSeeFood(Faim);
            sousou(Or);
            chancevisu(chance);
            inventaire.AfficherInventaire(x, y);
            Ascii.dodo();
            textEvent = text.Textechoix(textEvent);
            // reduire la faim 
            Faim = Faim - 10;
            Console.ReadLine();
            Console.Clear();




        }// rejouter le potager "champ"
        else if (textEvent == "donner") // ok 
        {
            aLesCarottes = inventaire.dixcarrotes();
            if (aLesCarottes == true)
            {
                textEvent = "win";
                textEvent = text.Textechoix(textEvent);
                rejouer = false;
            }
            else
            {
                textEvent = "chatiment";
                textEvent = text.Textechoix(textEvent);
                Faim -= 10;

            }

        }// ok 

    }
    else
    {
        Console.WriteLine(@"


                                 ███▄ ▄███▓ ▒█████   ██▀███  ▄▄▄█████▓ ██▓  ██████    
                                ▓██▒▀█▀ ██▒▒██▒  ██▒▓██ ▒ ██▒▓  ██▒ ▓▒▓██▒▒██    ▒    
                                ▓██    ▓██░▒██░  ██▒▓██ ░▄█ ▒▒ ▓██░ ▒░▒██▒░ ▓██▄      
                                ▒██    ▒██ ▒██   ██░▒██▀▀█▄  ░ ▓██▓ ░ ░██░  ▒   ██▒   
                                ▒██▒   ░██▒░ ████▓▒░░██▓ ▒██▒  ▒██▒ ░ ░██░▒██████▒▒   
                                ░ ▒░   ░  ░░ ▒░▒░▒░ ░ ▒▓ ░▒▓░  ▒ ░░   ░▓  ▒ ▒▓▒ ▒ ░   
                                ░  ░      ░  ░ ▒ ▒░   ░▒ ░ ▒░    ░     ▒ ░░ ░▒  ░ ░   
                                ░      ░   ░ ░ ░ ▒    ░░   ░   ░       ▒ ░░  ░  ░     
                                       ░       ░ ░     ░               ░        ░     ");

        
        Console.ReadLine();
        Faim = 100;
        Console.Clear() ;
    }




}
// fin gg trop fort 
Console.WriteLine("merci d'avoir jouer a 'la quête des Saveurs'" +
    "made by Marty_McMouche");
// Goblin Gang 






//FONCTION 
// lancer un dé
int rollthedice()
{
    Random ren = new Random();

    int solutionde = ren.Next(1, 100);

    return solutionde;
}
//voir la jauge de nouriture avec console.spectre
void LvSeeFood(int Nouriture)
{
    AnsiConsole.Write(new BarChart()
        .Width(Faim)
        .CenterLabel()
        .AddItem("Faim  ", Nouriture, Color.Green));

}

void sousou(int Or)
{
    AnsiConsole.Write(new BarChart()
        .Width(100)
        .CenterLabel()
        .AddItem("Or    ",Or, Color.Yellow));
}

void chancevisu(int chance)
{
    AnsiConsole.Write(new BarChart()
        .Width(100)
        .CenterLabel()
        .AddItem("Chance", chance, Color.Blue));

}


// convestion de string en nourriture 

Nourriture ConvertToNourriture(string objet)
{
    
    Nourriture Carrotte = new Carotte();
    Nourriture Navet = new Navet();
    Nourriture Cerf = new Cerf();
    Nourriture Sanglier = new Sanglier();
    Nourriture Lezard = new Lezard();
    Nourriture Grillcarotte = new GrillCarrotte();
    Nourriture GrillNavet = new GrillNavet();
    Nourriture GrillCref = new GrillCerf();
    Nourriture Grillsanglier = new GrillSanglier();
    Nourriture Grilllezard = new Grilllezard();
    Nourriture Ragcerf = new RCerf();
    Nourriture Ragsanglier = new RSanglier();
    Nourriture Raglezard = new RLezard();
    Nourriture GrCarotte = new GCarotte();
    Nourriture Grnavet = new GNavet();


    if (objet == Carrotte.Nom)
    {
        return Carrotte;
    } 
    else if (objet == Navet.Nom) 
    {  
        return Navet; 
    }
    else if (objet == Cerf.Nom) 
    { 
        return Cerf; 
    }
    else if (objet == Sanglier.Nom)
    {
        return Sanglier;
    }
    else if (objet == Lezard.Nom)
    {
        return Lezard;
    }
    else if (objet == Grillcarotte.Nom)
    {
        return Grillcarotte;
    }
    else if (objet == GrillNavet.Nom)
    {
        return GrillNavet;
    }
    else if (objet == GrillCref.Nom)
    {
        return GrillCref;
    }
    else if (objet == Grillsanglier.Nom)
    {
        return Grillsanglier;
    }
    else if (objet == Grilllezard.Nom)
    {
        return Grilllezard;
    }
    else if (objet == Ragcerf.Nom)
    {
        return Ragcerf;
    }
    else if (objet == Ragsanglier.Nom)
    {
        return Ragsanglier;
    }
    else if (objet == Raglezard.Nom)
    {
        return Raglezard;
    }
    else if (objet == GrCarotte.Nom)
    {
        return GrCarotte;
    }
    else if (objet == Grnavet.Nom)
    {
        return Grnavet;
    }

    return Carrotte;
} 