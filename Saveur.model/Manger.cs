using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model
{
    public class Manger
    {
        private const int _MAXFAIM = 100;

        public int Augmenterfaim(int faim,Nourriture lemanger)
        {

            faim += lemanger.Gaugefaim;
            if (faim > _MAXFAIM)
            {
               faim = _MAXFAIM;
            }
              
            return faim;
        }  




    }
}
