using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Take_Away.BL
{
    class CS_Sales
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region ///////////////////Sales Items/////////////////////////////////

        //SalesItems_View
        public DataTable SalesItems_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SalesItems_View", null);
            return Dt;
        }
        //SalesItems_View_Imge
        public DataTable SalesItems_View_Imge(int SequentialID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] pram = new SqlParameter[1];
            pram[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            pram[0].Value = SequentialID;
            dt = DAL.SelectData("SalesItems_View_Imge", pram);
            DAL.Close();
            return dt;
        }
        //SalesItems_Add
        public void SalesItems_Add(int ItemBarcode,
                                   int BoxBarcode,
                                   string ItemName,
                                   int CategoryID,
                                   int UnitID,
                                   decimal PriceWidget,
                                   decimal PriceBox,
                                   decimal priceWholesale,
                                   decimal priceWholesale2,
                                   byte[]  ItemImage,
                                   char Stocktaking,
                                   char ChangePrice,
                                   char QuickMenu
            )
        {
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@ItemBarcode", SqlDbType.Int);
            param[0].Value = ItemBarcode;

            param[1] = new SqlParameter("@BoxBarcode", SqlDbType.Int);
            param[1].Value = BoxBarcode;

            param[2] = new SqlParameter("@ItemName", SqlDbType.NVarChar, 50);
            param[2].Value = ItemName;

            param[3] = new SqlParameter("@CategoryID", SqlDbType.Int);
            param[3].Value = CategoryID;

            param[4] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[4].Value = UnitID;

            param[5] = new SqlParameter("@PriceWidget", SqlDbType.Money);
            param[5].Value = PriceWidget;

            param[6] = new SqlParameter("@PriceBox", SqlDbType.Money);
            param[6].Value = PriceBox;

            param[7] = new SqlParameter("@priceWholesale", SqlDbType.Money);
            param[7].Value = priceWholesale;

            param[8] = new SqlParameter("@priceWholesale2", SqlDbType.Money);
            param[8].Value = priceWholesale2;

            param[9] = new SqlParameter("@ItemImage", SqlDbType.Image);
            param[9].Value = ItemImage;

            param[10] = new SqlParameter("@Stocktaking", SqlDbType.Char);
            param[10].Value = Stocktaking;

            param[11] = new SqlParameter("@ChangePrice", SqlDbType.Char);
            param[11].Value = ChangePrice;

            param[12] = new SqlParameter("@QuickMenu", SqlDbType.Char);
            param[12].Value = QuickMenu;

            DAL.ExecuteCommand("SalesItems_Add", param);
        }
        //SalesItems_Edit()
        public void SalesItems_Edit(int SequentialID,
                           int ItemBarcode,
                           int BoxBarcode,
                           string ItemName,
                           int CategoryID,
                           int UnitID,
                           decimal PriceWidget,
                           decimal PriceBox,
                           decimal priceWholesale,
                           decimal priceWholesale2,
                           byte[] ItemImage,
                           char Stocktaking,
                           char ChangePrice,
                           char QuickMenu
    )
        {
            SqlParameter[] param = new SqlParameter[14];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@ItemBarcode", SqlDbType.Int);
            param[1].Value = ItemBarcode;

            param[2] = new SqlParameter("@BoxBarcode", SqlDbType.Int);
            param[2].Value = BoxBarcode;

            param[3] = new SqlParameter("@ItemName", SqlDbType.NVarChar, 50);
            param[3].Value = ItemName;

            param[4] = new SqlParameter("@CategoryID", SqlDbType.Int);
            param[4].Value = CategoryID;

            param[5] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[5].Value = UnitID;

            param[6] = new SqlParameter("@PriceWidget", SqlDbType.Money);
            param[6].Value = PriceWidget;

            param[7] = new SqlParameter("@PriceBox", SqlDbType.Money);
            param[7].Value = PriceBox;

            param[8] = new SqlParameter("@priceWholesale", SqlDbType.Money);
            param[8].Value = priceWholesale;

            param[9] = new SqlParameter("@priceWholesale2", SqlDbType.Money);
            param[9].Value = priceWholesale2;

            param[10] = new SqlParameter("@ItemImage", SqlDbType.Image);
            param[10].Value = ItemImage;

            param[11] = new SqlParameter("@Stocktaking", SqlDbType.Char);
            param[11].Value = Stocktaking;

            param[12] = new SqlParameter("@ChangePrice", SqlDbType.Char);
            param[12].Value = ChangePrice;

            param[13] = new SqlParameter("@QuickMenu", SqlDbType.Char);
            param[13].Value = QuickMenu;

            DAL.ExecuteCommand("SalesItems_Add", param);
        }
        //SalesItems_Search()
        public DataTable SalesItems_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("SalesItems_Search", param);
            return Dt;
        }

        #endregion

        #region ///////////////////Sale Bill/////////////////////////////////
        //SalesBill_View
        public DataTable SalesBill_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SalesBill_View", null);
            return Dt;
        }

        //SalesBill_Add
        public void SalesBill_Add(int Bill_ID,
                                  int CustomerID,
                                  int EmployID,
                                  DateTime Time,
                                  DateTime Date,
                                  decimal BillTotal,
                                  char RegisterBill,
                                  char PaymentStatus,
                                  int CustomerType

                                  )
        {
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[1].Value = CustomerID;

            param[2] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[2].Value = EmployID;

            param[3] = new SqlParameter("@Time", SqlDbType.Time);
            param[3].Value = Time;

            param[4] = new SqlParameter("@Date", SqlDbType.Date);
            param[4].Value = Date;

            param[5] = new SqlParameter("@BillTotal", SqlDbType.Money);
            param[5].Value = BillTotal;

            param[6] = new SqlParameter("@RegisterBill", SqlDbType.Char);
            param[6].Value = RegisterBill;

            param[7] = new SqlParameter("@PaymentStatus", SqlDbType.Char);
            param[7].Value = PaymentStatus;

            param[8] = new SqlParameter("@CustomerType", SqlDbType.Int);
            param[8].Value = CustomerType;

            DAL.ExecuteCommand("SaleBill_Add", param);
        }

        //SalesBill_Edit
        public void SalesBill_Edit(int Bill_ID,
                          int CustomerID,
                          int EmployID,
                          DateTime Time,
                          DateTime Date,
                          decimal BillTotal,
                          char RegisterBill,
                          char PaymentStatus,
                          int CustomerType

                          )
        {
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[1].Value = CustomerID;

            param[2] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[2].Value = EmployID;

            param[3] = new SqlParameter("@Time", SqlDbType.Time);
            param[3].Value = Time;

            param[4] = new SqlParameter("@Date", SqlDbType.Date);
            param[4].Value = Date;

            param[5] = new SqlParameter("@BillTotal", SqlDbType.Money);
            param[5].Value = BillTotal;

            param[6] = new SqlParameter("@RegisterBill", SqlDbType.Char);
            param[6].Value = RegisterBill;

            param[7] = new SqlParameter("@PaymentStatus", SqlDbType.Char);
            param[7].Value = PaymentStatus;

            param[8] = new SqlParameter("@CustomerType", SqlDbType.Int);
            param[8].Value = CustomerType;

            DAL.ExecuteCommand("SalesBill_Edit", param);
        }
        //SalesBill_Search
        public DataTable SalesBill_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("SalesBill_Search", param);
            return Dt;
        }
        #endregion

        #region /////////////////// Details Sale Bill/////////////////////////////////
        //DetailsSaleBill_View
        public DataTable DetailsSaleBill_View(int SequentialID)
        {

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            Dt = DAL.SelectData("DetailsSaleBill_View", null);
            return Dt;
        }

        //DetailsSaleBill_Add
        public void DetailsSaleBill_Add(int Bill_ID,
                                  int ItemID,
                                  int UnitID,
                                  int Quantity,
                                  decimal BillTotal,
                                  int Discount
                                  )
        {
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[1].Value = ItemID;

            param[2] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[2].Value = UnitID;

            param[3] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[3].Value = Quantity;

            param[4] = new SqlParameter("@BillTotal", SqlDbType.Money);
            param[4].Value = BillTotal;

            param[5] = new SqlParameter("@Discount", SqlDbType.Int);
            param[5].Value = Discount;

            DAL.ExecuteCommand("DetailsSaleBill_Add", param);
        }

        //DetailsSaleBill_Edit
        public void DetailsSaleBill_Edit(
                                  int SequentialID,
                                  int Bill_ID,
                                  int ItemID,
                                  int UnitID,
                                  int Quantity,
                                  decimal BillTotal,
                                  int Discount
                                  )
        {
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[1].Value = Bill_ID;

            param[2] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[2].Value = ItemID;

            param[3] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[3].Value = UnitID;

            param[4] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[4].Value = Quantity;

            param[5] = new SqlParameter("@BillTotal", SqlDbType.Money);
            param[5].Value = BillTotal;

            param[6] = new SqlParameter("@Discount", SqlDbType.Int);
            param[6].Value = Discount;

            DAL.ExecuteCommand("DetailsSaleBill_Edit", param);
        }

        #endregion

        #region ///////////////////Temp Details Sale Bill/////////////////////////////////
        //TempDetailsSaleBill_View
        public DataTable TempDetailsSaleBill_View(int SequentialID)
        {

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            Dt = DAL.SelectData("TempDetailsSaleBill_View", null);
            return Dt;
        }

        //TempDetailsSaleBill_Add
        public void TempDetailsSaleBill_Add(int Bill_ID,
                                  int ItemID,
                                  int UnitID,
                                  int Quantity,
                                  decimal BillTotal,
                                  int Discount
                                  )
        {
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[1].Value = ItemID;

            param[2] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[2].Value = UnitID;

            param[3] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[3].Value = Quantity;

            param[4] = new SqlParameter("@BillTotal", SqlDbType.Money);
            param[4].Value = BillTotal;

            param[5] = new SqlParameter("@Discount", SqlDbType.Int);
            param[5].Value = Discount;

            DAL.ExecuteCommand("TempDetailsSaleBill_Add", param);
        }

        //TempDetailsSaleBill_Edit
        public void TempDetailsSaleBill_Edit(
                                  int SequentialID,
                                  int Bill_ID,
                                  int ItemID,
                                  int UnitID,
                                  int Quantity,
                                  decimal BillTotal,
                                  int Discount
                                  )
        {
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[1].Value = Bill_ID;

            param[2] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[2].Value = ItemID;

            param[3] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[3].Value = UnitID;

            param[4] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[4].Value = Quantity;

            param[5] = new SqlParameter("@BillTotal", SqlDbType.Money);
            param[5].Value = BillTotal;

            param[6] = new SqlParameter("@Discount", SqlDbType.Int);
            param[6].Value = Discount;

            DAL.ExecuteCommand("DetailsSaleBill_Edit", param);
        }


        //TempDetailsSaleBill_Delete
        public void TempDetailsSaleBill_Delete(int Bill_ID)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            DAL.ExecuteCommand("TempDetailsSaleBill_Delete", param);
        }
        #endregion

        #region ///////////////////Payment Details Sale/////////////////////////////////
        //PaymentDetailsSale_View
        public DataTable PaymentDetailsSale_View(int Bill_ID)
        {

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            Dt = DAL.SelectData("PaymentDetailsSale_View", null);
            return Dt;
        }

        //PaymentDetailsSale_Add
        public void PaymentDetailsSale_Add(int Bill_ID,
                                  int PaymentStyleNum,
                                  decimal Amount
                                  )
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@PaymentStyleNum", SqlDbType.Int);
            param[1].Value = PaymentStyleNum;

            param[2] = new SqlParameter("@Amount", SqlDbType.Money);
            param[2].Value = Amount;

            DAL.ExecuteCommand("PaymentDetailsSale_Add", param);
        }

        //PaymentDetailsSale_Edit
        public void PaymentDetailsSale_Edit(
                                  int SequentialID,
                                  int Bill_ID,
                                  int PaymentStyleNum,
                                  decimal Amount
                                  )
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[1].Value = Bill_ID;

            param[2] = new SqlParameter("@PaymentStyleNum ", SqlDbType.Int);
            param[2].Value = PaymentStyleNum;

            param[3] = new SqlParameter("@Amount", SqlDbType.Money);
            param[3].Value = Amount;

            DAL.ExecuteCommand("PaymentDetailsSale_Edit", param);
        }
        #endregion

        #region ///////////////////Return Sales/////////////////////////////////

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

            param[5] = new SqlParameter("@Note", SqlDbType.NVarChar, 120);
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

        #endregion


    }
}
