using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ZCLINIC.Areas.master.Models;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class Transaction_Receipt
    {
        private const string MODULE = "Transaction";
 
        [TVP]
        public int ID { get; set; }
        [TVP]
        public int UnitId { get; set; }

       [TVP]
        public int CPDID { get; set; }

       
        
        [TVP]
        public string Date { get; set; }
        [TVP]
        public decimal Amount { get; set; }
        [TVP]
        public string DebitCode { get; set; }
        [TVP]
        public string CreditCode { get; set; }
        [TVP]
        public int   VMode { get; set; }
        [TVP]
        public string  time { get; set; }
        [TVP]
        public string VoucherNo { get; set; }
        [TVP]
        public int RefId { get; set; }

        [TVP]
        public int chkR { get; set; }
        [TVP]
        public string ChQCas { get; set; }
        [TVP]
        public int AllowId { get; set; }
        [TVP]
        public string  FMonth { get; set; }
        [TVP]
        public string TMonth { get; set; }





        //properties for model
        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }

        //View only properties

        public int MNo { get; set; }
        public int RegID { get; set; }

        public string VModeName { get; set; }

        public string  UnitName { get; set; }

        public  string Name  { get; set; }

        public string  DebitName { get; set; }
        public string  CreditName { get; set; }

        public int TotalCount { get; set; }

        public string Nurration { get; set; }



        public string Mobileno { get; set; }

        public decimal RecAmount { get; set; }

        public string ReturnMessage { get; set; }


        public string  APIAdd { get; set; }
        public string Transaction_ReceiptSave(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this,Nurration };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; CreatedBy = bv.UserId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_Receipt>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Transaction_ReceiptUpdate(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this,Nurration };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_Receipt>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public Transaction_Receipt Transaction_ReceiptGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                 Transaction_Receipt record = DataBase.ExecuteQuery<Transaction_Receipt>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                 return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public List<Transaction_Receipt> Transaction_ReceiptGetAll(BValues bv, string ip, string cInfo)
        {
          
               var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<Transaction_Receipt> records = DataBase.ExecuteQuery<Transaction_Receipt>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


    

        public Transaction_Receipt Transaction_ReceiptSms(int AllowId, int RId,int CpId,int ValdationId,BValues bv, string ip, string cInfo)
        {
            
            
            
            
            
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Allowid = AllowId, Rid = RId,cpid = CpId, id =ValdationId };

            try
            {
                //  TenantId = bv.TenantId; AppId = bv.AppId; ModifiedBy = bv.UserId;

                Transaction_Receipt record = DataBase.ExecuteQuery<Transaction_Receipt>(parameters, Connection.GetConnection()).FirstOrDefault();

                 Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }



        public DataTable Transaction_ReceiptGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_Transaction_ReceiptGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_ReceiptDelete(int id,int Refid ,BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id, RefId = Refid };

            try
            {
                string message = DataBase.ExecuteQuery<Transaction_Receipt>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }


        public List<Transaction_Receipt> Transaction_ReceiptGetAllWithPagination(BValues bv, string ip, string cInfo, int length, int offset, string searchtext, int status)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, offset, length, searchtext, status };

            try
            {
                List<Transaction_Receipt> records = DataBase.ExecuteQuery<Transaction_Receipt>(parameters, Connection.GetConnection());

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