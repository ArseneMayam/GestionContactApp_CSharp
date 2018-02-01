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
    public class CoordonneesManager
    {
        public static List<Coordonnees> GetAll()
        {
            return CoordonneesService.GetAll();
        }
        public static void Add(Coordonnees c)
        {
            CoordonneesService.Add(c);
        }
        public static void Edit(Coordonnees c)
        {
            CoordonneesService.Edit(c);
        }
        public static void Delete(int id)
        {
            CoordonneesService.Delete(id);
        }
    }
}
