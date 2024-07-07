using System;
using System.Collections;
using System.Collections.Generic;
using Saveur.model;
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
*/



Console.SetWindowSize(200, 40);  // Définir la taille de la console
bool rejouer = true;
int Faim = 100; // jauge de faim 
int Or = 0;
Inventaire inventaire = new Inventaire(); // cration de l'inventaire 
intro debut = new intro(); // creation de l'intro 

// intro 
debut.Intro(); 
Console.Clear();
// intro 

string textEvent = "camp";

while (rejouer)
{
    Choix text = new Choix();

    if (textEvent == "camp")
    {

        LvSeeFood(Faim);
        sousou(Or);
        inventaire.AfficherInventaire(70, 0);
        Ascii.Camp();
        textEvent = text.Textechoix(textEvent);
        Console.ResetColor();
        Console.Clear();

    }
    else if (textEvent == "roi")
    {
        LvSeeFood(Faim);
        sousou(Or);
        inventaire.AfficherInventaire(70, 0);
        Ascii.king();
        textEvent = text.Textechoix(textEvent);
        Console.ResetColor();
        Console.Clear();
    }
    else if (textEvent == "champ")
    {

    }
    else if (textEvent == "marcher")
    {
        LvSeeFood(Faim);
        sousou(Or);
        inventaire.AfficherInventaire(70, 0);
        Ascii.king();
        textEvent = text.Textechoix(textEvent);
        Console.ResetColor();
        Console.Clear();

        if (textEvent == "vendre")
        {
            LvSeeFood(Faim);
            sousou(Or);
            inventaire.AfficherInventaire(70, 0);
            Ascii.king();

        }
        else if (textEvent == "acheter")
        {

        }


    }
    else if (textEvent == "prairie")
    {

    }
    else if (textEvent == "foret")
    {

    }
    else if (textEvent == "dormir")
    {

    }





}


Console.ReadLine();
Console.Clear();




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
        .Width(60)
        .CenterLabel()
        .AddItem("Faim", Nouriture, Color.Green));

}

void sousou(int Or)
{
    AnsiConsole.Write(new BarChart()
        .Width(60)
        .CenterLabel()
        .AddItem("Or",Or, Color.Yellow));
}