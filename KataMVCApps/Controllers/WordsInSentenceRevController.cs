using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KataMVCApps.Models;

namespace KataMVCApps.Controllers
{
    public class WordsInSentenceRevController : Controller
    {
        // GET: WordsInSentenceRev
        public ActionResult WordsInSentenceRev()
        {
            WordsInSentenceRev wisr = new WordsInSentenceRev();

            return View(wisr);
        }

        [HttpPost]
        public ActionResult WordsInSentenceRev(WordsInSentenceRev model)
        {
            model.wordRev = revW(model.userInput);

            return View(model);
        }

        public static string revW(string userInput)
        {
            string wordRev = string.Join(" ", userInput.Split(' ').Select(s => new String(s.Reverse().ToArray())));
            return wordRev;
        }
    }
}