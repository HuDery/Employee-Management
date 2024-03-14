using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.DAOs
{
    public class GenerateCodeDAO
    {
        private static int count;

        public static string GenerateEmployeeCode(int count)
        {
            string prefix = "NV";
            DateTime today = DateTime.Now;
            count++;
            string code = $"{prefix}_{today.Year}_{today.Month}_{today.Day}_{count}";
            return code;
        }
    }
}
