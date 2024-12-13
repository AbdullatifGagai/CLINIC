using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class Transaction_VoucherMaster
    {
        private const string MODULE = "Transaction";

        [TVP]
        public int REF_ID { get; set; }
        [TVP]
        public string  VOUCHER_NO { get; set; }
        [TVP]
        public string Acc_Code { get; set; }
        [TVP]
        public string Acc_Name { get; set; }
        [TVP]
        public string VOUCHER_MODE { get; set; }
        [TVP]
        public decimal TOTAL_AMOUNT { get; set; }
        [TVP]
        public string Nurration { get; set; }
        [TVP]
        public string CHQ { get; set; }
        [TVP]
        public string User_name { get; set; }
        [TVP]
        public string VOUCHAR_DATE { get; set; }
        [TVP]
        public string Voucher_time { get; set; }
        [TVP]
        public int  Comp_id { get; set; }
        [TVP]

        public string DeletedBy { get; set; }

        [TVP]
        public string Deleted_Date { get; set; }

        [TVP]
        public int  PostUser_ID { get; set; }
        [TVP]

        public string AInword { get; set; }
        [TVP]
        public string Che_pay { get; set; }

        [TVP]
        public int  Sup_ID { get; set; }

        [TVP]
        public decimal TDebitAmt { get; set; }
        [TVP]
        public decimal TCreditAmt { get; set; }



















        //properties for model
        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }
       
        
        
        public List<Transaction_VoucherDetail> VoucherDetails { get; set; }
        //View only properties
        public string ReturnMessage { get; set; }

        //public decimal TDebAmt { get; set; }

        //public decimal TCreAmt { get; set; }

        public int MyProperty { get; set; }

        public string Transaction_VoucherMasterSave(BValues bv, string ip, string cInfo)
        {

            foreach (var item in VoucherDetails)
            { 



                item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy =bv.UserId ; item.ModifiedBy = bv.UserId;
            }


            var parameters = new { x = this,VoucherDetails};

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; CreatedBy = bv.UserId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_VoucherMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Transaction_VoucherMasterUpdate(BValues bv, string ip, string cInfo)
        {


            foreach (var item in VoucherDetails)
            {



                item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.ModifiedBy = bv.UserId;
            }





            var parameters = new { x = this, VoucherDetails };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_VoucherMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public Transaction_VoucherMaster Transaction_VoucherMasterGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                Transaction_VoucherMaster record = DataBase.ExecuteQuery<Transaction_VoucherMaster>(parameters, Connection.GetConnection()).FirstOrDefault();

                if (record != null)
                {
                    record.VoucherDetails = Transaction_VoucherDetailGetMasterId(id, bv, ip, cInfo);
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

        public List<Transaction_VoucherMaster> Transaction_VoucherMasterGetAll(BValues bv, string ip, string cInfo,string VouMode)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId,VouMode};

            
            
            try
            {
                List<Transaction_VoucherMaster> records = DataBase.ExecuteQuery<Transaction_VoucherMaster>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }
         public List<Transaction_VoucherMaster> Transaction_VoucherMasterBPVGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            
            
            try
            {
                List<Transaction_VoucherMaster> records = DataBase.ExecuteQuery<Transaction_VoucherMaster>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public DataTable Transaction_VoucherMasterGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_Transaction_VoucherMasterGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_VoucherMasterDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<Transaction_VoucherMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }
     public List<Transaction_VoucherDetail> Transaction_VoucherDetailGetMasterId(int id,BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId ,id};

            try
            {
                List<Transaction_VoucherDetail> records = DataBase.ExecuteQuery<Transaction_VoucherDetail>(parameters, Connection.GetConnection());

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