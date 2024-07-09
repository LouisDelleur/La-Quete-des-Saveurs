using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.Graine
{
    public class GCarotte : Nourriture
    {
        public override string Nom
        {
            get
            {
                return "Graine de Carotte";
            }
        }
        public override int Prix
        {
            get
            {
                return 10;
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
                return "Une graine bénie par les dieux des légumes. Plantez-la et récoltez une carotte digne des rois !";
            }
        }


    }
}
