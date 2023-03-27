using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApexChallenges.Models.ApexChallenge
{
    public class ApexChallengeRepo : IApexChallenge
    {
        private readonly IDbConnection _conn;
        public ApexChallengeRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<ApexChallenge> GetAllData()
        {
            throw new NotImplementedException();
        }
    }
}
