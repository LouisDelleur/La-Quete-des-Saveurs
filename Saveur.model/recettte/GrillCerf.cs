using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.recettte
{
    public class GrillCerf: Nourriture
    {

        public override string Nom
        {
            get
            {
                return "Cerf Grillé";
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
                return "Des morceaux de cerf grillés à la perfection, juteux et riches en saveur. Un mets digne des plus grands chasseurs.";
            }
        }






    }
}
