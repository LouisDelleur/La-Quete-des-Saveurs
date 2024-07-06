using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.recettte
{
    public class SNavet : Nourriture
    {
        public override string Nom
        {
            get
            {
                return "Soupe de Navet";
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
                return "Une soupe réconfortante et nourrissante à base de navets, idéale pour se réchauffer pendant les froides nuits du royaume.";
            }
        }




    }
}
