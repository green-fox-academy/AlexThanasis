using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class BankAccountController : Controller
    {
        public IActionResult Simba()
        {
            var bankAccount = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "Animal.Lion"
            };
            return View(bankAccount);
        }

        public IActionResult ShowAllAccounts()
        {
            AccountsOfTheBank bank = new AccountsOfTheBank();
            return View(bank);
        }
    }
}
