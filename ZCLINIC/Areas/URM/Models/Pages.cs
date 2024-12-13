using DatabaseTVP_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZCLINIC.Areas.URM.Models
{
    public class Pages
    {
        private const string Module = "URM";

        [TVP]
        public int PageId { get; set; }
        [TVP]
        public string PageName { get; set; }
        [TVP]
        public string PageDescription { get; set; }
        [TVP]
        public int MenuId { get; set; }
        [TVP]
        public int PageTypeId { get; set; }

        [TVP]
        public int TenantId { get; set; }
        [TVP]
        public string AppId { get; set; }
        [TVP]
        public int CreatedBy { get; set; }
        [TVP]
        public int ModifiedBy { get; set; }

        //View Only Properties
        public string ReturnMessage { get; set; }

        #region PagepermissionViewprops
        public string IsCreate { get; set; }
        public string IsUpdate { get; set; }
        public string IsRead { get; set; }

        public string IsDelete { get; set; }

        public string IsModal { get; set; }

        public string MenuName { get; set; }

        public string IsView { get; set; }

        public int CreateId { get; set; }
        public int UpdateId { get; set; }
        public int ReadId { get; set; }

        public int DeleteId { get; set; }

        public int ModalId { get; set; }

        public int ViewId { get; set; }

        #endregion
        public List<Pages> URM_GetPagesByRoleId(BValues bv, string IP, string CInfo,int RoleId)
        {
            try
                {
                List<Pages> retlist = DataBase.ExecuteQuery<Pages>(new { bv.UserId, bv.TenantId, bv.AppId,RoleId }, Connection.GetConnection());
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId,RoleId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return retlist;
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId,RoleId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return null;
            }
        }

        public List<Pages> URM_PagesGetAll(BValues bv, string IP, string CInfo)
        {
            try
            {
                List<Pages> retlist = DataBase.ExecuteQuery<Pages>(new { bv.UserId, bv.TenantId, bv.AppId }, Connection.GetConnection());
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return retlist;
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return null;
            }
        }


        public List<Pages> URM_ChildPagesGetAll(BValues bv, string IP, string CInfo)
        {
            try
            {
                List<Pages> retlist = DataBase.ExecuteQuery<Pages>(new { bv.UserId, bv.TenantId, bv.AppId }, Connection.GetConnection());
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return retlist;
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return null;
            }
        }

        public List<Pages> URM_GetMenuPages(BValues bv, string IP, string CInfo)
        {
            try
            {
                List<Pages> retlist = DataBase.ExecuteQuery<Pages>(new { bv.UserId, bv.TenantId, bv.AppId }, Connection.GetConnection());
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return retlist;
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return null;
            }
        }

    }
}
