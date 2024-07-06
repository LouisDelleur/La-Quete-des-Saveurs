using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.recettte
{
    public class RLezard : Nourriture
    {

        public override string Nom
        {
            get
            {
                return "Ragoût de Lézard";
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
                return "Un plat exotique alliant la queue de lézard croquante et des navets juteux. Pour les aventuriers au palais audacieux.";
            }
        }


    }
}
