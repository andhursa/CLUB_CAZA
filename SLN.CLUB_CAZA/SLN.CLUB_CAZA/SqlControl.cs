using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SLN.CLUB_CAZA
{
    class SqlControl
    {    
      
        SqlConnection connet = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString);

        public int Login(string Usuario, string Password)
        {                        
           
            try
            {
                connet.Open();
                SqlCommand cmd = new SqlCommand("spLogin", connet);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Password", Password);

                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read()) 
                {
                    return dr.GetInt32(0);                
                }
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }
            finally 
            { 
                connet.Close(); 
            }

            return -1;
        }
      
    }
}
