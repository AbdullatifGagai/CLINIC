using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class Transaction_MonthlyPro
    {
        private const string MODULE = "Transaction";


        [TVP]
        public int ID { get; set; }
        [TVP]
        public string VoucherID { get; set; }
        [TVP]
        public int RefId {  get; set; }
        [TVP]
        public string UserN { get; set; }
        [TVP]
        public string W_Date { get; set; }
        [TVP]
        public string time { get; set; }
        [TVP]
        public decimal SubAmt { get; set; }
        [TVP]
        public decimal DisAmt { get; set; }
        [TVP]
        public decimal SaleAmt { get; set; }
        [TVP]
        public decimal TAmt { get; set; }
        [TVP]
        public string DebitAcc { get; set; }
        [TVP]
        public string CrditAcc { get; set; }
        [TVP]
        public int Vmode { get; set; }







        //properties for model
        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }



        public string DebitAccName  { get; set; }
        public string CreditAccName  { get; set; }
        public string Nurration { get; set; }

       
        
        
        public List<MonthlyProDetail> MonthlyProDetail { get; set; }
       /// public List<Transaction_VoucherDetail> VoucherDetails { get; set; }


        //View only properties
        public string ReturnMessage { get; set; }

        public string Transaction_MonthlyProSave(BValues bv, string ip, string cInfo)
        {
            

            foreach (var item in MonthlyProDetail)
            {



                item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.ModifiedBy = bv.UserId;
            }






            var parameters = new { x = this,y= MonthlyProDetail,z= Nurration};

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; CreatedBy = bv.UserId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_MonthlyPro>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Transaction_MonthlyProUpdate(BValues bv, string ip, string cInfo)
        {

            var parameters = new { x = this, MonthlyProDetail,Nurration };


            try
            {


                foreach (var item in MonthlyProDetail)
                {
                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.ModifiedBy = bv.UserId;
                }





                TenantId = bv.TenantId; AppId = bv.AppId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_MonthlyPro>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public Transaction_MonthlyPro Transaction_MonthlyProGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                Transaction_MonthlyPro record = DataBase.ExecuteQuery<Transaction_MonthlyPro>(parameters, Connection.GetConnection()).FirstOrDefault();

                if (record != null)
                {

                    record.MonthlyProDetail = Transaction_MonthlyProDetailsGetById(id, bv, ip, cInfo);


                }






                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public List<Transaction_MonthlyPro> Transaction_MonthlyProGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<Transaction_MonthlyPro> records = DataBase.ExecuteQuery<Transaction_MonthlyPro>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public DataTable Transaction_MonthlyProGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_Transaction_MonthlyProGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_MonthlyProDelete(int id,int RefId, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id,refId  = RefId };

            try
            {
                string message = DataBase.ExecuteQuery<Transaction_MonthlyPro>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }


        public List<MonthlyProDetail> Transaction_MonthlyProDetailsGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
               // List <MonthlyProDetail> record = DataBase.ExecuteQuery<MonthlyProDetail>(parameters, Connection.GetConnection()).FirstOrDefault();

                List<MonthlyProDetail> records = DataBase.ExecuteQuery<MonthlyProDetail>(parameters, Connection.GetConnection());




                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records; 
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }














    }
}