using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Models
{
    public class Manage : Employee
    {
        private const double MinWage = 500;
        public override double HourlyWage {
            get => base.HourlyWage; set
            {
                if (value > MinWage)
                    base.HourlyWage = value;
                else
                    base.HourlyWage = MinWage;
                    
            }
            
        }
        public double Bonus { get; set; }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() + Bonus;
        }
    }
}






