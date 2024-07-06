using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model
{
    public class Cerf : Nourriture
    {

        public override string Nom
        {
            get
            {
                return "Viande de Cerf";
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
                return "Une délicieuse tranche de viande de cerf. Parfaite pour les festins royaux ou un barbecue improvisé.";
            }
        }






    }
}
