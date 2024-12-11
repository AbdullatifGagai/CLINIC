using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class Purchase
    {
        private const string MODULE = "Transaction";

        //properties for model

        [TVP]
        public int PurId { get; set; }
        [TVP]
        public string  PurCode { get; set; }
        [TVP]
        public string  PurchaseDate { get; set; }
        [TVP]
        public int SupId { get; set; }
        [TVP]
        public string SupName { get; set; }
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
        public string  invoiceno { get; set; }

         [TVP]
        public string  InvoiceDate { get; set; }


        [TVP]
        public int RefId { get; set; }

        [TVP]
        public int MonId { get; set; }









        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }


        public string  SupplierName { get; set; }
        
        //View only properties
        public string ReturnMessage { get; set; }

        public string Transaction_PurchaseSave(BValues bv, string ip, string cInfo, Purchase Purchase, List<PurchaseDetail> PurchaseDetail)
        {
            var parameters = new { x = Purchase, PurchaseDetail};

            try
            {


                foreach (var item in PurchaseDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }






                Purchase.TenantId = bv.TenantId; Purchase.AppId = bv.AppId; Purchase.CreatedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Purchase>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Transaction_PurchaseUpdate(BValues bv, string ip, string cInfo, Purchase Purchase, List<PurchaseDetail> PurchaseDetail)
        {
            var parameters = new { x = Purchase, PurchaseDetail };
          
            
            foreach (var item in PurchaseDetail)
            {



                item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
            }






            Purchase.TenantId = bv.TenantId; Purchase.AppId = bv.AppId; Purchase.CreatedBy = bv.UserId;


            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Purchase>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public Purchase Transaction_PurchaseGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                Purchase record = DataBase.ExecuteQuery<Purchase>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public List<Purchase> Transaction_PurchaseGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<Purchase> records = DataBase.ExecuteQuery<Purchase>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public DataTable Transaction_PurchaseGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_PurchaseGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_PurchaseDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<Purchase>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

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