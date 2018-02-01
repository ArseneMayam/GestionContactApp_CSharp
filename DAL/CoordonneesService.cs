using EntitiesLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //{}
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
        public static void Add(Coordonnees c)
        {

        }
        public static void Edit(Coordonnees c)
        {
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE coordonnees SET telephone ='@Telephone', fax='@Fax', email='@Email', id_personne ='@Id_Personne' WHERE id ='@Id'";
                    cmd.Parameters.AddWithValue("@Telephone",c.Telephone);
                    cmd.Parameters.AddWithValue("@Fax", c.Fax);
                    cmd.Parameters.AddWithValue("@Email", c.Email);
                    cmd.Parameters.AddWithValue("@Id_Personne", c.Id_personne);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from coordonnees where id = '@Id'";
                    cmd.Parameters.Add(new SqlParameter("@Id", id));
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
