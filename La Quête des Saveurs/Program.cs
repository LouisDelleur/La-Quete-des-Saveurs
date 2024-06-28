using System.Collections.Generic;
using Saveur.model;
using Spectre.Console;




string NomHero = "";
int Faim = 100;
Inventaire inventaire = new Inventaire();
inventaire.AjouterNourriture(new Carotte());


inventaire.AjouterNourriture(new Carotte());

inventaire.SupprimerNourriture(new Carotte());


inventaire.AfficherInventaire();

// Création du panneau pour l'inventaire
var inventoryPanel = new Panel("Inventaire:\n- Épée\n- Bouclier\n- Potion")
    .Header("Inventaire")
    .Border(BoxBorder.Rounded);

// Création du panneau pour les actions possibles
var actionsPanel = new Panel("Actions possibles:\n1. Attaquer\n2. Défendre\n3. Fuir")
    .Header("Actions")
    .Border(BoxBorder.Rounded);

// Création du panneau pour les images en ASCII
var asciiImagePanel = new Panel(@"ASCII Art:
   /\_/\  
  ( o.o ) 
   > ^ <")
    .Header("Images ASCII")
    .Border(BoxBorder.Rounded);

// Organisation des panneaux dans une grille
var grid = new Grid();
grid.AddColumn(new GridColumn().NoWrap().Padding(1, 1));
grid.AddColumn(new GridColumn().NoWrap().Padding(1, 1));

// Ligne 1 : ASCII et Inventaire
grid.AddRow(asciiImagePanel, inventoryPanel);
// Ligne 2 : Actions
grid.AddRow(actionsPanel, new Panel("").NoBorder());

// Affichage de la grille
AnsiConsole.Write(grid);

