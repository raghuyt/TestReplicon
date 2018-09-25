using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepliconTestApp.Models
{
    public class vmFactorial
    {
        public string recursionStr { get; set; }
        public string IterationStr { get; set; }
        public string errorMsg { get; set; }

        public int recursionFactorial(int number)
        {
            if (number == 0)
                return 1;
            return number * recursionFactorial(number - 1);

        }
        public int Iterationfactorial(int n)
        {
            int res = 1, i;

            for (i = 2; i <= n; i++)
                res *= i;
            return res;
        }
    }
}