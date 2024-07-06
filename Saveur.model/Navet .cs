using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model
{
    public class Navet : Nourriture
    {
        public override string Nom
        {
            get
            {
                return "Navet";
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
                return "Un navet apparemment ordinaire, mais imbibé de chance pure. À consommer avec modération pour éviter les excès de bonheur.";
            }
        }
    }


}

