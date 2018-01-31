using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    public class Profession
    {
        private int id;
        private string titre;
        private string nomEntreprise;
        private int id_personne;


        public Profession(int id, string titre, string nomEntreprise, int id_personne)
        {
            this.id = id;
            this.titre = titre;
            this.nomEntreprise = nomEntreprise;
            this.id_personne = id_personne;
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

        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }

        public string NomEntreprise
        {
            get
            {
                return nomEntreprise;
            }

            set
            {
                nomEntreprise = value;
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
