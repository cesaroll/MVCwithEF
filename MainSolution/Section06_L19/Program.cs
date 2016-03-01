using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section06_L19
{
    class Program
    {
        static void Main(string[] args)
        {
            OrganizationEntities oe = new OrganizationEntities();

            #region CRUD

            #region Create

            //Department dept = new Department();
            //dept.Name = "E-Learning";
            //dept.HOD = "Kate";
            //dept.Gender = "F";

            //oe.Departments.Add(dept);
            //oe.SaveChanges();
            
            #endregion

            #region Read

            //var depts = oe.Departments.ToList();

            //foreach (var item in depts)
            //{
            //    Console.WriteLine("Id:{0}  Name:{1}", item.Id, item.Name);
            //}


            //var deptsMale = oe.Departments.Where(x => x.Gender == "M").ToList();

            //Console.WriteLine("\nDepartments with Male HOD\n");
            //foreach (var d in deptsMale)
            //{
            //    Console.WriteLine("Id:{0}  Name:{1}", d.Id, d.Name);
            //}

            
            #endregion

            #region Update

            //var dept = oe.Departments.Where(x => x.Id == 102).FirstOrDefault();
            //var dept = oe.Departments.FirstOrDefault(x => x.Id == 102);

            //if (dept != null)
            //{
            //    dept.Name = "QA";
            //    dept.HOD = "Denise";
            //    dept.Gender = "F";

            //    oe.SaveChanges();
            //} 
            #endregion

            #region Delete

            //var dept = oe.Departments.FirstOrDefault(x => x.Id == 100);

            //if (dept != null)
            //{
            //    oe.Departments.Remove(dept);

            //    oe.SaveChanges();
            //}
            #endregion

            #endregion

            #region AddRange

            //List<Department> departments = new List<Department>();
            //departments.Add(new Department() { Name = "A", HOD = "A", Gender = "M" });
            //departments.Add(new Department() { Name = "B", HOD = "B", Gender = "F" });
            //departments.Add(new Department() { Name = "C", HOD = "C", Gender = "F" });

            //oe.Departments.AddRange(departments); 

            //oe.SaveChanges();
            #endregion

            #region RemoveRange

            //var result = oe.Departments.Where(x => x.Id >= 105).ToList();
            //oe.Departments.RemoveRange(result);
            //oe.SaveChanges(); 

            #endregion

            #region Entity Splitting
            //oe.People.Add(new Person()
            //   {
            //       Name = "Cesar",
            //       Email = "cesar@mvc.com",
            //       Address = "El Paso"
            //   });

            //oe.SaveChanges(); 
            #endregion

            #region Table Splitting

            //Employee emp = new Employee()
            //{
            //    Name = "Cesar",
            //    Gender = "M",
            //    DOB = DateTime.Parse("01/01/1980"),
            //    DepId = 101,
            //    UpdatedDate = DateTime.Now
            //};

            //emp.SalaryInfo = new SalaryInfo()
            //{
            //    Salary = 105000
            //};

            //oe.Employees.Add(emp);
            //oe.SaveChanges(); 
            #endregion

            #region Function mapping
            //oe.Departments.Add(new Department()
            //   {
            //       Name = "PDG",
            //       HOD = "Rafa",
            //       Gender = "M"
            //   });

            //oe.SaveChanges(); 
            #endregion

            #region Multiple Resultset

            //var result = oe.GetAllTables();

            //var departments = result.ToList();
            //var employees = result.GetNextResult<Employee>().ToList();
            
            #endregion

            #region Multi-User Scenario

            //var d = oe.Departments.FirstOrDefault();
            //Console.WriteLine("Name of Department is: " + d.Name);
            //Console.Write("Change name to: ");
            //d.Name = Console.ReadLine();

            //try
            //{
            //    oe.SaveChanges();
            //}
            //catch (DbUpdateConcurrencyException e)
            //{
            //    ((IObjectContextAdapter)oe).ObjectContext.Refresh(RefreshMode.ClientWins, d);

            //    Console.WriteLine("Last Value of Department is: " + d.Name);

            //    oe.SaveChanges();
            //}


            //Console.ReadLine();

            #endregion

            #region No Tracking Queries

            ////var dept = oe.Departments.FirstOrDefault(x => x.Id == 108);
            //var dept = oe.Departments.AsNoTracking().FirstOrDefault(x => x.Id == 108);
            //dept.Name = "Ritz";

            //string currentValue = oe.Entry(dept).Property(x => x.Name).CurrentValue;
            ////string originalValue = oe.Entry(dept).Property(x => x.Name).OriginalValue;

            //Console.WriteLine("Current Value: " + currentValue);
            ////Console.WriteLine("Original Value: " + originalValue);

            //oe.SaveChanges(); 
            #endregion

        }
    }
}
