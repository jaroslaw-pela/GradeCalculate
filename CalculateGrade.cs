using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculate
{
    public class CalculateGrade
    {

        public static string GradeCalculate(double percentage)
        {
            if (percentage > 90 && percentage <= 100)
            {
                Console.Clear();
                return "grade A";
            }

            else if (80 < percentage && percentage <= 90)
            {
                Console.Clear();
                return "grade B";
            }

            else if (70 < percentage && percentage <= 80)
            {
                Console.Clear();
                return "grade C";
            }

            else if (60 < percentage && percentage <= 70)
            {
                Console.Clear();
                return "grade D";
            }

            else if (0 <= percentage && percentage <= 60)
            {
                Console.Clear();
                return "grade D";
            }

            else
            {
                return "wartość niepoprawna";
            }

        }

    }
}
