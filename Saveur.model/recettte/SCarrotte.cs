using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.recettte
{
    public class SCarrotte : Nourriture
    {
        public override string Nom
        {
            get
            {
                return "Soupe de Carotte";
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
                return "Bien que cela réduise la valeur des précieuses carottes aux yeux des dieux, cette soupe est extrêmement populaire parmi le peuple. Un réconfort simple et savoureux.";
            }
        }





    }
}
