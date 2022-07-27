using DapperTutorial.Core.Entities;
using DapperTutorial.Core.Interfaces;
using DapperTutorial.Infrastructure.Data;
using System.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperTutorial.Infrastructure.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        DapperDbContext dbContext;
        public EmployeeRepository()
        {
            dbContext = new DapperDbContext();
        }
        public int DeleteById(int id)
        {
            using (IDbConnection conn = dbContext.GetConnection())
            {
                return conn.Execute("DELETE FROM Employee WHERE Id = @deptId", new { deptId = id });
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            using (IDbConnection conn = dbContext.GetConnection())
            {
                string sql = "Select e.Id, e.FirstName, e.LastName, e.Salary, d.Id, d.Name, d.Location" +
                    " From Employee e Inner Join Department d On e.DeptId = d.Id";
                return conn.Query<Employee, Department, Employee>(sql, (e, d) => { e.Dept = d; return e; });
            }
        }

        public Employee GetById(int id)
        {
            using (IDbConnection conn = dbContext.GetConnection())
            {
                return conn.QuerySingleOrDefault<Employee>("SELECT Id, Name, Age FROM Employee WHERE Id = @DeptId", new { DeptId = id });
            }
        }

        public int Insert(Employee obj)
        {
            IDbConnection conn = dbContext.GetConnection();
            return conn.Execute("Insert Into Employee Values( @Id, @Name, @Age, @DeptId)", obj);
    }

        public int Update(Employee obj)
        {
            using (IDbConnection conn = dbContext.GetConnection())
            {
                return conn.Execute("UPDATE Employee set Name = @Name, Age = @Age WHERE id = @Id", obj);
            }
        }
    }
}
