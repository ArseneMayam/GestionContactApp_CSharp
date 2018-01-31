using EntitiesLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class CoordonneesService
    {
        public static List<Coordonnees> GetAll()
        {
            List<Coordonnees> liste = null;
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"select * from coordonnees";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        liste = new List<Coordonnees>();
                        while (reader.Read())
                        {
                            Coordonnees c = new Coordonnees();
                            c.Id = reader.GetInt32(0);
                            c.Telephone = reader.GetString(1);
                            c.Fax = reader.GetString(2);
                            c.Email = reader.GetString(3);
                            c.Id_personne = reader.GetInt32(4);
                            liste.Add(c);
                        }
                    }
                }
            }
            return liste;
        }
    }
}
