using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileCrudDb
{
    internal class MobileOperations
    {
       SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        string sqltext = "Data Source=QUAL-LT2B6ZT04\\SQLEXPRESS;Initial Catalog=MobileDb;Integrated Security=True;";

        //insert delete update
        public string ActionOperation(string sqlcommand)
        {
            try
            { 
            con = new SqlConnection(sqltext);
            con.Open();
            cmd = new SqlCommand(sqlcommand, con);
           int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    return $"{rowAffected} row affected";
                }
                else
                {
                    return"not rows affected";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            con.Close();
            
        }

        //select
        public List<MobileModal> nonActionOperation(string sqlcommand)
        {
            con = new SqlConnection(sqltext);
            con.Open();
            cmd = new SqlCommand(sqlcommand,con);
            reader = cmd.ExecuteReader();
            List<MobileModal> mobiles = new List<MobileModal>();
            while(reader.Read())
            {
                MobileModal mobileModal = new MobileModal
                {
                    MobileId = reader.GetInt32(0),
                    MobileName = reader.GetString(1),
                    MobilePrice = reader.GetDecimal(2),

                };
                mobiles.Add(mobileModal);
            }
            return mobiles;


        }
    }
}
