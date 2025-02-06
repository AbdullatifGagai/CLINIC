using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class ReportMaster
    {
        private const string MODULE = "Transaction";


        [TVP]
        public int ReportId { get; set; }
       
        [TVP]
        public int ReportCode { get; set; }
       
        [TVP]
        public string  ReportNo{ get; set; }
       
        
        
        
        
        
        
        
        
        
        
        [TVP]
        public int ReceiptId { get; set; }
    
        [TVP]
        public string ReceiptNo { get; set; }
    
        
        
        
        
        
        [TVP]
        public int MrId { get; set; }
        [TVP]

        public string  Mrno { get; set; }
        [TVP]
        public string PName { get; set; }
        [TVP]
        public string Age { get; set; }
        [TVP]
        public string  CollectedDate { get; set; }
       
        [TVP]
        public string  RecDate { get; set; }
       
        
        
        [TVP]
        public string ReportDate { get; set; }
        [TVP]

        public string  ReportTime { get; set; }
        [TVP]
        public int DepId { get; set; }
        [TVP]
        public int SerId { get; set; }

           [TVP]
        public string  Remarks { get; set; }


           [TVP]
        public int   FID { get; set; }



         [TVP]
        public int MoId { get; set; }

        [TVP]
        public int TecId { get; set; }
        [TVP]
        public int TecUserId { get; set; }
        [TVP]
        public int PathId { get; set; }
        [TVP]
        public int PathUserId { get; set; }













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


        public string  PatientName { get; set; }
        public string ReturnMessage { get; set; }

        public string Transaction_ReportMasterSave(BValues bv, string ip, string cInfo, ReportMaster ReportMaster, List<ReportDetail> ReportDetail)
        {
            var parameters = new { x = ReportMaster, y = ReportDetail };










            try
            {

                foreach (var item in ReportDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }









                ReportMaster.TenantId = bv.TenantId; ReportMaster.AppId = bv.AppId; ReportMaster.CreatedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<ReportMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Transaction_ReportMasterUpdate(BValues bv, string ip, string cInfo, ReportMaster ReportMaster, List<ReportDetail> ReportDetail)
        {
            var parameters = new { x = ReportMaster,y=ReportDetail };

            try
            {


                foreach (var item in ReportDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }









                ReportMaster.TenantId = bv.TenantId; ReportMaster.AppId = bv.AppId; ReportMaster.ModifiedBy = bv.UserId; ;

                string message = DataBase.ExecuteQuery<ReportMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public ReportMaster Transaction_ReportMasterGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                ReportMaster record = DataBase.ExecuteQuery<ReportMaster>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public List<ReportMaster> Transaction_ReportMasterGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<ReportMaster> records = DataBase.ExecuteQuery<ReportMaster>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }
         public List<ReportMaster> Transaction_ReportMasterTechnoGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<ReportMaster> records = DataBase.ExecuteQuery<ReportMaster>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


         public List<ReportMaster> Transaction_ReportMasterPathGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<ReportMaster> records = DataBase.ExecuteQuery<ReportMaster>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }
















        public DataTable Transaction_ReportMasterGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_ReportMasterGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_ReportMasterDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<ReportMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }


        }


        public string ApprovedTech(int id, BValues bv, string ip, string cInfo)
            {
                var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

                try
                {
                    string message = DataBase.ExecuteQuery<ReportMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                    Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                    return message;
                }
                catch (Exception ex)
                {
                    Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                    return ex.Message;
                }
            }


         public string ApprovedPathologist(int id, BValues bv, string ip, string cInfo)
            {
                var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

                try
                {
                    string message = DataBase.ExecuteQuery<ReportMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                    Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                    return message;
                }
                catch (Exception ex)
                {
                    Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                    return ex.Message;
                }
            }
















        public string Transaction_ReportMasterPathGetAll(int id, BValues bv, string ip, string cInfo)
            {
                var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

                try
                {
                    string message = DataBase.ExecuteQuery<ReportMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

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