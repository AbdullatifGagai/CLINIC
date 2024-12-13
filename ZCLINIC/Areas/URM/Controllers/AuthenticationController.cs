using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZCLINIC.Areas.URM.Models;
using System.Web;
using System.Net;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Reflection;

namespace ZCLINIC.Areas.URM.Controllers
{
    [Area("URM")]
    public class AuthenticationController : Controller
    {
       // private MemoryCache memoryCacheInterface;

        public IActionResult Index()
        {
            if (HttpContext.Session.GetUserId() != 0)
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Master" });
            }

            return View(new USERAUTH());
        }

        [HttpPost]
        public ActionResult Authenticate(USERAUTH USERAUTH)
        {
            if (ModelState.IsValid)
            {
              //  var terminals = new Terminal().URM_GetAllAuthenticatedTerminals();
                string Ip = HttpContext.GetIP();
                try
                {
                   
                    //HttpContext.Session.Remove(HttpContext.GetCInfo(), HttpContext.GetIP(), HttpContext.Request.Host.Host);
                    HttpContext.Session.Clear();

                    Response.Cookies.Delete("BValues");
                    //foreach (var item in terminals)
                    //{
                    //   string dns = Dns.GetHostAddresses(item.TerminalDNS)[0].ToString();
                    //if (Ip == "103.217.178.56" ||Ip== "137.59.227.136" || Ip == "175.107.202.4" || Ip == "42.201.198.123" || (Ip == "::1") || Ip == "127.0.0.1" || Ip == Dns.GetHostAddresses(item.TerminalDNS)[0].ToString())
                    //{
                    USERAUTH u = USERAUTH.URM_Login(HttpContext.GetCInfo(), HttpContext.GetIP(), HttpContext.Request.Host.Host);
                            if (u != null)
                            {
                        
                            HttpContext.Session.SetSession(u);
                            return RedirectToAction("Index", "Dashboard", new { area = "Master" });
                       
                       

                        //  u.TenantId = USERAUTH.;


                            }


                    else
                    {
                        return View("Index");
                    }
                        //}

                  //  }
                }
                catch (Exception e)
                {
                    return View("Index");
                }
              }

            return View("Index");

        }


        public IActionResult Logout()
        {


            HttpContext.Session.SetSession(new USERAUTH());
            return RedirectToAction("Index", "Authentication", new { area = "URM" });
                        //    AppId = "ZCLINIC"

            //};






            //HttpContext.Session.SetSession(u);
            //return RedirectToAction("Index", "Authentication", new { area = "URM" });
        }

        public IActionResult AChangePassword()
        {
            return View(new USERAUTH());
        }



        [HttpPost]
        public string UpdatePassword(USERAUTH user)
        {
            return user.URM_ChangePassword(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }




        //public static void Clear(this IMemoryCache cache)
        //{
        //    if (cache == null)
        //    {
        //        throw new ArgumentNullException("Memory cache must not be null");
        //    }
        //    else if (cache is MemoryCache memCache)
        //    {
        //        memCache.Compact(1.0);
        //        return;
        //    }
        //    else
        //    {
        //        MethodInfo clearMethod = cache.GetType().GetMethod("Clear", BindingFlags.Instance | BindingFlags.Public);
        //        if (clearMethod != null)
        //        {
        //            clearMethod.Invoke(cache, null);
        //            return;
        //        }
        //        else
        //        {
        //            PropertyInfo prop = cache.GetType().GetProperty("EntriesCollection", BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Public);
        //            if (prop != null)
        //            {
        //                object innerCache = prop.GetValue(cache);
        //                if (innerCache != null)
        //                {
        //                    clearMethod = innerCache.GetType().GetMethod("Clear", BindingFlags.Instance | BindingFlags.Public);
        //                    if (clearMethod != null)
        //                    {
        //                        clearMethod.Invoke(innerCache, null);
        //                        return;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    throw new InvalidOperationException("Unable to clear memory cache instance of type " + cache.GetType().FullName);
        //}



    }
}



