using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApexChallenges.Models
{
    public class TestTableRepo : ITestTable
    {
        private readonly IDbConnection _conn;
        public TestTableRepo(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<TestTable> GetAllData()
        {
            return _conn.Query<TestTable>("SELECT * FROM apexchallenge.test1;");
        }
    }
}
