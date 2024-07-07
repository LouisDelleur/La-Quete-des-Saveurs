using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model
{
    public class Carotte : Nourriture
    {
        public override string Nom
        {
            get
            {
                return "Carotte";
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
                return 100;
            }
        }

        public override string Description
        {
            get
            {
                return "Une carotte si rare qu'elle est réservée aux rois et aux dieux. Redonne beaucoup de points de nourriture, et un peu de noblesse à votre repas.";
            }
        }
    }
}
