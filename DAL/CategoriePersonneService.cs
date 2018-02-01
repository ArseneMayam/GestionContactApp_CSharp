using EntitiesLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //{}
    public class CategoriePersonneService
    {
        public static List<CategoriePersonne> GetAll()
        {
            List<CategoriePersonne> liste = null;
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
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
        public static void Delete(int id)
        {
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
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
        public static void add(CategoriePersonne c)
        {
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into categoriePersonne(titre, id_personne)"+
                        "values('@Titre', '@Id_personne')";
                    cmd.Parameters.AddWithValue("@Titre", c.Titre);
                    cmd.Parameters.AddWithValue("@Id_personne", c.Id_personne);
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
