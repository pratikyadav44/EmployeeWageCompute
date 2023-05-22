namespace EmployeeWageCompute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Is_Present = 1;
            Console.WriteLine("Welcome to Employee Wage Computation");
            Random random = new Random();
            int randomInput = random.Next(0, 2);
            if (Is_Present == randomInput)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}