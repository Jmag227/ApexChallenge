using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApexChallenges.Models
{
    public interface ITestTable
    {
        public IEnumerable<TestTable> GetAllData();
    }
}
