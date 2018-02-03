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
    public class ContactService
    {
        public static void Add(int id)
        {
            //string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into contact(id,id_personne)" +
                        "values(@Id,@Id_personne)";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Id_personne", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void Delete(int id)
        {
            //string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from contact where id = @Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
