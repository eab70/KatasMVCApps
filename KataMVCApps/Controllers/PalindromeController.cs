using KataMVCApps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KataMVCApps.Controllers
{
    public class PalindromeController : Controller
    {
        // GET: Palindrome
        public ActionResult Palindrome()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PalindromeCheck(PalindromeModel model)
        {
            model.result = PalindromeCk(model.input);

            return View(model);
        }


        public static string PalindromeCk(string str)
        {
            string resultb = "";
            string resultpal = "";
            string newWord = "";

            foreach (var letter in str)
            {
                if (letter != ' ')
                {
                    newWord += letter;
                }
            }

            for (int i = newWord.Length - 1; i >= 0; i--)
            {
                resultb += newWord[i];
            }

            if (resultb.ToUpper() == newWord.ToUpper())
            {
                resultpal = "The string " + "'" + str +"'" + " is a palindrome.";
            }
            else
            {
                resultpal = "The string " + "'" + str +"'" + " is not a palindrome.";
            }

            return resultpal;
        }
    }
}