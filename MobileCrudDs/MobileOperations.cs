using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MobileCrudDs
{
    internal class MobileOperations
    {
        SqlConnection _connection;
        string connectionstring = "Data Source=QUAL-LT2B6ZT04\\SQLEXPRESS;Initial Catalog=MobileDb;Integrated Security=True;";
        SqlDataAdapter _adapter;

        //addmob taking mobileModal class as parameter
        //creating new filling with modal class
        public void addMob(MobileModal mobileModal)
        {
            try
            {

            _connection = new SqlConnection(connectionstring);
            DataSet ds = new DataSet();
            _adapter = new SqlDataAdapter("SELECT * FROM mobileInfo",_connection);
            _adapter.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow dr = dt.NewRow(); 
            dr[0]=mobileModal.MobileId;
            dr[1]=mobileModal.MobileName;
            dr[2] = mobileModal.MobilePrice;
            dt.Rows.Add(dr);
            SqlCommandBuilder cmd = new SqlCommandBuilder(_adapter);
            _adapter.Update(dt);

            }
            catch(SqlException ex)
            {
              throw ex;
            }
           
            
          
        }

        //updatemethod 
        public void UpdateMob(MobileModal mobileModal)
        {
            try
            {

            _connection = new SqlConnection(connectionstring);
            DataSet ds = new DataSet();
            _adapter = new SqlDataAdapter("SELECT * FROM mobileInfo", _connection);
            _adapter.Fill(ds);
          
            DataTable dt =ds.Tables[0];
            
            DataRow dr = dt.Select("mobid="+mobileModal.MobileId)[0];
            if (dr != null)
            {
            dr[1] = mobileModal.MobileName;
            dr[2] = mobileModal.MobilePrice;
            }
         
            SqlCommandBuilder cmd = new SqlCommandBuilder(_adapter);
            _adapter.Update(dt);

            }
            catch (SqlException ex) { 
             throw ex;
            }
        }

        //delete method
        //using delete in built method in datarow deleting row
        public void DeletMob(int mob)
        {
            try
            {

            _connection = new SqlConnection(connectionstring);
            DataSet ds = new DataSet();
            _adapter = new SqlDataAdapter("SELECT * FROM mobileInfo", _connection);
            _adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            DataRow dr = dt.Select("mobid=" + mob)[0];
            dr.Delete();
            SqlCommandBuilder cmd = new SqlCommandBuilder(_adapter);
            _adapter.Update(dt);

            }
            catch(SqlException ex) { throw ex; }
        }

        //displayall method
        //return dataset
        public DataSet DisplayAllMob()
        {
            try
            {

            _connection = new SqlConnection(connectionstring);
            DataSet ds = new DataSet();
            _adapter = new SqlDataAdapter("SELECT * FROM mobileInfo", _connection);
            _adapter.Fill(ds);
            return ds;
            }
            catch(SqlException ex) {throw ex; }

        }

        // display single record
        //using id select from data row and return it
        public DataRow DisplayMobile(int mobid)
        {
            try
            {

            _connection = new SqlConnection(connectionstring);
            DataSet ds = new DataSet();
            _adapter = new SqlDataAdapter("SELECT * FROM mobileInfo", _connection);
            _adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            DataRow dr = dt.Select("mobid=" + mobid)[0];
            if (dr != null)
            {
                return dr;
            }
            SqlCommandBuilder cmd = new SqlCommandBuilder(_adapter);
            _adapter.Update(dt);

                return dr;
            }
            catch (SqlException ex) { throw ex; }
        }
    }
}
