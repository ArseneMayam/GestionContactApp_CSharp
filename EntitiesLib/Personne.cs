using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private int age;
        private int id_profession;
        private int id_categoriePersonne;
        private int id_coordonnees;
        private int id_adresse;

        private Profession profession;
        private CategoriePersonne categorie;
        private Coordonnees coord;
        private Adresse adresse;

        public Personne() { }

        public Personne(int id, string nom, string prenom, int age, int id_profession, int id_categoriePersonne, int id_coordonnees, int id_adresse, Profession profession, CategoriePersonne categorie, Coordonnees coord, Adresse adresse)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            this.Id_profession = id_profession;
            this.Id_categoriePersonne = id_categoriePersonne;
            this.Id_coordonnees = id_coordonnees;
            this.Id_adresse = id_adresse;
            this.Profession = profession;
            this.Categorie = categorie;
            this.Coord = coord;
            this.Adresse = adresse;
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

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public int Id_profession
        {
            get
            {
                return id_profession;
            }

            set
            {
                id_profession = value;
            }
        }

        public int Id_categoriePersonne
        {
            get
            {
                return id_categoriePersonne;
            }

            set
            {
                id_categoriePersonne = value;
            }
        }

        public int Id_coordonnees
        {
            get
            {
                return id_coordonnees;
            }

            set
            {
                id_coordonnees = value;
            }
        }

        public int Id_adresse
        {
            get
            {
                return id_adresse;
            }

            set
            {
                id_adresse = value;
            }
        }

        internal Profession Profession
        {
            get
            {
                return profession;
            }

            set
            {
                profession = value;
            }
        }

        internal CategoriePersonne Categorie
        {
            get
            {
                return categorie;
            }

            set
            {
                categorie = value;
            }
        }

        internal Coordonnees Coord
        {
            get
            {
                return coord;
            }

            set
            {
                coord = value;
            }
        }

        internal Adresse Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

    }
}
