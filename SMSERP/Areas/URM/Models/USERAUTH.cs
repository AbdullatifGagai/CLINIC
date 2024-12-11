using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace ZCLINIC.Areas.URM.Models
{
    public class USERAUTH
    {
        private const string MODULE = "URM";

        //properties for model

        [TVP]
        public int User_id { get; set; }
        [TVP]
        public string  USER_NAME { get; set; }
        [TVP]
        public string  USER_PWS { get; set; }
        [TVP]
        public int Dis_user { get; set; }
        [TVP]
        public int Role_ID { get; set; }

         [TVP]
        public string  FullName  { get; set; }

        
       












        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]

        public string ConfirmPassword { get; set; }
        public string NewPassword { get; set; }
        public string CompanyName { get; set; }

        public int ModifiedBy { get; set; }

        //View only properties
        public string ReturnMessage { get; set; }

        public USERAUTH URM_Login(string MachineName, string IP, string host)
        {
            try
            {
                USERAUTH USERAUTH = DataBase.ExecuteQuery<USERAUTH>(new { x = this.USER_NAME, y = this.USER_PWS, z = host }, Connection.GetConnection()).FirstOrDefault();
                // Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { x = this.UserName, y = this.UPassword }, "", Module, Connection.GetLogConnection(), MachineName, IP, user.UserId);
                return USERAUTH;
            }
            catch (Exception ex)
            {
                //Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, "", new { x = this.UserName, y = this.UPassword }, "", Module, Connection.GetLogConnection(), MachineName, IP);
            }
            return null;
        }















        public string URM_USERAUTHSave(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                CreatedBy = bv.UserId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<USERAUTH>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

             //  Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }


         public string URM_USERAUTHCompanySave(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                CreatedBy = bv.UserId; ModifiedBy = bv.UserId;


                







                string message = DataBase.ExecuteQuery<USERAUTH>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

               Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);
              


                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }













        public string URM_USERAUTHUpdate(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                 ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<USERAUTH>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public USERAUTH URM_USERAUTHGetById(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId};

            try
            {
                USERAUTH record = DataBase.ExecuteQuery<USERAUTH>(parameters, Connection.GetConnection()).FirstOrDefault();

               Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

         public USERAUTH URM_USERAUTHUSERGetById(int id,BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId,Id = id};

            try
            {
                USERAUTH record = DataBase.ExecuteQuery<USERAUTH>(parameters, Connection.GetConnection()).FirstOrDefault();

               Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

      
      






        public List<USERAUTH> URM_USERAUTHGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<USERAUTH> records = DataBase.ExecuteQuery<USERAUTH>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public DataTable USERAUTHGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "URM_USERAUTHGetAllTable");

              //  Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string URM_USERAUTHDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<USERAUTH>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

             Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
               // Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string URM_ChangePassword(BValues bv, string IP, string CInfo)
        {
            try
            {
                if (this.ConfirmPassword != this.NewPassword)
                {
                    return "Confirm and New Password Not Matched";
                }
                string Message = DataBase.ExecuteQuery<USERAUTH>(new { x = bv.UserId, y = this.USER_PWS, z = this.NewPassword }, Connection.GetConnection()).FirstOrDefault().ReturnMessage;
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { x = bv.UserId, y = this.USER_PWS, z = this.NewPassword }, "", MODULE, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return Message;
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { x = bv.UserId, y = this.USER_PWS, z = this.NewPassword }, "", MODULE, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return ex.Message;
            }
        }



    }
}