using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prodects_mangement.BL
{
    class cls_prodect
    {
        public DataTable Get_ALL_Categres()
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // DAL.Open();

            DataTable Dt = new DataTable();
            Dt = DAL.selecdata("Get_ALL_Categres", null);
            DAL.Close();
            return Dt;


        }

        


        public void ADD_Prodect(int ID_CAT, string LABEL_PRODUCl, string ID_PRODUCT,
                                 int QTE_IN_STOCK, string Price, byte[] imag) 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Id_CAt", SqlDbType.NVarChar, (10000));
            param[0].Value =ID_CAT;

            param[1] = new SqlParameter("@ID_Price", SqlDbType.VarChar,50);
            param[1].Value = Price;

            param[2] = new SqlParameter("@Image", SqlDbType.Image);
            param[2].Value = imag;

            param[3] = new SqlParameter("@QTE", SqlDbType.NVarChar,(10000));
            param[3].Value = QTE_IN_STOCK;

            param[4] = new SqlParameter("@label", SqlDbType.VarChar,(50));
            param[4].Value = LABEL_PRODUCl;

            param[5] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, (50));
            param[5].Value = ID_PRODUCT;


            DAL.ExecuteCommand("ADD_PRODUCT", param);
            DAL.Close();
        }

        public DataTable verifyproductID(string ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // DAL.Open();

            DataTable Dt = new DataTable();

            SqlParameter[] pram = new SqlParameter[1];
            pram[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            pram[0].Value = ID;
            Dt = DAL.selecdata("verifyproductID", pram);
            DAL.Close();
            return Dt;


        }
        public DataTable Get_aLL_prodects()
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // DAL.Open();

            DataTable Dt = new DataTable();
            Dt = DAL.selecdata("Get_aLL_prodects", null);
            DAL.Close();
            return Dt;


        }

        public DataTable Searchproducts(string ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // DAL.Open();

            DataTable Dt = new DataTable();

            SqlParameter[] pram = new SqlParameter[1];
            pram[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            pram[0].Value = ID;
            Dt = DAL.selecdata("Searchproducts   ", pram);
            DAL.Close();
            return Dt;


        }


        public DataTable Get_image_products(string ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // DAL.Open();

            DataTable Dt = new DataTable();

            SqlParameter[] pram = new SqlParameter[1];
            pram[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            pram[0].Value = ID;
            Dt = DAL.selecdata("Get_image_product   ", pram);
            DAL.Close();
            return Dt;


        }
        public void deleteprodect(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = ID;

            
            DAL.ExecuteCommand("deleteprodect", param);
            DAL.Close();
        }

        public void UPDATA_prodect(int ID_CAT, string LABEL_PRODUCl, string ID_PRODUCT,
                                 int QTE_IN_STOCK, string Price, byte[] imag)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Id_CAt", SqlDbType.NVarChar, (10000));
            param[0].Value = ID_CAT;

            param[1] = new SqlParameter("@ID_Price", SqlDbType.VarChar, 50);
            param[1].Value = Price;

            param[2] = new SqlParameter("@Image", SqlDbType.Image);
            param[2].Value = imag;

            param[3] = new SqlParameter("@QTE", SqlDbType.NVarChar, (10000));
            param[3].Value = QTE_IN_STOCK;

            param[4] = new SqlParameter("@label", SqlDbType.VarChar, (50));
            param[4].Value = LABEL_PRODUCl;

            param[5] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, (50));
            param[5].Value = ID_PRODUCT;


            DAL.ExecuteCommand("UPDATA_prodect", param);
            DAL.Close();
        }

    }
}