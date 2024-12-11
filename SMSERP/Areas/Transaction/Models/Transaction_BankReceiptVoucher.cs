using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class Transaction_BankReceiptVoucher
    {
        private const string MODULE = "Transaction";

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
        public string ReturnMessage { get; set; }

        public string Transaction_Transaction_BankReceiptVoucherSave(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; CreatedBy = bv.UserId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_BankReceiptVoucher>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Transaction_Transaction_BankReceiptVoucherUpdate(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_BankReceiptVoucher>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public Transaction_BankReceiptVoucher Transaction_Transaction_BankReceiptVoucherGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                Transaction_BankReceiptVoucher record = DataBase.ExecuteQuery<Transaction_BankReceiptVoucher>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public List<Transaction_BankReceiptVoucher> Transaction_Transaction_BankReceiptVoucherGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<Transaction_BankReceiptVoucher> records = DataBase.ExecuteQuery<Transaction_BankReceiptVoucher>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public DataTable Transaction_Transaction_BankReceiptVoucherGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_Transaction_BankReceiptVoucherGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_Transaction_BankReceiptVoucherDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<Transaction_BankReceiptVoucher>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

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