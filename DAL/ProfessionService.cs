using EntitiesLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ProfessionService
    {
        public static List<Profession> GetAll()
        {
            List<Profession> liste = null;
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"select * from profession";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        liste = new List<Profession>();
                        while (reader.Read())
                        {
                        }
                    }
                }
            }
            return liste;
        }
    }
}
