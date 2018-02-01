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
        public static void Edit(Profession p)
        {
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE profession SET titre ='@Titre', nomEntreprise='@NomEntreprise', id_personne ='@Id_Personne' WHERE id ='@Id'";
                    cmd.Parameters.AddWithValue("@Titre",p.Titre);
                    cmd.Parameters.AddWithValue("@NomEntreprise", p.NomEntreprise);
                    cmd.Parameters.AddWithValue("@Id_Personne", p.Id_personne);
                    cmd.ExecuteNonQuery();
                }
            }
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
                    cmd.CommandText = "delete from profession where id = '@Id'";
                    cmd.Parameters.Add(new SqlParameter("@Id", id));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void Add(Profession p)
        {
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into profession(titre, nomEntreprise, id_personne)" +
                        "values('@Titre', '@NomEntreprise', '@Id_personne')";
                    cmd.Parameters.AddWithValue("@Titre", p.Titre);
                    cmd.Parameters.AddWithValue("@NomEntreprise", p.NomEntreprise);
                    cmd.Parameters.AddWithValue("@Id_personne", p.Id_personne);
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
