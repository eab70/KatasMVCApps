using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KataMVCApps.Models; 

namespace KataMVCApps.Controllers
{
    public class UnsplicedController : Controller
    {
        // GET: Unspliced
        public ActionResult Unspliced()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UnsplicedResult(UnsplicedModel model)
        {
            model.unsplicedOut = RemoveSlash(model.input);
            return View(model);            
        }

        public static string RemoveSlash(string str)
        {
            int str1 = str.IndexOf(@"\\");
            int str2 = str.IndexOf(@"\n");
            string str3 = str.Replace("\\", "");
            string str5 = str3.Replace("n", "");

            if (str1 + 2 == str2)
            {
                return str5;
            }

            else
                return str;

        }

    }
}