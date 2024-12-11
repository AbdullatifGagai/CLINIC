using DatabaseTVP_Core;
using Logger_Core;
using ZCLINIC.Areas.Master.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class Transaction_UnitAllow
    {
        private const string MODULE = "Transaction";

        //properties for model
        [TVP]
        public int AllowID { get; set; }

        [TVP]
        public int Unit_Id { get; set; }
        [TVP]
        public int CPDID { get; set; }
        [TVP]
        public decimal TAmtcost { get; set; }
        [TVP]
        public decimal InsAmt { get; set; }
        [TVP]
        public decimal OpAmt { get; set; }
        [TVP]
        public string  Usname { get; set; }
        [TVP]
        public string  Wdate { get; set; }

        [TVP]
        public decimal  OpMainAmt { get; set; }
        [TVP]
        public int MNo { get; set; }
        [TVP]
        public int RegID { get; set; }
        [TVP]
        public decimal MainAmt { get; set; }
        [TVP]
        public decimal MRent { get; set; }
        [TVP]
        public int CF { get; set; }
        [TVP]
        public decimal OpBalanceAmt { get; set; }
        [TVP]
        public int BioM { get; set; }
         [TVP]
        public int SoceityId  { get; set; }

        [TVP]
        public string DocumentPath { get; set; }


        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }

        //View only properties

        public string UnitName { get; set; }
       // public string Mobileno { get; set; }
        //public string NicNo { get; set; }

        public string PlotNo { get; set; }

        public string SName { get; set; }




        /// <summary>
        /// cpd Info 
        /// </summary>

        public string MyProperty { get; set; }
        public string Name { get; set; }
        public string Int { get; set; }
        public string Fname { get; set; }
        public string NicNo { get; set; }
        public string Mobileno { get; set; }

        public decimal Amount { get; set; }

        public byte[] Image_Picture { get; set; }

        public string Cardid { get; set; }

        public string  Script { get; set; }

        public string ReturnMessage { get; set; }

        public string Transaction_UnitAllowSave(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; CreatedBy = bv.UserId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_UnitAllow>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Transaction_UnitAllowUpdate(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_UnitAllow>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }


           public string DouPathSaveTransaction_UnitAllow(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_UnitAllow>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }





        public Transaction_UnitAllow Transaction_UnitAllowGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                Transaction_UnitAllow record = DataBase.ExecuteQuery<Transaction_UnitAllow>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

      
          public Transaction_UnitAllow GetDoument_UnitAllow(int  id , BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {


               


                 Transaction_UnitAllow record = DataBase.ExecuteQuery<Transaction_UnitAllow>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

      












        public List<Transaction_UnitAllow> Transaction_UnitAllowGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                 List<Transaction_UnitAllow> records = DataBase.ExecuteQuery<Transaction_UnitAllow>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }
        

      public List<Transaction_UnitAllow> GetAllowmentSearch(string  Id,BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId,id = Id };

            try
            {
                 List<Transaction_UnitAllow> records = DataBase.ExecuteQuery<Transaction_UnitAllow>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


         public List<Master_UnitRegistration> Transaction_UnitList(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                 List<Master_UnitRegistration> records = DataBase.ExecuteQuery<Master_UnitRegistration>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }



           public List<Transaction_UnitAllow> Transaction_GetregId(string SocN, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, SocN };

            try
            {
                 List<Transaction_UnitAllow> records = DataBase.ExecuteQuery<Transaction_UnitAllow>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


             public List<Transaction_UnitAllow> GetUnitListM(int Id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id };

            try
            {
                 List<Transaction_UnitAllow> records = DataBase.ExecuteQuery<Transaction_UnitAllow>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }











        public DataTable Transaction_UnitAllowGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_Transaction_UnitAllowGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_UnitAllowDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<Transaction_UnitAllow>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

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