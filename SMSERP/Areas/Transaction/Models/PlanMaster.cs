using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ZCLINIC.Areas.Master.Models;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class PlanMaster
    {
        private const string MODULE = "Transaction";


        [TVP]
        public int PlanId { get; set; }
         [TVP]
        public int PlanCode { get; set; }

        [TVP]
        public string PlanDate { get; set; }

        [TVP]
        public string PlanName { get; set; }

       



        [TVP]
        public int DegreeId { get; set; }

        
        [TVP]
        public decimal TAdmissionFee { get; set; }
        [TVP]
        public decimal T_TutionFee { get; set; }
        [TVP]
        public decimal T_Annelfee { get; set; }
        [TVP]
        public decimal TEnrollment { get; set; }
        [TVP]
        public decimal TExam { get; set; }
        [TVP]
        public decimal TKUA { get; set; }
        [TVP]
        public decimal TMis { get; set; }
        [TVP]
        public decimal TPenalty { get; set; }




        [TVP]
        public decimal  TDis { get; set; }

        [TVP]
        public decimal TFees { get; set; }

        



        //properties for model
        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }






        //public List<Semester> Semester { get; set; }


        public string SName { get; set; }



        public string DegreeN { get; set; }

        //   public string LevelName { get; set; }

        //View only properties
        public string ReturnMessage { get; set; }

        public string Transaction_PlanMasterSave(BValues bv, string ip, string cInfo, PlanMaster PlanMaster, List<PlanDetail> PlanDetail)
        {


            var parameters = new { x = PlanMaster,PlanDetail };



            foreach (var item in PlanDetail)
            {



                item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
            }






            PlanMaster.TenantId = bv.TenantId; PlanMaster.AppId = bv.AppId; PlanMaster.CreatedBy = bv.UserId;

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

        public string Transaction_PlanMasterUpdate(BValues bv, string ip, string cInfo, PlanMaster PlanMaster, List<PlanDetail> PlanDetail)
        {
            var parameters = new { x = PlanMaster, PlanDetail };



            foreach (var item in PlanDetail)
            {



                item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.ModifiedBy = bv.UserId;
            }






            PlanMaster.TenantId = bv.TenantId; PlanMaster.AppId = bv.AppId; PlanMaster.ModifiedBy = bv.UserId;

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

        public PlanMaster Transaction_PlanMasterGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                PlanMaster record = DataBase.ExecuteQuery<PlanMaster>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public List<PlanMaster> Transaction_PlanMasterGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<PlanMaster> records = DataBase.ExecuteQuery<PlanMaster>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public DataTable Transaction_PlanMasterGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_PlanMasterGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_PlanMasterDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<PlanMaster>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

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