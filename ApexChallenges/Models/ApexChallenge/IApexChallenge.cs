using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApexChallenges.Models.ApexChallenge
{
    public interface IApexChallenge
    {
        public IEnumerable<ApexChallenge> GetAllData();
    }
}
