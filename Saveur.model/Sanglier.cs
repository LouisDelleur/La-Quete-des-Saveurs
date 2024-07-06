using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model
{
    public class Sanglier: Nourriture
    {

        public override string Nom
        {
            get
            {
                return "Viande de Sanglier";
            }
        }
        public override int Prix
        {
            get
            {
                return 100;
            }
        }
        public override int Gaugefaim
        {
            get
            {
                return 10;
            }
        }

        public override string Description
        {
            get
            {
                return "Une pièce de viande sauvage et robuste. Idéale pour les ragoûts qui réchauffent l'âme des chevaliers.";
            }
        }




    }
}
