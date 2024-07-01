using System;
using System.Collections.Generic;
using Saveur.model;
using Spectre.Console;


Console.SetWindowSize(120, 30);  // Définir la taille de la console

string NomHero = "";
int Faim = 100;
Inventaire inventaire = new Inventaire();
inventaire.AjouterNourriture(new Carotte());



inventaire.AjouterNourriture(new Carotte());

inventaire.SupprimerNourriture(new Carotte());


inventaire.AfficherInventaire(50, 0);




