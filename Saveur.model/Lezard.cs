using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model
{
    public class Lezard : Nourriture
    {

        public override string Nom
        {
            get
            {
                return "Queue de Lézard";
            }
        }
        public override int Prix
        {
            get
            {
                return 2;
            }
        }
        public override int Gaugefaim
        {
            get
            {
                return -5;
            }
        }

        public override string Description
        {
            get
            {
                return "Un ingrédient exotique qui ajoute un peu de croquant à vos plats. Goût légèrement épicé !";
            }
        }


    }
}
