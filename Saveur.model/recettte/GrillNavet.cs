using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.recettte
{
    public class GrillNavet : Nourriture
    {

        public override string Nom
        {
            get
            {
                return "Navet Grillé";
            }
        }
        public override int Prix
        {
            get
            {
                return 3;
            }
        }
        public override int Gaugefaim
        {
            get
            {
                return 7;
            }
        }

        public override string Description
        {
            get
            {
                return "Des tranches de navet parfaitement grillées, avec une touche de fumée. Un délice simple mais savoureux pour les amateurs de légumes.";
            }
        }





    }
}
