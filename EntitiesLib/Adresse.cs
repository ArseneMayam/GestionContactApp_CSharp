using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    class Adresse
    {
        private int id;
        private string rue;
        private string codePostal;
        private string ville;
        private string pays ;


        public Adresse() { }

        public Adresse(int id, string rue, string codePostal, string ville, string pays)
        {
            this.Id = id;
            this.Rue = rue;
            this.CodePostal = codePostal;
            this.Ville = ville;
            this.Pays = pays;
        }


        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Rue
        {
            get
            {
                return rue;
            }

            set
            {
                rue = value;
            }
        }

        public string CodePostal
        {
            get
            {
                return codePostal;
            }

            set
            {
                codePostal = value;
            }
        }

        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }

        public string Pays
        {
            get
            {
                return pays;
            }

            set
            {
                pays = value;
            }
        }

    }
}
