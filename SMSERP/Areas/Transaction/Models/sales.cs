using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class sales
    {
        private const string MODULE = "Transaction";

        [TVP]
        public int SalesId { get; set; }
        [TVP]
        public string SalesCode { get; set; }
        [TVP]
        public string SaleDate { get; set; }
        [TVP]
        public int GrId  { get; set; }
        [TVP]
        public string GrNo  { get; set; }
        
        
        
        
        
        [TVP]
        public string StudentName { get; set; }
        [TVP]
        public decimal Total_Amt { get; set; }
        [TVP]
        public decimal Total_DisAmt { get; set; }
        [TVP]
        public decimal Total_Saletex { get; set; }
        [TVP]
        public decimal FxtexAmt { get; set; }
        [TVP]
        public decimal WhtexAmt { get; set; }
        [TVP]
        public decimal Total_Amount { get; set; }
       


        [TVP]
        public int RefId { get; set; }

        [TVP]
        public int BankId { get; set; }

        [TVP]
        public int IncomeId { get; set; }

        [TVP]
        public int MonId { get; set; }


        [TVP]
        public string  DueDate  { get; set; }




















        //properties for model
        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }


        public int FeeId { get; set; }

        //View only properties
        public string ReturnMessage { get; set; }

        public string Transaction_salesSave(BValues bv, string ip, string cInfo,sales sales, List<salesDetail> salesDetail)
        {
            var parameters = new { x = sales, salesDetail };

            

                foreach (var item in salesDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }






                sales.TenantId = bv.TenantId; sales.AppId = bv.AppId; sales.CreatedBy = bv.UserId;

                try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; CreatedBy = bv.UserId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<sales>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Transaction_salesUpdate(BValues bv, string ip, string cInfo, sales sales, List<salesDetail> salesDetail)
        {
            var parameters = new { x = sales, salesDetail };



            foreach (var item in salesDetail)
            {



                item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
            }




            sales.TenantId = bv.TenantId; sales.AppId = bv.AppId; sales.CreatedBy = bv.UserId;

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<sales>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public sales Transaction_salesGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                sales record = DataBase.ExecuteQuery<sales>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public List<sales> Transaction_salesGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<sales> records = DataBase.ExecuteQuery<sales>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public DataTable Transaction_salesGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_salesGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_salesDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<sales>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }
    }
}