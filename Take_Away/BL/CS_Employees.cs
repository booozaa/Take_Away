using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Employees
    {
        DataAccessLayer DAL = new DataAccessLayer();

        ///////////////////Employees/////////////////////////////////

        //Employees_View
        public DataTable Employees_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Employees_View", null);
            return Dt;
        }
        //Employees_Add()
        public void Employees_Add(string EmployName,int JobID,DateTime DirectlyDate,int NationalityID
                                 ,string EmployAddress,int EmployPhone,char Gender,char AccountStatus)
        {
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@EmployName", SqlDbType.NVarChar,55);
            param[0].Value = EmployName;

            param[1] = new SqlParameter("@JobID", SqlDbType.Int);
            param[1].Value = JobID;

            param[2] = new SqlParameter("@DirectlyDate", SqlDbType.Date);
            param[2].Value = DirectlyDate;

            param[3] = new SqlParameter("@NationalityID", SqlDbType.Int);
            param[3].Value = NationalityID;

            param[4] = new SqlParameter("@EmployAddress", SqlDbType.NVarChar,50);
            param[4].Value = EmployAddress;

            param[5] = new SqlParameter("@EmployPhone", SqlDbType.Int);
            param[5].Value = EmployPhone;

            param[6] = new SqlParameter("@Gendere", SqlDbType.Char);
            param[6].Value = Gender;

            param[7] = new SqlParameter("@AccountStatus", SqlDbType.Char);
            param[7].Value = AccountStatus;

            DAL.ExecuteCommand("Employees_Add", param);
        }
        //Employees_Edit()
        public void Employees_Edit(int EmployID, string EmployName, int JobID, DateTime DirectlyDate, int NationalityID
                                 , string EmployAddress, int EmployPhone, char Gender, char AccountStatus)
        {
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[0].Value = EmployID;

            param[1] = new SqlParameter("@EmployName", SqlDbType.NVarChar, 55);
            param[1].Value = EmployName;

            param[2] = new SqlParameter("@JobID", SqlDbType.Int);
            param[2].Value = JobID;

            param[3] = new SqlParameter("@DirectlyDate", SqlDbType.Date);
            param[3].Value = DirectlyDate;

            param[4] = new SqlParameter("@NationalityID", SqlDbType.Int);
            param[4].Value = NationalityID;

            param[5] = new SqlParameter("@EmployAddress", SqlDbType.NVarChar, 50);
            param[5].Value = EmployAddress;

            param[6] = new SqlParameter("@EmployPhone", SqlDbType.Int);
            param[6].Value = EmployPhone;

            param[7] = new SqlParameter("@Gendere", SqlDbType.Char);
            param[7].Value = Gender;

            param[8] = new SqlParameter("@AccountStatus", SqlDbType.Char);
            param[8].Value = AccountStatus;

            DAL.ExecuteCommand("Employees_Edit", param);
        }
        //Employees_Search()
        public DataTable Employees_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Employees_Search", param);
            return Dt;
        }

        ///////////////////EmployeeDebt/////////////////////////////////
        
        //EmployeeDebt_View()
        public DataTable EmployeeDebt_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("EmployeeDebt_View", null);
            return Dt;
        }
        //EmployeeDebt_Add()
        public void EmployeeDebt_Add(int Bill_ID, decimal PaidUp, decimal Rest, char StateDebt)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@PaidUp", SqlDbType.Money);
            param[1].Value = PaidUp;

            param[2] = new SqlParameter("@Rest", SqlDbType.Money);
            param[2].Value = Rest;

            param[3] = new SqlParameter("@StateDebt", SqlDbType.Char, 1);
            param[3].Value = StateDebt;

            DAL.ExecuteCommand("EmployeeDebt_Add", param);
        }
        //EmployeeDebt_Edit()
        public void EmployeeDebt_Edit(int Bill_ID, decimal PaidUp, decimal Rest, char StateDebt)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@PaidUp", SqlDbType.Money);
            param[1].Value = PaidUp;

            param[2] = new SqlParameter("@Rest", SqlDbType.Money);
            param[2].Value = Rest;

            param[3] = new SqlParameter("@StateDebt", SqlDbType.Char, 1);
            param[3].Value = StateDebt;

            DAL.ExecuteCommand("EmployeeDebt_Edit", param);
        }
        //EmployeeDebt_Search()
        public DataTable EmployeeDebt_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("EmployeeDebt_Search", param);
            return Dt;
        }

        ///////////////////Nationalities//////////////////////////////////

        //Nationalities_View
        public DataTable Nationalities_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Nationalities_View", null);
            return Dt;
        }
        //Nationality_Add()
        public void Nationalities_Add(string Nationality)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Nationality",SqlDbType.NVarChar, 25);
            param[0].Value =Nationality;

            DAL.ExecuteCommand("Nationalities_Add", param);
        }
        //Nationality_Edit()
        public void Nationalities_Edit(int NationalityID,string Nationality)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@NationalityID", SqlDbType.Int);
            param[0].Value = NationalityID;

            param[1] = new SqlParameter("@Nationality", SqlDbType.NVarChar,25);
            param[1].Value = Nationality;

            DAL.ExecuteCommand("Nationalities_Edit", param);
        }
        //Nationality_Search()
        public DataTable Nationalities_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Nationalities_Search", param);
            return Dt;
        }

        ///////////////////Jobs//////////////////////////////////

        //Jobs_View()
        public DataTable Jobs_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Jobs_View", null);
            return Dt;
        }
        //Jobs_Add()
        public void Jobs_Add(string JobType, decimal JobSalary,int JobHours,string jobTime)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@JobType", SqlDbType.NVarChar, 35);
            param[0].Value = JobType;

            param[1] = new SqlParameter("@JobSalary", SqlDbType.Money);
            param[1].Value = JobSalary;

            param[2] = new SqlParameter("@JobHours", SqlDbType.Int);
            param[2].Value = JobHours;

            param[3] = new SqlParameter("@jobTime", SqlDbType.NVarChar,6);
            param[3].Value = jobTime;

            DAL.ExecuteCommand("Jobs_Add", param);
        }
        //Jobs_Edit()
        public void Jobs_Edit(int JobID, string JobType, decimal JobSalary, int JobHours, string jobTime)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@JobID", SqlDbType.Int);
            param[0].Value = JobID;

            param[1] = new SqlParameter("@JobType", SqlDbType.NVarChar, 35);
            param[1].Value = JobType;

            param[2] = new SqlParameter("@JobSalary", SqlDbType.Money);
            param[2].Value = JobSalary;

            param[3] = new SqlParameter("@JobHours", SqlDbType.Int);
            param[3].Value = JobHours;

            param[4] = new SqlParameter("@jobTime", SqlDbType.NVarChar, 6);
            param[4].Value = jobTime;

            DAL.ExecuteCommand("Jobs_Edit", param);
        }
        //obs_Search()
        public DataTable Jobs_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Jobs_Search", param);
            return Dt;
        }

        ///////////////////SalaryType/////////////////////////////////

        //SalaryType_View()
        public DataTable SalaryType_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SalaryType_View", null);
            return Dt;
        }
        //SalaryType_Add()
        public void SalaryType_Add(string SalaryType)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SalaryType", SqlDbType.NVarChar,50);
            param[0].Value = SalaryType;

            DAL.ExecuteCommand("SalaryType_Add", param);
        }
        //SalaryType_Edit()
        public void SalaryType_Edit(int SequentialID, string SalaryType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@SalaryType", SqlDbType.Int);
            param[1].Value = SalaryType;

            DAL.ExecuteCommand("SalaryType_Edit", param);
        }


        ///////////////////Salaries/////////////////////////////////

        //Salaries_View()
        public DataTable Salaries_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Salaries_View", null);
            return Dt;
        }
        //Salaries_Add()
        public void Salaries_Add(int EmployID,int SalaryType, decimal SalaryValue, DateTime ReceivedDate,decimal SalaryRest,float AdvancePayment,string Note)
        {
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[0].Value = EmployID;

            param[1] = new SqlParameter("@SalaryType", SqlDbType.Int);
            param[1].Value = SalaryType;

            param[2] = new SqlParameter("@SalaryValue", SqlDbType.Money);
            param[2].Value = SalaryValue;

            param[3] = new SqlParameter("@ReceivedDate", SqlDbType.Date);
            param[3].Value = ReceivedDate;

            param[4] = new SqlParameter("@SalaryRest", SqlDbType.Money);
            param[4].Value = SalaryRest;

            param[5] = new SqlParameter("@AdvancePayment", SqlDbType.Float);
            param[5].Value = AdvancePayment;

            param[6] = new SqlParameter("Note", SqlDbType.NVarChar, 50);
            param[6].Value = Note;

            DAL.ExecuteCommand("Salaries_Add", param);
        }
        //Salaries_Edit()
        public void Salaries_Edit(int EmployID, int SalaryType, decimal SalaryValue, DateTime ReceivedDate, decimal SalaryRest, float AdvancePayment, string Note)
        {
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[0].Value = EmployID;

            param[1] = new SqlParameter("@SalaryType", SqlDbType.Int);
            param[1].Value = SalaryType;

            param[2] = new SqlParameter("@SalaryValue", SqlDbType.Money);
            param[2].Value = SalaryValue;

            param[3] = new SqlParameter("@ReceivedDate", SqlDbType.Date);
            param[3].Value = ReceivedDate;

            param[4] = new SqlParameter("@SalaryRest", SqlDbType.Money);
            param[4].Value = SalaryRest;

            param[5] = new SqlParameter("@AdvancePayment", SqlDbType.Float);
            param[5].Value = AdvancePayment;

            param[6] = new SqlParameter("Note", SqlDbType.NVarChar, 50);
            param[6].Value = Note;

            DAL.ExecuteCommand("Salaries_Edit", param);
        }
        //Salaries_Search()
        public DataTable Salaries_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Salaries_Search", param);
            return Dt;
        }

        

    }
}
