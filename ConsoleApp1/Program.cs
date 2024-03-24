using CSProjeDemo2.Abstract;
using CSProjeDemo2.Models;

try
{

	List<Employee> employeeList = FileRead.EmployeeListRead("employee.json");
    Payroll.CreatePayroll(employeeList);
    Payroll.WorkingLessEmployee(employeeList);
}
catch (Exception ex)
{

    Console.WriteLine("Error " + ex.Message);
}