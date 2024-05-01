using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDb
{
    internal class MobileOperations
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        
        //in this method opening connection with data base
        // and command to insert data adding mobile data
        //executeing it
        public string addMobile(MobileModal mobileModal)
        {
            try
            {
            con = new SqlConnection("Data Source=QUAL-LT2B6ZT04\\SQLEXPRESS;Initial Catalog=MobileDb;Integrated Security=True;");
            con.Open();
            cmd = new SqlCommand($"INSERT INTO mobileInfo VALUES(@MobileId,@MobileName,@MobilePrice)  ", con);
            cmd.Parameters.AddWithValue("@MobileId",mobileModal.MobileId);
            cmd.Parameters.AddWithValue("@MobileName",mobileModal.MobileName);
            cmd.Parameters.AddWithValue("@MobilePrice",mobileModal.MobilePrice);
            cmd.ExecuteNonQuery();
            con.Close();
            }
            catch( SqlException ex) { 
             return ex.Message ;
            }
            return "added mobile sucessfully";
        }

        //by id fetch a record from database
        //using modal class store and return modal 
        //class
        public MobileModal displaySingleMobile(int mobileid)
        {
            con = new SqlConnection("Data Source=QUAL-LT2B6ZT04\\SQLEXPRESS;Initial Catalog=MobileDb;Integrated Security=True;");
            con.Open();

            cmd = new SqlCommand($"SELECT * FROM mobileInfo WHERE mobid = @MobileId", con);
            cmd.Parameters.AddWithValue("@MobileId", mobileid);
            dr = cmd.ExecuteReader();
            MobileModal mobileModal = new MobileModal();
            if (dr.Read())
            { 
                mobileModal.MobileId = dr.GetInt32(0);
                mobileModal.MobileName= dr.GetString(1);
                mobileModal.MobilePrice=dr.GetDecimal(2);
                return mobileModal;
            }
          
            dr.Close();
            con.Close();
            return null;
        }

        // in thisusing user input id deleting record from database
        public string deleteMobile(int id)
        {
            con = new SqlConnection("Data Source=QUAL-LT2B6ZT04\\SQLEXPRESS;Initial Catalog=MobileDb;Integrated Security=True;");
            con.Open();
            cmd = new SqlCommand($"DELETE FROM mobileInfo WHERE mobid=@MobileId", con);
            cmd.Parameters.AddWithValue("@MobileId", id);
            int rowsAffected  = cmd.ExecuteNonQuery();  
            if (rowsAffected > 0)
            {
                return $"Mobile with id {id} has been deleted";
            }
            else {
                return $"no mobile found wiht id {id}";
            }

        }

        //Displayall method 
        //we don't know how many records get
        //so using list we store 
        //and using list we make strong type
        //and return list
        public List<MobileModal> DisplayAllMobile()
        {
            con = new SqlConnection("Data Source=QUAL-LT2B6ZT04\\SQLEXPRESS;Initial Catalog=MobileDb;Integrated Security=True;");
            con.Open();

            cmd = new SqlCommand($"SELECT * FROM mobileInfo", con);
            dr = cmd.ExecuteReader();
            // Create a list to store the MobileModal objects
            List<MobileModal> mobileList = new List<MobileModal>();
            while (dr.Read())
            {
               MobileModal mobileModal = new MobileModal
                {
                    MobileId = dr.GetInt32(0),
                    MobileName = dr.GetString(1),
                    MobilePrice = dr.GetDecimal(2),
                };
                mobileList.Add(mobileModal);
            }

            dr.Close();
            con.Close();
            return mobileList;
           
        }

        // in this method using id updating mobile details
        public string UpdateMobileDetails(int id,MobileModal mobile)
        {
            con = new SqlConnection("Data Source=QUAL-LT2B6ZT04\\SQLEXPRESS;Initial Catalog=MobileDb;Integrated Security=True;");
            con.Open();
            cmd = new SqlCommand($"UPDATE mobileInfo SET mobname =@MobileName,mobprice=@MobilePrice WHERE mobid=@MobileId", con);
            cmd.Parameters.AddWithValue("@MobileId", id);
            cmd.Parameters.AddWithValue("@MobileName",mobile.MobileName);
            cmd.Parameters.AddWithValue("@MobilePrice", mobile.MobilePrice);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                return $"Mobile with id {id} has been updated";
            }
            else
            {
                return $"no mobile found with id {id}";
            }
        }

    }




    }

      