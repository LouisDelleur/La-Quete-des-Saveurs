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

        public Inventaire() 
        { 
            _stock = new Dictionary<string, int>();

            _stock.Add("Carotte", 0);
            _stock.Add("Navet", 0);
            _stock.Add("Blé", 0);
            _stock.Add("viande de cerf", 0);
            _stock.Add("viande de Sanglier", 0);
            _stock.Add("queu de lézard", 0);


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

        public void SupprimerNourriture (Nourriture Objet) 
        {
            if (_stock.ContainsKey(Objet.Nom))
            {
                _stock[Objet.Nom]--;
            }
            else
            {
                _stock[Objet.Nom] = 1;
            }
        }


        // TO DO rejouter un point chance et coliier pour le modifier 

        //Fonction pour afficher le contenu de l'inventaire (a voir avec les autre fonsonaliter pour l'affichage)

        public void AfficherInventaire(int x, int y)
        {
            int i = 0;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Inventory:");
            foreach (var item in _stock)
            {
                int column = i / 8; // Determine les column (0 or 1)
                int row = i % 8;    // Determine the row (0 to 4)
                Console.SetCursorPosition(x + column * 30, y + row + 1);
                Console.WriteLine($"- {item.Key}: {item.Value}");
                i++;
            }
        }
    }

}
