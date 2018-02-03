using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    public class CategoriePersonne
    {
        private int id;
        private string titre;
        private int id_personne;

        public CategoriePersonne() { }

        public CategoriePersonne(int id, string titre, int id_personne)
        {
            this.Id = id;
            this.Titre = titre;
            this.Id_personne = id_personne;
        }

        public CategoriePersonne(string titre)
        {
            this.titre = titre;
        }

        public CategoriePersonne(string titre, int id_personne)
        {
            this.titre = titre;
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
