using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace prodects_mangement.DAL
{
    class DataAccessLayer
    {
        SqlConnection SqlConnection;

        // this constructor inisialize the connection object
        public DataAccessLayer()
        {
            SqlConnection = new SqlConnection("Server=DESKTOP-0PP6E48; Database=product_DB; Integrated Security=true");
        }

        //method to open the connection
        public void Open()
        {
            if (SqlConnection.State!=ConnectionState.Open)
            {
                SqlConnection.Open  ();
            }
            


        }
        //method to close the connection

        public void Close()
        {
            if (SqlConnection.State==ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        ///method to Read data  from Database
       


        public DataTable selecdata(string stored_procedur, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedur;
            sqlcmd.Connection = SqlConnection;  
            if (param != null)
            {
                for (int i = 0; i <param.Length ; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        ///method to INSERT,updata ,and Delet data  from Database

        public void ExecuteCommand (string stored_procedur,SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedur;
            sqlcmd.Connection = SqlConnection;

            if (param !=null)
            {
                sqlcmd.Parameters.AddRange(param);
                    
            }
            sqlcmd.ExecuteNonQuery();


        }







    }
}
