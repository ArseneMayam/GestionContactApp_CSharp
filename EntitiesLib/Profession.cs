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

        //constructeurs
        public Profession() { }


        public Profession(int id, string titre, string nomEntreprise, int id_personne)
        {
            this.id = id;
            this.titre = titre;
            this.nomEntreprise = nomEntreprise;
            this.id_personne = id_personne;
        }

        public Profession(int id, string titre, string nomEntreprise)
        {
            this.id = id;
            this.titre = titre;
            this.nomEntreprise = nomEntreprise;
        }

        public Profession(string titre, string nomEntreprise, int id_personne)
        {
            this.titre = titre;
            this.nomEntreprise = nomEntreprise;
            this.id_personne = id_personne;
        }

        //propriétés
        public int Id
        {
            get{ return this.id; }
            set {this.id = value; }
        }
        public string Titre
        {
            get { return this.titre; }
            set { this.titre = value; }

        }
        public string NomEntreprise
        {

            get { return this.nomEntreprise; }
            set { this.nomEntreprise = value; }
        }
        public int Id_personne
        {
            get { return this.id_personne; }
            set { this.id_personne = value; }
        }

       
    }
}
