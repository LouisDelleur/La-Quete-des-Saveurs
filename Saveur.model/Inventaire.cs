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




        //Fonction pour afficher le contenu de l'inventaire (a voir avec les autre fonsonaliter pour l'affichage)

        public void AfficherInventaire(int x, int y)
        {
            int i = 0;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Inventory:");
            foreach (var item in _stock)
            {
                Console.SetCursorPosition(x, y + i + 1);
                Console.WriteLine(item.Key +" : " +item.Value);
                i++;
            }
        }
    }

}
