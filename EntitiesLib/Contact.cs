using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    class Contact
    {
        private int id;
        private int id_personne;
        private Personne personne;

        public Contact() { }

        public Contact(int id, int id_personne, Personne personne)
        {
            this.id = id;
            this.id_personne = id_personne;
            this.personne = personne;
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
