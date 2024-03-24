using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Abstract
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        
        public int WorkingHours { get; set; }

        public virtual double HourlyWage { get; set; }

        public virtual double CalculateSalary()
        {
            return HourlyWage*WorkingHours;
        }

    }
}


