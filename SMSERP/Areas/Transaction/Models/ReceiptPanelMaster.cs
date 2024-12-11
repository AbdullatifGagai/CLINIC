using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class ReceiptPanelMaster
    {
        private const string MODULE = "Transaction";


        [TVP]
        public int ReceiptId { get; set; }
        [TVP]
        public int ReceiptCode { get; set; }
        [TVP]
        public string  RDate { get; set; }

        [TVP]
        public int MonId { get; set; }
        [TVP]

        public decimal  Amt { get; set; }

        [TVP]
        public int PanelId { get; set; }
        [TVP]
        public int RefId { get; set; }
        [TVP]
        public int BankId { get; set; }

        [TVP]
        public string  Remarks { get; set; }



















        //properties for model
        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }







        public string  PName { get; set; }

        public string FeesTerm { get; set; }


        public string VOUCHER_NO { get; set; }



        //View only properties
        public string ReturnMessage { get; set; }





        public string Transaction_ReceiptPanelMasterSave(BValues bv, string ip, string cInfo, ReceiptPanelMaster ReceiptPanelMaster, List<ReceiptPanelDetail> ReceiptPanelDetail)
        {
            var parameters = new { x = ReceiptPanelMaster, ReceiptPanelDetail };

            try
            {

                foreach (var item in ReceiptPanelDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }


                ReceiptPanelMaster.TenantId = bv.TenantId; ReceiptPanelMaster.AppId = bv.AppId; ReceiptPanelMaster.CreatedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<ReceiptPanelMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Transaction_ReceiptPanelMasterUpdate(BValues bv, string ip, string cInfo, ReceiptPanelMaster ReceiptPanelMaster, List<ReceiptPanelDetail> ReceiptPanelDetail)
        {
            var parameters = new { x = ReceiptPanelMaster, ReceiptPanelDetail };

            try
            {

                foreach (var item in ReceiptPanelDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }


                ReceiptPanelMaster.TenantId = bv.TenantId; ReceiptPanelMaster.AppId = bv.AppId; ReceiptPanelMaster.CreatedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<ReceiptPanelMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public ReceiptPanelMaster Transaction_ReceiptPanelMasterGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                ReceiptPanelMaster record = DataBase.ExecuteQuery<ReceiptPanelMaster>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public List<ReceiptPanelMaster> Transaction_ReceiptPanelMasterGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<ReceiptPanelMaster> records = DataBase.ExecuteQuery<ReceiptPanelMaster>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public DataTable Transaction_ReceiptPanelMasterGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_ReceiptPanelMasterGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_ReceiptPanelMasterDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<ReceiptPanelMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

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