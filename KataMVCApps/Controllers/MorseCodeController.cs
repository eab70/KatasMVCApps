using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using KataMVCApps.Models; 

namespace KataMVCApps.Controllers
{
    public class MorseCodeController : Controller
    {
        // GET: MorseCode
        public ActionResult MorseCode()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MorseCodeResult(MorseCodeModel model)
        {
            model.result = ChangeToMorse(model.input);
            return View(model);
        }

        public static string ChangeToMorse(string str)
        {
            string str2 = str.ToUpper();

            Dictionary<string, string> mcode = new Dictionary<string, string>();
            mcode.Add("A", ". -");
            mcode.Add("B", "- . . .");
            mcode.Add("C", "- . - .");
            mcode.Add("D", "- . .");
            mcode.Add("E", ".");
            mcode.Add("F", ". . - .");
            mcode.Add("G", "- - .");
            mcode.Add("H", ". . . .");
            mcode.Add("I", ". .");
            mcode.Add("J", ". - - -");
            mcode.Add("K", "- . -");
            mcode.Add("L", ". - . .");
            mcode.Add("M", "- -");
            mcode.Add("N", "- .");
            mcode.Add("O", "- - -");
            mcode.Add("P", ". - - .");
            mcode.Add("Q", "- - . -");
            mcode.Add("R", ". - .");
            mcode.Add("S", ". . .");
            mcode.Add("T", "-");
            mcode.Add("U", ". . -");
            mcode.Add("V", ". . . -");
            mcode.Add("W", ". - -");
            mcode.Add("X", "- . . -");
            mcode.Add("Y", "- . - -");
            mcode.Add("Z", "- - . .");


            var decoded = new StringBuilder(str2);

            foreach (var s in mcode)
                decoded.Replace(s.Key, s.Value);

            var result = decoded.ToString();
            return result;
            
        }
    }
}