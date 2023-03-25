using ApexChallenges.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApexChallenges.Controllers
{
    public class TestTableController : Controller
    {
        private readonly ITestTable repo;
        public TestTableController(ITestTable repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var testTable = repo.GetAllData();

            return View(testTable);
        }
    }
}
