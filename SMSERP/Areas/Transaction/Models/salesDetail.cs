using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class salesDetail
    {
        private const string MODULE = "Transaction";

        [TVP]
        public int SalesId { get; set; }
        [TVP]
        public int ProductId { get; set; }
        [TVP]
        public int UnitId { get; set; }
        [TVP]
        public decimal Rate { get; set; }

        [TVP]
        public decimal Qty { get; set; }

        [TVP]
        public decimal TotalAmt { get; set; }
        [TVP]
        public decimal DisAmt { get; set; }
        [TVP]
        public decimal SalePar { get; set; }



        [TVP]
        public decimal SaleAmt { get; set; }
        [TVP]
        public decimal Fttex { get; set; }
        [TVP]
        public decimal Whtex { get; set; }
        [TVP]
        public decimal TAmt { get; set; }
        [TVP]
        public int StoreId { get; set; }































        //properties for model
        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }


        public string ProductName { get; set; }
        public string UnitName { get; set; }
        //View only properties

        public string Storename { get; set; }
        public string ReturnMessage { get; set; }

        public string Transaction_salesDetailSave(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; CreatedBy = bv.UserId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<salesDetail>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Transaction_salesDetailUpdate(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<salesDetail>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        //public salesDetail Transaction_salesDetailGetById(int id, BValues bv, string ip, string cInfo)
        //{
        //    var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

        //    try
        //    {
        //        salesDetail record = DataBase.ExecuteQuery<salesDetail>(parameters, Connection.GetConnection()).FirstOrDefault();

        //        Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

        //        return record;
        //    }
        //    catch (Exception ex)
        //    {
        //        Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

        //        return null;
        //    }
        //}

        public List<salesDetail> Transaction_salesDetailGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                List<salesDetail> records = DataBase.ExecuteQuery<salesDetail>(parameters, Connection.GetConnection());

               Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public DataTable Transaction_salesDetailGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_salesDetailGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_salesDetailDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<salesDetail>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

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