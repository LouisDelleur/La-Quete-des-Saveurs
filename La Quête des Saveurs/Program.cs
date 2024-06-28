using System.Collections.Generic;
using Saveur.model;




string NomHero = "";
int Faim = 100;
Inventaire inventaire = new Inventaire();
inventaire.AjouterNourriture(new Carotte());


inventaire.AjouterNourriture(new Carotte());

inventaire.SupprimerNourriture(new Carotte());


inventaire.AfficherInventaire();
