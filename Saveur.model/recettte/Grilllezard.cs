using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.recettte
{
    public class Grilllezard : Nourriture
    {
        public override string Nom
        {
            get
            {
                return "Lézard Grillé";
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
                return "Queue de lézard grillée, avec une saveur unique et épicée. Pour ceux qui cherchent une expérience culinaire exotique.";
            }
        }


    }
}
