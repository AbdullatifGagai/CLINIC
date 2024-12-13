using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ZCLINIC
{
    public static class SessionExt
    {
        public static int GetUserId(this ISession context)
        {

            if (context.GetString("BValue") != null)
            {
                return Convert.ToInt32(context.GetString("BValue").Split(new char[] { ',' }).ElementAt(0));
            }
            return 0;
        }

        public static int GetRoleId(this ISession context)
        {

            if (context.GetString("BValue") != null)
            {
                return Convert.ToInt32(context.GetString("BValue").Split(new char[] { ',' }).ElementAt(3));
            }
            return 0;
        }


        public static int GetTenantId(this ISession context)
        {

            if (context.GetString("BValue") != null)
            {
                return Convert.ToInt32(context.GetString("BValue").Split(new char[] { ',' }).ElementAt(1));
            }
            return 0;
        }
        public static BValues GetBValues(this ISession context)
        {
            if (context.GetString("BValue") != null)
            {
                List<string> VList = context.GetString("BValue").Split(new char[] { ',' }).ToList();
                //return new BValues() { UserId = Convert.ToInt32(VList.ElementAt(0)), TenantId = Convert.ToInt32(VList.ElementAt(1)), AppId = VList.ElementAt(2) };
                return new BValues() { UserId = Convert.ToInt32(VList[0]), TenantId = Convert.ToInt32(VList[1]), AppId = VList[2], RoleId = Convert.ToInt32(VList[3]) };
            }
            return new BValues() { UserId = 1, TenantId = 1, AppId = "ZCLINIC", RoleId = 1 };
        }



        public static string GetIP(this HttpContext context)
        {
            return context.Connection.RemoteIpAddress.ToString();
        }

        public static string GetCInfo(this HttpContext context)
        {
            return new ClientInfo.UserAgent(context.Request.Headers["User-Agent"]).BasicInfo;
        }

        public static string GetPageURL(this HttpContext context)
        {
            return context.Request.Path.Value;
        }

        public static void SetSession(this ISession session, ZCLINIC.Areas.URM.Models.USERAUTH u)
        {
           // string s = u.User_id.ToString() + "," + u.TenantId.ToString() + ',' + u.AppId;
            string s = u.User_id.ToString() + "," + u.TenantId.ToString() + ',' + u.AppId + ','+ u.Role_ID;


            session.SetString("BValue", s);
      
        
        
        
        
        
        
        }



     



        }
    }
