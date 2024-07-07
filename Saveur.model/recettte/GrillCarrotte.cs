using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.recettte
{
    public class GrillCarrotte : Nourriture
    {
        public override string Nom
        {
            get
            {
                return "Carotte Grillée";
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
                return 20;
            }
        }

        public override string Description
        {
            get
            {
                return "Carottes croustillantes à l'extérieur et tendres à l'intérieur, légèrement caramélisées par la chaleur. Un plat qui ferait saliver même le roi Carotte !";
            }
        }





    }
}
