using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseTVP_Core;

namespace ZCLINIC.Areas.URM.Models
{
    public class Menu
    {
        private const string Module = "URM";

        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public int PageTypeId { get; set; }
        public string MenuText { get; set; }
        public string Description { get; set; }
        public string MenuToolTip { get; set; }
        public int MenuParent { get; set; }
        public int MenuLevel { get; set; }
        public int MenuOrder { get; set; }
        public string ModuleName { get; set; }
        public string Controller { get; set; }
        public string Method { get; set; }
        public string Script { get; set; }
        public string Icon { get; set; }


        public int MenuPermission { get; set; }



        public int R_Privileges { get; set; }

        public int R_save { get; set; }

        public int R_Update { get; set; }

        public int R_delete { get; set; }

        public int R_Print { get; set; }

     
        public int TenantId { get; set; }

  
        public string AppId { get; set; }

  
        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }
        /// <oldMenuWorkForGivingPermission>
        public List<Menu> MenuList { get; set; }

        public int Roles_ID { get; set; }


        private Menu PrepareMenuItem(Menu item, List<Menu> Items)
        {
            item.MenuList = new List<Menu>();
            foreach (var itm in Items.Where(m => m.MenuParent == item.MenuId).ToList<Menu>().OrderBy(o => o.MenuOrder).ToList())
            {
                item.MenuList.Add(PrepareMenuItem(itm, Items));
            }

            return item;
        }

        public List<Menu> PrepareMenu(int RoleId)
        {
            List<Menu> FinalList = new List<Menu>();
            try
            {
                //place your Model Logic and DB Calls here:
                List<Menu> dblist = URM_GetUserMenu(RoleId);
                foreach (var item in dblist.Where(m => m.MenuParent == 0).ToList<Menu>().OrderBy(o => o.MenuOrder).ToList())
                {
                    //Menu menu = PrepareMenuItem(item, dblist);
                    ////modification
                    //if (menu.MenuList.Count != 0)
                    //{
                    //    FinalList.Add(PrepareMenuItem(item, dblist));
                    //}

                    //modification
                   FinalList.Add(PrepareMenuItem(item, dblist));  // remove comment for previous work
                }
                // Logging Here => Type of Log, Message, Data (complete objects or paramters except userid), PageName, Module (for Multiple Areas), Connection to Log DB
              //  Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { UserId }, "", Module, Connection.GetLogConnection(), Environment.MachineName, "", UserId);
                // returning element
                return FinalList;
            }
            catch (Exception ex)
            {
                // Logging Here=> Type of Log, Message, Data (complete objects or paramters except userid), PageName, Module (for Multiple Areas), Connection to Log DB
             //   Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, ex.Message, new { UserId }, "", Module, Connection.GetLogConnection(), Environment.MachineName, "", UserId);
                //returning null, when an error produced
                return FinalList;
            }
        }

        public List<Menu> URM_GetUserMenu(int RoleId)
        {
            try
            {
                //place your Model Logic and DB Calls here:
                List<Menu> Lists = DataBase.ExecuteQuery<Menu>(new { x = RoleId}, Connection.GetConnection());
                // Logging Here=> Type of Log, Message, Data (complete objects or paramters except userid), PageName, Module (for Multiple Areas), Connection to Log DB
              //  Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Info, "", new { UserId }, "", Module, Connection.GetLogConnection(), Environment.MachineName, "", UserId);
                // returning element
                return Lists;
            }
            catch (Exception ex)
            {
                // Logging Here=> Type of Log, Message, Data (complete objects or paramters except userid), PageName, Module (for Multiple Areas), Connection to Log DB
               // Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { UserId }, "", Module, Connection.GetLogConnection(), Environment.MachineName, "", UserId);
                //returning null, when an error produced
                return null;
            }
        }



        public List<Menu> URM_MenuGetAll(BValues bv, string IP, string CInfo)
        {
            try
            {
                List<Menu> retlist = DataBase.ExecuteQuery<Menu>(new { bv.UserId, bv.TenantId, bv.AppId }, Connection.GetConnection());
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return retlist;
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return null;
            }
        }




        public System.Data.DataTable URM_MenuGetAllTable(BValues bv, string IP, string CInfo)
        {
            try
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return DataBase.ExecuteforReport(new { bv.UserId, bv.TenantId, bv.AppId }, Connection.GetConnection(), "URM_MenuGetAllTable");
            }
            catch (Exception ex)
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                return null;
            }
        }



        //------------- New Menu Permission Work-----------------------



        public List<Menu> URM_MenuGetAllByRole(int RoleId, BValues bv, string IP, string CInfo)
        {
            try
            {
                //place your Model Logic and DB Calls here:
                List<Menu> Lists = DataBase.ExecuteQuery<Menu>(new { x = bv.UserId, bv.TenantId, bv.AppId, RoleId }, Connection.GetConnection());
                // Logging Here=> Type of Log, Message, Data (complete objects or paramters except userid), PageName, Module (for Multiple Areas), Connection to Log DB
               /// Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { x = bv.UserId, bv.TenantId, bv.AppId, RoleId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                // returning element
                return Lists;
            }
            catch (Exception ex)
            {
                // Logging Here=> Type of Log, Message, Data (complete objects or paramters except userid), PageName, Module (for Multiple Areas), Connection to Log DB
              ///  Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { x = bv.UserId, bv.TenantId, bv.AppId, RoleId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
                //returning null, when an error produced
                return null;
            }
        }

       














    }
}
