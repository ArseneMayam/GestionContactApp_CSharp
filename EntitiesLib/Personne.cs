﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    public class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private int age;
        private Contact contact;
        private Profession profession;
        private CategoriePersonne categorie;
        private Coordonnees coord;
        private Adresse adresse;
        private int id_profession;
        private int id_categoriePersonne;
        private int id_coordonnees;
        private int id_adresse;
        //constructeurs
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

        public Personne(int id, string nom, string prenom, int age, Profession profession, CategoriePersonne categorie, Coordonnees coord, Adresse adresse)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.profession = profession;
            this.categorie = categorie;
            this.coord = coord;
            this.adresse = adresse;
        }

        public Personne(string nom, string prenom, int age, Profession profession, CategoriePersonne categorie, Coordonnees coord, Adresse adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.profession = profession;
            this.categorie = categorie;
            this.coord = coord;
            this.adresse = adresse;
        }

        public Personne(string nom, string prenom, int age, Contact contact, Profession profession, CategoriePersonne categorie, Coordonnees coord, Adresse adresse, int id_profession)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.contact = contact;
            this.profession = profession;
            this.categorie = categorie;
            this.coord = coord;
            this.adresse = adresse;
            this.id_profession = id_profession;
        }

        public Personne(string nom, string prenom, int age, Contact contact, Profession profession, CategoriePersonne categorie, Coordonnees coord, Adresse adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.contact = contact;
            this.profession = profession;
            this.categorie = categorie;
            this.coord = coord;
            this.adresse = adresse;
        }

        public Personne(int id, string nom, string prenom, int age, Contact contact, Profession profession, CategoriePersonne categorie, Coordonnees coord, Adresse adresse)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.contact = contact;
            this.profession = profession;
            this.categorie = categorie;
            this.coord = coord;
            this.adresse = adresse;
        }

        // propriétés
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

        public Profession Profession
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

        public CategoriePersonne Categorie
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

        public Coordonnees Coord
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

        public Adresse Adresse
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

        public Contact Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }
    }
}
