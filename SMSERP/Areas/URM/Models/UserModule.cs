using DatabaseTVP_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZCLINIC.Areas.URM.Models
{
	public class UserModule
	{

		private const string Module = "URM";

		//Your Properties for Model Here
		[TVP]
		public int UserModuleId { get; set; }
		[TVP]
		public int UserId { get; set; }
		[TVP]
		public int NameId { get; set; }

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
		public string UserName { get; set; }
		public string ModuleName { get; set; }
		public string ModuleShortName { get; set; }

		public string URM_UserModuleSave(BValues bv, string IP, string CInfo)
		{
			try
			{
				this.CreatedBy = bv.UserId; this.ModifiedBy = bv.UserId; this.TenantId = bv.TenantId; this.AppId = bv.AppId;
				string Message = DataBase.ExecuteQuery<UserModule>(new { x = this }, Connection.GetConnection()).FirstOrDefault().ReturnMessage;
				Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { x = this }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
				return Message;
			}
			catch (Exception ex)
			{
				Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { x = this }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
				return ex.Message;
			}
		}


		public string URM_UserModuleUpdate(BValues bv, string IP, string CInfo)
		{
			try
			{
				this.ModifiedBy = bv.UserId; this.TenantId = bv.TenantId; this.AppId = bv.AppId;
				string Message = DataBase.ExecuteQuery<UserModule>(new { x = this }, Connection.GetConnection()).FirstOrDefault().ReturnMessage;
				Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { x = this }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
				return Message;
			}
			catch (Exception ex)
			{
				Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { x = this }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
				return ex.Message;
			}
		}

		public UserModule URM_UserModuleGetById(int Id, BValues bv, string IP, string CInfo)
		{
			try
			{
				UserModule ret = DataBase.ExecuteQuery<UserModule>(new { bv.UserId, bv.TenantId, bv.AppId, Id }, Connection.GetConnection()).FirstOrDefault();
				Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId, Id }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
				return ret;
			}
			catch (Exception ex)
			{
				Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId, Id }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
				return null;
			}
		}

		public List<UserModule> URM_UserModuleGetAll(BValues bv, string IP, string CInfo)
		{
			try
			{
				List<UserModule> retlist = DataBase.ExecuteQuery<UserModule>(new { bv.UserId, bv.TenantId, bv.AppId }, Connection.GetConnection());
				Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
				return retlist;
			}
			catch (Exception ex)
			{
				Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
				return null;
			}
		}

		public System.Data.DataTable URM_UserModuleGetAllTable(BValues bv, string IP, string CInfo)
		{
			try
			{
				Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Posetive, "", new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
				return DataBase.ExecuteforReport(new { bv.UserId, bv.TenantId, bv.AppId }, Connection.GetConnection(), "URM_UserModuleGetAllTable");
			}
			catch (Exception ex)
			{
				Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, ex.Message, new { bv.UserId, bv.TenantId, bv.AppId }, "", Module, Connection.GetLogConnection(), CInfo, IP, bv.UserId);
				return null;
			}
		}



	}
}
