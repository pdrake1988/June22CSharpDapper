namespace LINQLearningJune
{
    public class ManageEmployees
    {
        EmployeeRepository _emp;
        public ManageEmployees()
        {
            _emp = new EmployeeRepository();
        }
        public void Run()
        {
            Demo();
        }

        public string FunctionForSelect(Employee emp)
        {
            return emp.Name;
        }
        public void Demo()
        {
            // Select * From Employees

            //foreach(var emp in _emp.GetEmployees())
            //{
            //    Console.WriteLine(emp.Name);
            //}
            //var result =
            //    from emp in _emp.GetEmployees()
            //    select emp;

            //var resultLam = _emp.GetEmployees().Select(emp => emp.Name);

            //var resultWithFunction = _emp.GetEmployees().Select(FunctionForSelect);


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            // Using Anonymous Objects as a quick variable to contain usable data 
            //var result = _emp.GetEmployees().Select(emp => new { Id = emp.Id, Name = emp.Name, Salary = emp.Salary });

            //var resultQuery = from emp in _emp.GetEmployees()
            //                  select new
            //                  {
            //                      Id = emp.Id,
            //                      Name = emp.Name,
            //                      Salary = emp.Salary
            //                  };

            //    var result = _emp.GetEmployees().Select(emp => emp.Department).Distinct();

            //    var resultQuery = (from emp in _emp.GetEmployees()
            //                       select emp.Department).Distinct();
            //

            var result = _emp.GetEmployees().Select(emp => new { Id = emp.Id, Name = emp.Name, Salary = emp.Salary })
                .SingleOrDefault(emp => emp.Name == "Fred") ?? new { Id = -1, Name = "NA", Salary= -1M};

            Console.WriteLine(result);

            var First = _emp.GetEmployees().First(emp => emp.Id == 5);
            var FirstOrDef = _emp.GetEmployees().Select(emp => new {Id = emp.Id}).FirstOrDefault(emp => emp.Id ==5) ?? new { Id = -1 };

            //Where filtering
            var whereL = _emp.GetEmployees().Where(emp => emp.Salary > 5000 & emp.Department != "IT")
                .Select(emp => new { Id = emp.Id, Name = emp.Name, Salary = emp.Salary});

            var whereQ = (from emp in _emp.GetEmployees()
                         where emp.Salary > 5000 && emp.Department != "IT"
                         select new
                         {
                             Id = emp.Id,
                             Name = emp.Name,
                             Salary = emp.Salary
                         }); //Even if use query syntax, as long as you wrap it with a "()" you can apply Single/First/FirstorDefau...


            var groupByQ = from emp in _emp.GetEmployees()
                           group emp by emp.Department;

            var groupBy = _emp.GetEmployees().GroupBy(emp => emp.Department);


            var AveM = _emp.GetEmployees().Average(emp => emp.Salary);
            Console.WriteLine(AveM);

            var l = _emp.GetEmployees();


            //First, FirstOrDefault, Single, SingleOrDefault

            var orderByEx = from employee in _emp.GetEmployees()
                            orderby employee.Salary descending, employee.Name descending
                            select new
                            {
                                Name = employee.Name,
                                Salary = employee.Salary
                            };
            foreach(var emp in orderByEx)
            {
                Console.WriteLine(emp);
            }


            // Immediate Execution
            // Deferred Execution: Default

            string[] names = new string[] { "Jacob", "Khanh", "Paul", "Tianyi", "Tao" };
            Console.WriteLine("Deferred Execution");
            var query = names.Where(name => name[0] == 'T').ToList();

            //Immediate execution forces query to run after the variable is made
            //Deferred execution will run the query only when called or needed

            foreach (var item in query)
            {
                names[4] = "Jessie";
                Console.WriteLine(item);
            }
        }
    }
}
