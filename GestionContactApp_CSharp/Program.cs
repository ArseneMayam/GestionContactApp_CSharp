using BLL;
using EntitiesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionContactApp_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" TEST GETALL");
            List<Personne> liste = new List<Personne>();
            liste = PersonneManager.GetAll();
            foreach(Personne p in liste)
            {

                Console.WriteLine("Nom : " + p.Nom);
                Console.WriteLine("Prenom : " + p.Prenom);
                Console.WriteLine("Categorie : " + p.Categorie.Titre);
                Console.WriteLine("Profession : " + p.Profession.Titre);

                Console.WriteLine("--------------");
            }
            List<Personne> listePersonne = new List<Personne>();
            listePersonne = PersonneManager.GetAllPersonne();
            Personne dernier = listePersonne.Last();
            Console.WriteLine("last person name "+dernier.Nom);
            Console.WriteLine("last person id " + dernier.Id);
            int id_personne = dernier.Id + 1;
            Console.WriteLine("id personne " + id_personne);
            // test supprimer 
          //  PersonneManager.Delete(8);
           // test add contact
         /*  Personne newPersonne = new Personne(id_personne, "Paul", "Delarue", 26,
               new Contact(id_personne, id_personne), 
               new Profession(id_personne, "devops", "IDM", id_personne),
               new CategoriePersonne(id_personne,"Travail", id_personne), 
               new Coordonnees(id_personne, "555-1762-862","aaa","jean@yahoo.com", id_personne),
               new Adresse(id_personne,"mouton duvernet","75014","Paris","France", id_personne));


            // AJOUT
            PersonneManager.Add(newPersonne);
            */
           




            /*
            Console.WriteLine("*****************************");
            Console.WriteLine(" TEST GETBY Ville ");
            List<Personne> parVille = new List<Personne>();
            parVille = PersonneManager.GetByVille("Amsterdam");
            Console.WriteLine(" taille tab : "+ parVille.Count);
            foreach (Personne pA in parVille)
            {

                Console.WriteLine("Nom : " + pA.Nom);
                Console.WriteLine("Prenom : " + pA.Prenom);
                Console.WriteLine("Categorie : " + pA.Categorie.Titre);
                Console.WriteLine("Profession : " + pA.Profession.Titre);

                Console.WriteLine("--------------");
            }/*
            Console.WriteLine(" TEST GETBY Pays");
            List<Personne> parPays = new List<Personne>();
            parPays = PersonneManager.GetByPays("Canada");
            Console.WriteLine(" taille tab : " + parPays.Count);
            foreach (Personne pA in parPays)
            {

                Console.WriteLine("Nom : " + pA.Nom);
                Console.WriteLine("Prenom : " + pA.Prenom);
                Console.WriteLine("Categorie : " + pA.Categorie.Titre);
                Console.WriteLine("Profession : " + pA.Profession.Titre);

                Console.WriteLine("--------------");
            }
            Console.WriteLine(" TEST GETBY NOm");
            List<Personne> parNom = new List<Personne>();
            parNom = PersonneManager.GetByName("Vauban");
            Console.WriteLine(" taille tab : " + parNom.Count);
            foreach (Personne pA in parNom)
            {

                Console.WriteLine("Nom : " + pA.Nom);
                Console.WriteLine("Prenom : " + pA.Prenom);
                Console.WriteLine("Ville : " + pA.Adresse.Ville);

                Console.WriteLine("Categorie : " + pA.Categorie.Titre);
                Console.WriteLine("Profession : " + pA.Profession.Titre);
                Console.WriteLine("Profession id : " + pA.Profession.Id);
                Console.WriteLine("Profession id_pers : " + pA.Profession.Id_personne);



                Console.WriteLine("--------------");
            }
            
           Personne aModifier = parNom.ElementAt(0);
            Console.WriteLine("Nom : " + aModifier.Nom);
            Console.WriteLine("Prenom : " + aModifier.Prenom);
            Console.WriteLine("Categorie : " + aModifier.Categorie.Titre);
            Console.WriteLine("Profession : " + aModifier.Profession.Titre);
            Console.WriteLine("Profession id : " + aModifier.Profession.Id);
            Console.WriteLine("Profession id_pers : " + aModifier.Profession.Id_personne);



           // aModifier.Nom = "Vauban";
            // Console.WriteLine("nom " + aModifier.Nom);

            // aModifier.Profession.Titre = "developpeur";
           // aModifier.Adresse.Ville = "Quebec";
            // Console.WriteLine("profession " + aModifier.Profession.Titre);
          // PersonneManager.Edit(aModifier);
          */


        }
    }
}
