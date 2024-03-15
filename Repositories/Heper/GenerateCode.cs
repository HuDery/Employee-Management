using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Heper
{
    public class GenerateCode
    {
        private static int count;

        public static string GenerateEmployeeCode(int count)
        {
            //[NV] _[YYYY]_[MM]_[DD]_[n]
            string prefix = "NV";
            DateTime today = DateTime.Now;
            count++;
            string code = $"{prefix}_{today.Year}_{today.Month}_{today.Day}_{count}";
            return code;
        }
    }
}
