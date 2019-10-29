using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        static List<BankAccount> accountList = new List<BankAccount>()
            {
                new BankAccount("Simba", 2000, "Lion", "King"),
                new BankAccount("Mufasa", 10000, "Lion", "King"),
                new BankAccount("Nala", 10000, "Lion", "Queen"),
                new BankAccount("Timon", 200, "Suricate", "Loser"),
                new BankAccount("Pumbaa", 100, "Pig", "Fat Pig"),
            };

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("show")]
        public IActionResult Show()
        {
            BankAccount ba = new BankAccount("Simba", 2000, "Lion", "King");
            return View(ba);
        }

        [Route("htmlraw")]
        public IActionResult HtmlRaw()
        {
            return View();
        }

        [Route("showall")]
        public IActionResult ShowAll()
        {
            ViewBag.Accounts = accountList;
           
            return View();
        }

        [HttpPost]
        [Route("raise")]
        public IActionResult Raise(string name)
        {
            for (int i = 0; i < accountList.Count; i++)
            {
                if(accountList[i].Name.ToLower() == name)
                {
                    if(accountList[i].Status.ToLower() == "king")
                    {
                        accountList[i].Balance = accountList[i].Balance + 100;
                    }
                    else
                    {
                        accountList[i].Balance = accountList[i].Balance + 10;
                    }
                }
            }
            return RedirectToAction("showall");
        }

        [Route("form")]
        public IActionResult Form()
        {
            return View();
        }
    }
}
