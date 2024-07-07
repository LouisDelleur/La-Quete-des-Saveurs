using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.recettte
{
    public class RSanglier : Nourriture
    {
        public override string Nom
        {
            get
            {
                return "Ragoût de Sanglier";
            }
        }
        public override int Prix
        {
            get
            {
                return 5;
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
                return "Un ragoût robuste et nourrissant, combinant la viande sauvage de sanglier avec des navets délicieusement tendres.";
            }
        }

    }
}
