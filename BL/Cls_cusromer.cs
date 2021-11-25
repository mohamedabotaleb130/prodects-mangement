using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace prodects_mangement.BL
{
    class Cls_cusromer
    {


        public void ADD_customer(string First_Name, string Last_Name, string Telphon,
                                 string Email, byte[] Picture, string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@First_Name", SqlDbType.NVarChar, (100));
            param[0].Value = First_Name;

            param[1] = new SqlParameter("@Last_Name", SqlDbType.NVarChar, (100));
            param[1].Value = Last_Name;

            param[2] = new SqlParameter("@Telphon", SqlDbType.NVarChar, (100));
            param[2].Value = Telphon;

            param[3] = new SqlParameter("@Email", SqlDbType.NVarChar, (100));
            param[3].Value = Email;

            param[4] = new SqlParameter("@Picture", SqlDbType.Image);
            param[4].Value = Picture;

            param[5] = new SqlParameter("@Criterion", SqlDbType.NVarChar, (100));
            param[5].Value = Criterion;
            DAL.ExecuteCommand("ADD_customer", param);
            DAL.Close();
        }
        public DataTable GET_Allcustomer()
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // DAL.Open();

            DataTable Dt = new DataTable();
            Dt = DAL.selecdata("GET_Allcustomer", null);
            DAL.Close();
            return Dt;

        }
        public void Edit_customer(string First_Name, string Last_Name, string Telphon,
                                string Email, byte[] Picture, string Criterion, int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@First_Name", SqlDbType.NVarChar, (100));
            param[0].Value = First_Name;

            param[1] = new SqlParameter("@Last_Name", SqlDbType.NVarChar, (100));
            param[1].Value = Last_Name;

            param[2] = new SqlParameter("@Telphon", SqlDbType.NVarChar, (100));
            param[2].Value = Telphon;

            param[3] = new SqlParameter("@Email", SqlDbType.NVarChar, (100));
            param[3].Value = Email;

            param[4] = new SqlParameter("@Picture", SqlDbType.Image);
            param[4].Value = Picture;

            param[5] = new SqlParameter("@Criterion", SqlDbType.NVarChar, (100));
            param[5].Value = Criterion;

            param[6] = new SqlParameter("@ID", SqlDbType.Int);
            param[6].Value = ID;

            DAL.ExecuteCommand("Edit_customer", param);
            DAL.Close();
        }

        public void Delete_cutomer(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];



            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delete_cutomer", param);
            DAL.Close();
        }
        public DataTable Search_customer(string criterion)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // DAL.Open();

            DataTable Dt = new DataTable();
            SqlParameter[] prm=new SqlParameter[1];
            prm[0] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            prm[0].Value = criterion;
            Dt = DAL.selecdata("Search_customer", prm);
            DAL.Close();
            return Dt;

        }

    }
}

    