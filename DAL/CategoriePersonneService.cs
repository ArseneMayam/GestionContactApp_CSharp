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
    class CategoriePersonneService
    {
        public static List<CategoriePersonne> GetAll()
        {
            List<CategoriePersonne> liste = null;
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"select * from categoriePersonne";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        liste = new List<CategoriePersonne>();
                        while (reader.Read())
                        {
                            CategoriePersonne a = new CategoriePersonne();
                            a.Id = reader.GetInt32(0);
                            a.Titre = reader.GetString(1);
                            a.Id_personne = reader.GetInt32(2);
                            liste.Add(a);
                        }
                    }
                }
            }
            return liste;
        }
        internal static void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from categoriePersonne where id = '@Id'";
                    cmd.Parameters.Add(new SqlParameter("@Id", id));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        internal static void add(CategoriePersonne c)
        {
        }
    }
}
