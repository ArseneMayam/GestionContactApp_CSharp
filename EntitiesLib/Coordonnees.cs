using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
   public class Coordonnees
    {
        private int id;
        private string telephone;
        private string fax;
        private string email;
        private int id_personne;
        // constructeurs
        public Coordonnees() { }
        public Coordonnees(int id, string telephone, string fax, string email, int id_personne)
        {
            this.id = id;
            this.telephone = telephone;
            this.fax = fax;
            this.email = email;
            this.id_personne = id_personne;
        }

        public Coordonnees(int id, string telephone, string fax, string email)
        {
            this.id = id;
            this.telephone = telephone;
            this.fax = fax;
            this.email = email;
        }
        // propriétés
        public int Id
        {
            get
            {
                return id;
            }
            set {
                this.id = value;
            }
        }
        public string Telephone
        {
            get
            {
                return telephone;
            }
            set
            {
                this.telephone = value;
            }
        }
        public string Email
        { get { return email; }
          set { this.email = value; }
        }
        public int Id_personne
        { get { return this.id_personne; }
          set {this.id_personne = value; } }
        public string Fax
        { get {return this.fax; }
          set { this.fax = value; }
        }
    }
}
