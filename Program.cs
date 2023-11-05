namespace GradeCalculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the pass percentage to obtain the final grade");
            double rating = Convert.ToDouble(Console.ReadLine());

            
            CalculateGrade.GradeCalculate(rating);

            Console.WriteLine($"Scored: {CalculateGrade.GradeCalculate(rating)}");

        }
    }
}