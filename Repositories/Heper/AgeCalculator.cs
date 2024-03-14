using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Heper
{
    public class AgeCalculator
    {
        public static int CalculatorAge(DateTime birthDay)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - birthDay.Year;
            if (today.Month < birthDay.Month || (today.Month == birthDay.Month && today.Day < birthDay.Day))
            {
                age--;
            }
            return age;
        }
    }
}
