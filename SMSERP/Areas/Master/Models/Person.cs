using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseTVP_Core;

namespace ZCLINIC.Areas.Master.Models
{
    public class Person
    {
        private const string Module = "Master";
        [TVP]
        public int PersonId { get; set; }
        [TVP]
        public string FirstName { get; set; }
        [TVP]
        public string LastName { get; set; }
        [TVP]
        public int IsMale { get; set; }
        [TVP]
        public string CNIC { get; set; }
        [TVP]
        public int CountryId { get; set; }
        [TVP]
        public string FullPic { get; set; }
        [TVP]
        public string TNPic { get; set; }
        [TVP]
        public string MobileNo1 { get; set; }
        [TVP]
        public string MobileNo2 { get; set; }
        [TVP]
        public string Address1 { get; set; }
        [TVP]
        public string Address2 { get; set; }
        [TVP]
        public string Email { get; set; }

        [TVP]
        public int TenantId { get; set; }
        [TVP]
        public string AppId { get; set; }
        [TVP]
        public int CreatedBy { get; set; }
        [TVP]
        public int ModifiedBy { get; set; }

        public string ReturnMessage { get; set; }



        public Person Master_PersonGetById(int Id, BValues bv, string IP, string CInfo)
        {
            try
            {
                Person retlist = DataBase.ExecuteQuery<Person>(new { bv.UserId, bv.TenantId, bv.AppId, Id }, Connection.GetConnection()).FirstOrDefault();
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId, Id }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return retlist;
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return null;
            }
        }
        public Person Master_PersonGetByUserId(BValues bv, string IP, string Machine)
        {
            try
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { x = bv.UserId, y = bv.TenantId, z = bv.AppId, a = bv.UserId }, "", Module, Connection.GetLogConnection(), Machine, IP);
                return DatabaseTVP_Core.DataBase.ExecuteQuery<Person>(new { x = bv.UserId, y = bv.TenantId,z = bv.AppId, a= bv.UserId },Connection.GetConnection()).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { x = bv.UserId, y = bv.TenantId, z = bv.AppId, a = bv.UserId }, "", Module, Connection.GetLogConnection(), Machine, IP);
                return null;
            }
        }
    }
}
