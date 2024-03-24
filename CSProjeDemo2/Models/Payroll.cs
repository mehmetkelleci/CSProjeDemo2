using CSProjeDemo2.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Models
{
    public class Payroll
    {
        public static void CreatePayroll(List<Employee> employeeList)
        {
            foreach (var employee in employeeList)
            {
                double salary = employee.CalculateSalary();
                string fileName = $"{employee.Name}_Payroll_{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}.json";
                string json = JsonConvert.SerializeObject(new
                {
                    EmployeeName = employee.Name,
                    WorkingHours = employee.WorkingHours,
                    Salary = salary,
                    TotalSalary = salary,
                }, Formatting.Indented);
                File.WriteAllText(fileName, json);
            }
        }

        public static void WorkingLessEmployee(List<Employee> employeeList)
        {
            Console.WriteLine("Personnel working less than 150 hours");
            foreach (var employee in employeeList)
            {
                if(employee.WorkingHours<150)
                {
                    Console.WriteLine($"{employee.Name} : {employee.SurName} : {employee.WorkingHours} ");
                }
            }
        }

    }
}
