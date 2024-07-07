using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.recettte
{
    public class GrillSanglier : Nourriture
    {
        public override string Nom
        {
            get
            {
                return "Sanglier Grillé";
            }
        }
        public override int Prix
        {
            get
            {
                return 4;
            }
        }
        public override int Gaugefaim
        {
            get
            {
                return 5;
            }
        }

        public override string Description
        {
            get
            {
                return "Des tranches de sanglier succulentes et grillées à la flamme. Parfait pour les banquets et les festins rustiques";
            }
        }






    }
}
