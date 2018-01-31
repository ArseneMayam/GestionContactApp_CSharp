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
    class AdresseService
    {
       // Adresse a = new EntitiesLib.Adresse()
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
     
    }
}
