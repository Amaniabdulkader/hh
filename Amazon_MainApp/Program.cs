using Amazon_Data;
using Amazon_Domain;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Task = Amazon_Domain.Task;

namespace Amazon_MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // I need a code that will craete or use the database
            /*using (AmazonDBContext context = new AmazonDBContext())
            {

                context.Database.EnsureCreated();
            }*/

            ///////Reading From DB    //////////////
            ///

            ///////  writing to db//////////
            ///
            //AddEmployee();
            //AddEmployeeWithTasks();
            string contents = File.ReadAllText("default.json");
         var DefaultEmployees =  JsonSerializer.Deserialize<List<Employee>>(contents);
            using (var context = new AmazonDBContext()) 
            {
                context.Employees.AddRange(DefaultEmployees);
                context.SaveChanges();
              
            
            }

            UpdaeEmployees();

        }

        private static void AddEmployeeWithTasks()
        {
            var firstTask = new Task() {
                Name = "openning the office",
                CreatedDate = DateTime.Now.AddDays(1),
                ClosedDate= DateTime.MinValue 
            };

            var secondTask = new Task()
            {
                Name = "Dealing with the first customer",
                CreatedDate = DateTime.Now.AddDays(1),
                ClosedDate = DateTime.MinValue
            };
            var employee = new Employee() {
                FirstName="Samer",
                LastName="2022/1/5",
                Tasks=new List<Amazon_Domain.Task> { firstTask, secondTask }    
            };
            using (var context = new AmazonDBContext()) { 
              context.Employees.Add(employee);
                context.SaveChanges();
            
            
            }
            
        }

        private static void AddEmployee()
        {
           using( var context = new AmazonDBContext())
            {
                /*var ahmad = new Employee() { FirstName = "samer",
                    LastName ="AboSamra"};*/
                context.Employees.AddRange(
                    new Employee() { FirstName = "Ahmad",
                        LastName = "Alahmad"},
                    new Employee {FirstName = "Mohammad",
                        LastName = "Alahmad"},
                    new Employee
                    {
                        FirstName = "Murad",
                        LastName = "Alahmad"
                    }

                    ); 
                context.SaveChanges();
            }
        }

        private static void UpdaeEmployees()
        {
            using(var context = new AmazonDBContext())
            {
                /*var employees = context.Employees.
                    Include(e => e.Tasks).
                    Where(e=>e.FirstName.Contains("Ahmad")).
                    TagWith("Hello , it is me").
                    ToList();*/

                var employee = context.Employees.
                    Include(e => e.Tasks).
                    FirstOrDefault(e => e.FirstName == "samer");
                employee.LastName = "Alahmad";
               // context.Employees.Update(employee);
                context.SaveChanges();


                /*foreach (var employee in employees)
                {
                    Console.WriteLine(employee.FirstName+ ""+employee.LastName);
                    foreach (var task in employee.Tasks)
                    { Console.WriteLine(task.Name + " " + (task.ClosedDate == DateTime.MinValue ? "Not Done" : "Done")); }
                }*/
            }
           /* private static void deletEmployee()
            {
                using (var context = new AmazonDBContext())
                {
                    
                    var employee = context.Employees.
                        Include(e => e.Tasks(t=>t.closedDate !=DataTime.MinValue)).
                        .thenInclude(t=>t...)
                       where(e=>e.Isdeleted !=true).tolist();
                    
                    context.SaveChanges();
                } }*/

                }
    }
   /* private static void GetEmployee()
    {
        using (var context = new AmazonDBContext())
        {
            var employee =context
                 .Employees.Include(e=>e.Tasks)
                 .Select(e=>new {Id= e.Id,FullName =e.FirstName +""})

            var emps = context.Employees.FromSqlRaw("select * from Employees").ToList();


    } }*/
}