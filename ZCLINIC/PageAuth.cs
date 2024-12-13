using System.Linq;
using DatabaseTVP_Core;

namespace ZCLINIC
{
    public class PageAuth
    {
        public int AccessType { get; set; }

        //public static bool URM_IsAuthenticated(int UserId, string PageURL, string IP, string CInfo)
        //{
        //    //if (DataBase.ExecuteQuery<PageAuth>(new { x = UserId, y = PageURL, z = IP, w = CInfo }, Connection.GetConnection()).FirstOrDefault().AccessType != 1)
        //    //{
        //    //    return true;
        //    //}
        //    //return false;
        //}
    }
}
