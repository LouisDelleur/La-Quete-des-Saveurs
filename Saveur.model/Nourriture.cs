using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model
{

    // PARENT des aliments avec leur  base 
    public class Nourriture
    {
        private string _nom;
        private int _Prix;
        private int _gaugefaim;
        private string _description;
        

        public virtual string Nom
        {
            get
            {
                return _nom;
            }

            private set
            {
                _nom = value;
            }
        }

        public virtual int Prix
        {
            get
            {
                return _Prix;
            }

            private set
            {
                _Prix = value;
            }
        }

        public virtual int Gaugefaim
        {
            get
            {
                return _gaugefaim;
            }

            private set
            {
                _gaugefaim = 10;
            }
        }

        public virtual string Description
        {
            get
            {
                return Description;
            }

            set
            {
                _description = value;
            }
        }


    }
}
