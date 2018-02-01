using DAL;
using EntitiesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdresseManager
    {
        // {}
        public static List<Adresse> GetAll()
        {
            return AdresseService.GetAll(); 
        }
        public static void Edit(Adresse a)
        {
            AdresseService.Edit(a);
        }
        public static void Delete(int id)
        {
            AdresseService.Delete(id);
        }
        public static void Add(Adresse a)
        {
            AdresseService.Add(a);
        }
    }
}
