using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model.recettte
{
    public class Pain : Nourriture
    {
        public override string Nom
        {
            get
            {
                return "Pain";
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
                return "Une miche de pain croustillante à l'extérieur et moelleuse à l'intérieur. Parfait pour accompagner n'importe quel repas ou pour calmer les petits creux en chemin.";
            }
        }

    }
}
