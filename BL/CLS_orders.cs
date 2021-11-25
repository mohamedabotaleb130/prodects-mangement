using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace prodects_mangement.BL
{
    class CLS_orders
    {
        public DataTable Get_List_OrdersID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selecdata("Get_List_OrdersID", null);
            DAL.Close();
            return Dt;
        }
        public DataTable Get_List_Orders_for_print()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selecdata("Get_List_Orders_for_print", null);
            DAL.Close();
            return Dt;
        }

        public DataTable GetOrderDETALIS(int ID_Order)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_Order", SqlDbType.Int);
            param[0].Value = ID_Order;

            Dt = DAL.selecdata("GetOrderDETALIS", param);
            DAL.Close();
            return Dt;
        }
        public void Add_Orders( int ID_Order, DateTime Data_Order , int Customer_ID,
                                  string Discription_Orders, string salesMan)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_Order", SqlDbType.Int);
            param[0].Value = ID_Order;

            param[1] = new SqlParameter("@Data_Order", SqlDbType.DateTime);
            param[1].Value = Data_Order;

            param[2] = new SqlParameter("@Customer_ID", SqlDbType.Int);
            param[2].Value = Customer_ID;

            param[3] = new SqlParameter("@Discription_Orders", SqlDbType.VarChar,(300));
            param[3].Value = Discription_Orders;

            param[4] = new SqlParameter("@salesMan", SqlDbType.VarChar,(300));
            param[4].Value = salesMan;

            
            DAL.ExecuteCommand("Add_Orders", param);
            DAL.Close();
        }



        public DataTable Verifyqty(string ID_PRODUCT,int Qty_Enter)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // DAL.Open();

            DataTable Dt = new DataTable();

            SqlParameter[] pram = new SqlParameter[2];
            pram[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 50);
            pram[0].Value = ID_PRODUCT;
            pram[1] = new SqlParameter("@Qty_Enter", SqlDbType.Int);
            pram[1].Value = Qty_Enter;
            Dt = DAL.selecdata("Verifyqty", pram);
            DAL.Close();
            return Dt;


        }

    }




}
