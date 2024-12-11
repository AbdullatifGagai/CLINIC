using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class Transaction_CPDForm
    {
        private const string MODULE = "Transaction";




        [TVP]
        public int CPDID { get; set; }
        [TVP]
        public string Name { get; set; }
        [TVP]
        public string Int { get; set; }
        [TVP]
        public string Fname { get; set; }
        [TVP]
        public string DOB { get; set; }
        [TVP]
        public string Gender { get; set; }
        [TVP]
        public string MStatus { get; set; }
        [TVP]
        public string RefNo1 { get; set; }
        [TVP]
        public string RefNo2 { get; set; }
        [TVP]
        public string NicNo { get; set; }
        [TVP]

      
        public string NtNno { get; set; }
        [TVP]
        public string  FamilyNo { get; set; }
        [TVP]
        public string BloodG { get; set; }
        [TVP]
        public int  CoutyID { get; set; }
        [TVP]
        public string JPSD { get; set; }
        [TVP]
        public string APS { get; set; }
        [TVP]
        public string PostalAdd { get; set; }
        [TVP]
        public string PostalAdd1 { get; set; }
        [TVP]
        public string PostalAdd2 { get; set; }
        [TVP]
        public string PermentAdd { get; set; }
        [TVP]
        public string City { get; set; }
        [TVP]
        public string LandLine { get; set; }
        [TVP]
        public string Mobileno { get; set; }
        [TVP]
        public string EmailAdd { get; set; }
        [TVP]
        public string EmPriName { get; set; }
        [TVP]
        public string EmPhonePri { get; set; }
        [TVP]
        public string EmRelationpri { get; set; }
        [TVP]
        public string EpNic { get; set; }
       
        [TVP]
        public string EpAdd1 { get; set; }
        [TVP]
        public string EpAdd2 { get; set; }
        [TVP]
        public string NomiName { get; set; }
        [TVP]
        public string NomiPhone { get; set; }
        [TVP]
        public string NomiRelation { get; set; }
        [TVP]
        public string ENoNic { get; set; }
        [TVP]
        public string ENodd1 { get; set; }
        [TVP]
        public string EnoAdd2 { get; set; }
        [TVP]
        public string R_MDate { get; set; }





        //properties for model
        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }


        public string ImagePath { get; set; }


        public byte[] Image_Picture { get; set; }
        public byte[] rightthumb { get; set; }
        public byte[] Leftthumb { get; set; }

     
        
        
        
        //View only properties
        public string ReturnMessage { get; set; }

        public string Transaction_CPDFormSave(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; CreatedBy = bv.UserId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_CPDForm>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Transaction_CPDFormUpdate(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Transaction_CPDForm>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public Transaction_CPDForm Transaction_CPDFormGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                Transaction_CPDForm record = DataBase.ExecuteQuery<Transaction_CPDForm>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public List<Transaction_CPDForm> Transaction_CPDFormGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<Transaction_CPDForm> records = DataBase.ExecuteQuery<Transaction_CPDForm>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                 Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }
         public List<Transaction_CPDForm> GetAllList(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<Transaction_CPDForm> records = DataBase.ExecuteQuery<Transaction_CPDForm>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                 Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public DataTable Transaction_CPDFormGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_Transaction_CPDFormGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_CPDFormDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<Transaction_CPDForm>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

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