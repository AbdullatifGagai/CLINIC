using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class ReceiptMaster
    {
        private const string MODULE = "Transaction";



        [TVP]
        public int ReceiptId { get; set; }

        [TVP]
        public int ReceiptCode { get; set; }
        [TVP]
        public string ReceiptNo { get; set; }

        [TVP]
        public string ReceiptDate { get; set; }


        [TVP]
        public string  RefNo { get; set; }


        [TVP]
        public int DocId { get; set; }
        [TVP]
        public int MrId { get; set; }
        [TVP]
        public string MrNo { get; set; }
        [TVP]
        public string PatientName { get; set; }

        [TVP]
        public int PaymentM { get; set; }
       
        
       
        [TVP]
        public int PanelId { get; set; }
       
        [TVP]
        public int CategoryId { get; set; }
       
        
       
        
        
        
        
        
        
        [TVP]
        public string  DateOfBirth { get; set; }
        
          [TVP]
        public string  age { get; set; }
        
        
        
        
        
        
       
       

        [TVP]
        public decimal ServicesAmt { get; set; }


        [TVP]
        public decimal DisAmt { get; set; }



        [TVP]
        public decimal  CashAmt { get; set; }
     
        [TVP]
        public decimal BalanceAmt { get; set; }





        [TVP]
        public int TokenNo { get; set; }

        [TVP]
        public decimal HosShare { get; set; }
        [TVP]
        public decimal  DocShare { get; set; }

        [TVP]
        public string  Shift { get; set; }



        public int ServicesId { get; set; }

        public string ServicesName { get; set; }

        public decimal Rate { get; set; }



        //properties for model
        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }



        public int TotalCount { get; set; }

        //View only properties
        public string ReturnMessage { get; set; }

        public string Transaction_ReceiptMasterSave(BValues bv, string ip, string cInfo, ReceiptMaster ReceiptMaster, List<ReceiptDetail> ReceiptDetail)
        {
            var parameters = new { x = ReceiptMaster, ReceiptDetail };

            try
            {

                foreach (var item in ReceiptDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }


                ReceiptMaster.TenantId = bv.TenantId; ReceiptMaster.AppId = bv.AppId; ReceiptMaster.CreatedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<ReceiptMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Transaction_ReceiptMasterUpdate(BValues bv, string ip, string cInfo, ReceiptMaster ReceiptMaster, List<ReceiptDetail> ReceiptDetail)
        {
            var parameters = new { x = ReceiptMaster, ReceiptDetail };

            try
            {

                foreach (var item in ReceiptDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }


                ReceiptMaster.TenantId = bv.TenantId; ReceiptMaster.AppId = bv.AppId; ReceiptMaster.CreatedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<ReceiptMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public ReceiptMaster Transaction_ReceiptMasterGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                ReceiptMaster record = DataBase.ExecuteQuery<ReceiptMaster>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        //public List<ReceiptMaster> Transaction_ReceiptMasterGetAll(BValues bv, string ip, string cInfo)
        //{
        //    var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

        //    try
        //    {
        //        List<ReceiptMaster> records = DataBase.ExecuteQuery<ReceiptMaster>(parameters, Connection.GetConnection());

        //        Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

        //        return records;
        //    }
        //    catch (Exception ex)
        //    {
        //        Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

        //        return null;
        //    }
        //}

        public List<ReceiptMaster> Transaction_ReceiptMasterGetAll(BValues bv, string ip, string cInfo, int length, int offset, string searchtext, int status)
        {


            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, offset, length, searchtext, status };



            try
            {
                List<ReceiptMaster> records = DataBase.ExecuteQuery<ReceiptMaster>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }



        public List<ReceiptMaster> Transaction_ReceiptMasterGetRefNO(string Id,BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId,Id };

            try
            {
                List<ReceiptMaster> records = DataBase.ExecuteQuery<ReceiptMaster>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }















        public DataTable Transaction_ReceiptMasterGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_ReceiptMasterGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_ReceiptMasterDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<ReceiptMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

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