using DAL;
using EntitiesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //{}
    public class PersonneManager
    {
        public static List<Personne> GetAll()
        {
            return PersonneService.GetAll();
        }
        public static List<Personne> GetByVille(string ville)
        {
            return PersonneService.GetByVille(ville);
        }
        public static List<Personne> GetByPays(string pays)
        {
            return PersonneService.GetByPays(pays);
        }
        public static List<Personne> GetByName(string nom)
        {
            return PersonneService.GetByName(nom);
        }
        public static List<Personne> GetByFname(string prenom) {
            return PersonneService.GetByFname(prenom);
        }
        public static void Edit(Personne p)
        {
            PersonneService.Edit(p);
        }
        public static void Delete(int id)
        {
            PersonneService.Delete(id);
        }
        public static void Add(Personne p)
        {
            PersonneService.Add(p);
        }
        public static List<Personne> GetAllPersonne()
        {
           return PersonneService.GetAllPersonne();
        }

    }
}
