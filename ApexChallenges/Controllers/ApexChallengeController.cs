using ApexChallenges.Models.ApexChallenge;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApexChallenges.Controllers
{
    public class ApexChallengeController : Controller
    {
        private readonly IApexChallenge repo;
        public ApexChallengeController(IApexChallenge repo)
        {
            SS
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
