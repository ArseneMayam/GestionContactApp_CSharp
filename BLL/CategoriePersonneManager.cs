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
    public class CategoriePersonneManager
    {
        public static List<CategoriePersonne> GetAll()
        {
            return CategoriePersonneService.GetAll();
        }
        public static void Delete(int id)
        {
            CategoriePersonneService.Delete(id);
        }
        public static void add(CategoriePersonne c)
        {
            CategoriePersonneService.add(c);
        }

    }
}
