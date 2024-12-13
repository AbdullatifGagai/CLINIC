using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DatabaseTVP_Core;
using ZCLINIC.Areas.Master.Models;
using Logger_Core;

namespace ZCLINIC.Areas.URM.Models
{
    public class User
    {
        private const string Module = "URM";

        //Your Properties for Model Here  

        [TVP]
        public int UserId { get; set; }

        [TVP]
        public string UserCode { get; set; }
       

        [TVP]
        public string UserName { get; set; }
        [TVP]
        public string UPassword { get; set; }
        [TVP]
        public string PssHint { get; set; }
        [TVP]
        public int PersonId { get; set; }
        [TVP]
        public int UserTypeId { get; set; }
        [TVP]
        public bool RemMe { get; set; }
        [TVP]
        public int TenantId { get; set; }
        [TVP]
        public string AppId { get; set; }
        [TVP]
        public int CreatedBy { get; set; }
        [TVP]
        public int ModifiedBy { get; set; }


        //View Only Properties
        
        public Person per { get; set; } =  new Person();
        public string ReturnMessage { get; set; }


        #region View properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int IsMale { get; set; }

        public string CNIC { get; set; }


        public string RoleName { get; set; }


        public int RoleId { get; set; }


        public int EmpId { get; set; }

        #endregion


        public int BranchId { get; set; }
        public User URM_Login(string MachineName, string IP, string host)
        {
            try
            {
                User user = DataBase.ExecuteQuery<User>(new { x = this.UserName, y = this.UPassword, z = host }, Connection.GetConnection()).FirstOrDefault();
               // Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { x = this.UserName, y = this.UPassword }, "", Module, Connection.GetLogConnection(), MachineName, IP, user.UserId);
                return user;
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, "", new { x = this.UserName, y = this.UPassword }, "", Module, Connection.GetLogConnection(), MachineName, IP);
            }
            return null;
        }

        public string URM_UserSave(BValues bv, string IP, string CInfo)
        {
            try
            {
                this.per.Email = this.UserName;
                this.CreatedBy = bv.UserId; this.ModifiedBy = bv.UserId; this.TenantId = bv.TenantId; this.AppId = bv.AppId;
                per.TenantId = bv.TenantId;per.AppId = bv.AppId;per.CreatedBy = bv.UserId;per.ModifiedBy = bv.UserId;
                string Message = DataBase.ExecuteQuery<User>(new { x = this,RoleId,EmpId }, Connection.GetConnection()).FirstOrDefault().ReturnMessage;
                //Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { x = this, RoleId, EmpId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return Message;
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { x = this, RoleId, EmpId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return ex.Message;
            }
        }


        public string URM_UserUpdate(BValues bv, string IP, string CInfo)
        {
            try
            {
                this.ModifiedBy = bv.UserId; this.TenantId = bv.TenantId; this.AppId = bv.AppId;
                per.TenantId = bv.TenantId; per.AppId = bv.AppId;per.ModifiedBy = bv.UserId;
                per.PersonId = this.PersonId;

                string Message = DataBase.ExecuteQuery<User>(new { x = this,per,RoleId,EmpId }, Connection.GetConnection()).FirstOrDefault().ReturnMessage;
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { x = this, per, RoleId, EmpId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return Message;
            }
            catch (Exception ex)
            {
            //    Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { x = this, per, RoleId, EmpId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return ex.Message;
            }
        }

        public User URM_UserGetById(int Id, BValues bv, string IP, string CInfo)
        {
            try
            {
                User ret = DataBase.ExecuteQuery<User>(new { bv.UserId, bv.TenantId, bv.AppId, Id }, Connection.GetConnection()).FirstOrDefault();
                if (ret != null)
                {
                    ret.per = new ZCLINIC.Areas.Master.Models.Person().Master_PersonGetById(Id, bv, IP, CInfo);
                }
              //  Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId, Id }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return ret;
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId, Id }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return null;
            }
        }

        public List<User> URM_UserGetAll(BValues bv, string IP, string CInfo)
        {
            try
            {
                List<User> retlist = DataBase.ExecuteQuery<User>(new { bv.UserId, bv.TenantId, bv.AppId }, Connection.GetConnection());
                //Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return retlist;
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return null;
            }
        }


        public List<User> URM_RoleGetAll(BValues bv, string IP, string CInfo)
        {
            try
            {
                List<User> retlist = DataBase.ExecuteQuery<User>(new { bv.UserId, bv.TenantId, bv.AppId }, Connection.GetConnection());
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return retlist;
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return null;
            }
        }

        //public string URM_UserDelete(int id, BValues bv, string ip, string cInfo)
        //{
        //    //var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

        //    //try
        //    //{
        //    //    string message = DataBase.ExecuteQuery<City>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

        //    //    Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", Module, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

        //    //    return message;
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", Module, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

        //    //    return ex.Message;
        //    //}
        //}




    }
}
