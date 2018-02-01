using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //{}
    public class ContactManager
    {
        public static void Add(int id)
        {
            ContactService.Add(id);
        }
        public static void Delete(int id)
        {
            ContactService.Delete(id);
        }

    }
}
