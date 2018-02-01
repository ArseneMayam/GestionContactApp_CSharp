using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    public class Adresse
    {
        private int id;
        private string rue;
        private string codePostal;
        private string ville;
        private string pays;
        private int id_personne; // optionnelle


        public Adresse() { }

        public Adresse(int id, string rue, string codePostal, string ville, string pays)
        {
            this.Id = id;
            this.Rue = rue;
            this.CodePostal = codePostal;
            this.Ville = ville;
            this.Pays = pays;
        }

        public Adresse(string rue, string codePostal, string ville, string pays)
        {
            this.rue = rue;
            this.codePostal = codePostal;
            this.ville = ville;
            this.pays = pays;
        }

        public Adresse(int id, string rue, string codePostal, string ville, string pays, int id_personne)
        {
            this.id = id;
            this.rue = rue;
            this.codePostal = codePostal;
            this.ville = ville;
            this.pays = pays;
            this.Id_personne = id_personne;
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

        public int Id_personne
        {
            get
            {
                return id_personne;
            }

            set
            {
                id_personne = value;
            }
        }
    }
}
