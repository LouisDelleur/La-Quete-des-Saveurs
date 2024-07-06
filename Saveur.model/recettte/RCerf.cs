using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.recettte
{
    public class RCerf :Nourriture
    {
        public override string Nom
        {
            get
            {
                return "Ragoût de Cerf ";
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
                return "Un savoureux mélange de viande de cerf et de navets. Parfait pour un festin royal après une longue chasse.";
            }
        }



    }
}
