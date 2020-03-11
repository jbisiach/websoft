using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SO7_Web.Models;
using SO7_Web.Services;

namespace SO7_Web.Controllers
{
    public class API : Controller
    {

        //Get Method
        [HttpGet ("/accounts")]
        public ActionResult Accounts()
        {
            List<Account> data = FileReader.ReadAccounts();
            Console.WriteLine("output" + data);
            Console.WriteLine("output2" + data[0]);
            Console.WriteLine("output3" + data[0].balance);
            return Json(data);

            // There is a bug somewhere with the return statement which can't be found.
        }

        //Get Method
        [HttpGet("/accounts/{number}")]
        public ActionResult Number(int number)
        {

            List<Account> data = FileReader.ReadAccounts();
            Console.WriteLine("output" + data);
            Console.WriteLine("output2" + data[0]);
            Console.WriteLine("output3" + data[0].balance);
            foreach (var account in data)
            {
                if(account.number == number)
                {
                    return Ok(account);
                  
                }


            }


            return Ok("You SUCK WRITE A PROPER FUCKING NUMBER DICKHEAD");


         
        }
    }
}