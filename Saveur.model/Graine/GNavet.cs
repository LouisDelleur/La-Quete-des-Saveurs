using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.Graine
{
    public class GNavet : Nourriture
    {

        public override string Nom
        {
            get
            {
                return "Graine de Navet";
            }
        }
        public override int Prix
        {
            get
            {
                return 0;
            }
        }
        public override int Gaugefaim
        {
            get
            {
                return 0;
            }
        }

        public override string Description
        {
            get
            {
                return "Petite et puissante, cette graine produit des navets robustes, parfaits pour les soupes et les ragoûts.";
            }
        }





    }
}
