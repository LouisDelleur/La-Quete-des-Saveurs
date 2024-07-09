using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace Saveur.model
{
    public class Inventaire
    {
        // creation d'un dico pour stocker et ajouter sup vérifer ,... 
        private Dictionary<string, int> _stock;
        public int chance;

        public Inventaire() 
        { 
            _stock = new Dictionary<string, int>();

            _stock.Add("Carotte", 0);
           


        }


        // fonction pour check l'inventaire 
        public void AjouterNourriture (Nourriture Objet)
        {
            if (_stock.ContainsKey(Objet.Nom))
            {
                _stock[Objet.Nom]++;
            }
            else
            {
                _stock[Objet.Nom] = 1;
            }
    
        }

        public int SupprimerNourriture (int or,Nourriture Objet) 
        {
           
            
            if (_stock.ContainsKey(Objet.Nom) && _stock[Objet.Nom] >=1)
            {
                
                _stock[Objet.Nom]--;
                return or = or + Objet.Prix;
            }
            else
            {
                _stock[Objet.Nom] = 0;
                return or;
            }
        }

        public void SupprimerNourritureManger(Nourriture Objet)
        {


            if (_stock.ContainsKey(Objet.Nom) && _stock[Objet.Nom] >= 1)
            {

                _stock[Objet.Nom]--;
                
            }
            else
            {
                _stock[Objet.Nom] = 0;
      
            }
        }


        // mofication de la chance 
        public int modifchance(int modif)
        {
            if (modif == 1) 
            {
                chance = chance + 8;

            }
            else if (modif == 2)
            {
                chance = chance + 10;
            }
            else if (modif == 3)
            {
                chance = chance + 15;
            }
            else if (modif == 4)
            {
                chance = chance + 20;
            }
            else if (modif == 5)
            {
                chance = chance + 30;
            }

            return chance;
        } 


        // check si il y a les 10 carottes 

        public bool dixcarrotes()
        {
            bool aLescarottes = false;
            foreach (var Car in _stock)
            {
                if (Car.Key == "Carotte" & Car.Value == 10)
                {
                   aLescarottes = true;

                }
            }


            return aLescarottes;
        }

        public bool CheckinventaireMarchant(bool estDansLinventaire ,string check)
        {
     
            foreach(var item in _stock)
            {
                if (item.Key == check & item.Value >=1)
                {
                    return estDansLinventaire = true; 
                }
            }

            return estDansLinventaire = false;


        }


        //Fonction pour afficher le contenu de l'inventaire 
        public void AfficherInventaire(int x, int y)
        {
            int i = 0;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Inventory:");
            foreach (var item in _stock)
            {
                int column = i / 8; // Determine les column (0 or 1)
                int row = i % 8;    // Determine the row (0 to 8)
                Console.SetCursorPosition(x + column * 30, y + row + 1);
                Console.WriteLine($"- {item.Key}: {item.Value}");
                i++;
            }
        }
    }

}
