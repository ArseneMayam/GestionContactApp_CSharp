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
    public class ProfessionManager
    {
        public static List<Profession> GetAll()
        {
            return ProfessionService.GetAll();   
        }
        public static void Edit(Profession p)
        {
            ProfessionService.Edit(p);
        }
        public static void Delete(int id)
        {
            ProfessionService.Delete(id);
        }
        public static void Add(Profession p)
        {
            ProfessionService.Add(p);
        }
    }
}
