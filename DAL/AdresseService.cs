using System;
using EntitiesLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    // {}
    class AdresseService
    {
        public static List<Adresse> GetAll()
        {
            List<Adresse> liste = null;
            //string connectStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString; ;
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText =@"select * from adresse";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        liste = new List<Adresse>();
                        while(reader.Read())
                        {
                            Adresse a = new Adresse();
                            a.Id = reader.GetInt32(0);
                            a.Rue = reader.GetString(1);
                            a.CodePostal = reader.GetString(2);
                            a.Ville = reader.GetString(3);
                            a.Pays = reader.GetString(4);
                            liste.Add(a);
                        }
                    }
                }
            }

            return liste;
        }
        public static void Edit(Adresse a)
        {
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE adresse SET rue ='@Rue', code_postal='@CodePostal',ville='@Ville', pays ='@Pays', id_personne ='@Id_Personne' WHERE id ='@Id'";
                    cmd.Parameters.AddWithValue("@Rue", a.Rue);
                    cmd.Parameters.AddWithValue("@CodePostal", a.CodePostal);
                    cmd.Parameters.AddWithValue("@Ville", a.Ville);
                    cmd.Parameters.AddWithValue("@Pays", a.Pays);
                    cmd.Parameters.AddWithValue("@Id_Personne", a.Id_personne);
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
                    cmd.CommandText = "delete from adresse where id = '@Id'";
                    cmd.Parameters.Add(new SqlParameter("@Id", id));
                    cmd.ExecuteNonQuery();

                }
            }
        }

    }
}
