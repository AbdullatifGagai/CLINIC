using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseTVP_Core;


namespace ZCLINIC
{
    public class UserRights
    {

        public int AccessType { get; set; }

        public static bool URM_AddNew_IsAuthenticated(int  RoleId, string MenuId)
        {
            if (DataBase.ExecuteQuery<UserRights>(new {x = RoleId, y = MenuId}, Connection.GetConnection()).FirstOrDefault().AccessType == 1)
            {
               
                return true;
            }

            
            return false;
        }

        public static bool URM_Update_IsAuthenticated(int RoleId, string MenuId)
        {
            if (DataBase.ExecuteQuery<UserRights>(new { x = RoleId, y = MenuId }, Connection.GetConnection()).FirstOrDefault().AccessType == 1)
            {

                return true;
            }


            return false;
        }

        public static bool URM_Delete_IsAuthenticated(int RoleId, string MenuId)
        {
            if (DataBase.ExecuteQuery<UserRights>(new { x = RoleId, y = MenuId }, Connection.GetConnection()).FirstOrDefault().AccessType == 1)
            {

                return true;
            }


            return false;
        }
   
    
    
     public static bool URM_Print_IsAuthenticated(int RoleId, string MenuId)
        {
            if (DataBase.ExecuteQuery<UserRights>(new { x = RoleId, y = MenuId }, Connection.GetConnection()).FirstOrDefault().AccessType == 1)
            {

                return true;
            }


            return false;
        }
   
    
    
    
    
    
    
    
    
    }
}
