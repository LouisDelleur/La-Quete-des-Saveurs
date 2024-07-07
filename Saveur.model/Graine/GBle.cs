using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.Graine
{
    public class GBle : Nourriture
    {
        public override string Nom
        {
            get
            {
                return "Blé";
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
                return "Les grains dorés qui nourrissent le royaume. De quoi faire du pain, des pâtes, et plus encore.";
            }
        }


    }
}
