using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Models
{
    public class Office : Employee
    {
        public Office()
        {
            HourlyWage = 500;
        }
        public override double HourlyWage { get; set; }

        public override double CalculateSalary()
        {
            double salary = WorkingHours * HourlyWage;
            if (WorkingHours > 180)
            {
                int overTime = WorkingHours - 180;
                double overTimeWage = overTime * HourlyWage * 1.5;
                return salary + overTimeWage;
            }
            return salary;
        }
    }
}
