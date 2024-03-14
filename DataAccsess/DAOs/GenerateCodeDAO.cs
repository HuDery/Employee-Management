using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.DAOs
{
    public class GenerateCodeDAO
    {
        private static int counter = 0;

        public static string GenerateEmployeeCode()
        {
            string prefix = "NV";
            DateTime today = DateTime.Now;
            counter++;
            string code = $"{prefix}_{today.Year}_{today.Month}_{today.Day}_{counter}";
            return code;
        }
    }
}
