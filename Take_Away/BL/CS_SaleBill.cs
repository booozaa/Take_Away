using System;
using System.Data;
using System.Data.SqlClient;
namespace Take_Away.BL
{
    class CS_SaleBill
    {
        DataAccessLayer DAL = new DataAccessLayer();

        ///////////////////Return Sales/////////////////////////////////

        //ReturnSales_Single_View
        public DataTable ReturnSales_Single_View(int Bill_ID)
        {

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            Dt = DAL.SelectData("ReturnSales_Single_View", null);
            return Dt;
        }


        //ReturnSales_View
        public DataTable ReturnSales_View()
        {

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("ReturnSales_View", null);
            return Dt;
        }

        //ReturnSales_Add
        public void ReturnSales_Add(int Bill_ID,
                                  int ItemID,
                                  int EmployID,
                                  DateTime Date,
                                  DateTime Time,
                                  string Note
                                  )
        {
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[1].Value = ItemID;

            param[2] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[2].Value = EmployID;

            param[3] = new SqlParameter("@Date", SqlDbType.Date);
            param[3].Value = Date;

            param[4] = new SqlParameter("@Time", SqlDbType.Time);
            param[4].Value = Time;

            param[5] = new SqlParameter("@Note", SqlDbType.NVarChar,120);
            param[5].Value = Note;

            DAL.ExecuteCommand("ReturnSales_Add", param);
        }
        //ReturnSales_Edit
        public void ReturnSales_Edit(int SequentialID,
                                  int Bill_ID,
                                  int ItemID,
                                  int EmployID,
                                  DateTime Date,
                                  DateTime Time,
                                  string Note
                                  )
        {
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[1].Value = Bill_ID;

            param[2] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[2].Value = ItemID;

            param[3] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[3].Value = EmployID;

            param[4] = new SqlParameter("@Date", SqlDbType.Date);
            param[4].Value = Date;

            param[5] = new SqlParameter("@Time", SqlDbType.Time);
            param[5].Value = Time;

            param[6] = new SqlParameter("@Note", SqlDbType.NVarChar, 120);
            param[6].Value = Note;

            DAL.ExecuteCommand("ReturnSales_Edit", param);
        }


        //ReturnSales_Search
        public DataTable ReturnSales_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("ReturnSales_Search", param);
            return Dt;
        }

    }
}
