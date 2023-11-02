using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculate
{
    public class CalculateGrade
    {

        public static string GradeCalculate (double percentage)
        {
            if (0 > percentage && percentage < 10)
            {
                return "a";
            }
            else if (0 > percentage && percentage < 10)
            { 
                return "b"; 
            }
            else if (0 > percentage && percentage < 10)
            { 
                return "c";
            }
            else if (0 > percentage && percentage < 10)
            { 
                return "d";
            }
            else if (0 > percentage && percentage < 10)
            { 
                return "e";
            }
      
        }

    }
}
