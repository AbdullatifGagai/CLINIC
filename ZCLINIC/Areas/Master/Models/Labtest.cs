using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Master.Models
{
    public class Labtest
    {
        private const string MODULE = "Master";


        [TVP]
        public int TestId { get; set; }
        [TVP]
        public int TestCode { get; set; }
        [TVP]
        public int SerId { get; set; }
        [TVP]
        public int DepId { get; set; }




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



        public string ServicesName { get; set; }


        public string DepName { get; set; }


        public string Discri { get; set; }

        public string Unit { get; set; }

        public string  Refvalue { get; set; }


        public string  HGroup { get; set; }

        public string Master_LabtestSave(BValues bv, string ip, string cInfo,Labtest Labtest,List<LabtestDetail> LabtestDetail)
        {
            var parameters = new { x = Labtest, LabtestDetail };

            try
            {






                foreach(var item in LabtestDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }








                Labtest.TenantId = bv.TenantId; Labtest.AppId = bv.AppId; Labtest.CreatedBy = bv.UserId; Labtest.ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Labtest>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Master_LabtestUpdate(BValues bv, string ip, string cInfo, Labtest Labtest, List<LabtestDetail> LabtestDetail)
        {
            var parameters = new { x = Labtest, y = LabtestDetail };

            try
            {

                foreach (var item in LabtestDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }

                Labtest.TenantId = bv.TenantId; Labtest.AppId = bv.AppId; Labtest.CreatedBy = bv.UserId; Labtest.ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Labtest>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public Labtest Master_LabtestGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                Labtest record = DataBase.ExecuteQuery<Labtest>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public List<Labtest> LabtestGetLabServices(int Id,int RId,BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId,Id,RId };

            try
            {
                List<Labtest> records = DataBase.ExecuteQuery<Labtest>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


       
         public List<Labtest> LabtestGetRefId(int Id,BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId,Id };

            try
            {
                List<Labtest> records = DataBase.ExecuteQuery<Labtest>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public List<Labtest> Master_LabtestGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<Labtest> records = DataBase.ExecuteQuery<Labtest>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }






        public DataTable Master_LabtestGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Master_LabtestGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Master_LabtestDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<Labtest>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

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