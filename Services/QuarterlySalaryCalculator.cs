using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quete_InterjectionDep.Services
{
    public class QuarterlySalaryCalculator : ISalaryCalculator
    {
        public Double CalculateSalary(Double yearlyAmount)
        {
            return yearlyAmount / 4;
        }
    }
}
