namespace EmployeeWageCompute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Full_Time = 1;
            const int Part_Time = 2;
            const int Emp_Rate_Per_Hr = 20;
            int EmpHrs = 0;
            int EmpWage = 0;
            Console.WriteLine("Welcome to Employee Wage Computation");
            Random random = new Random();
            int randomInput = random.Next(0, 3);
            switch (randomInput)
            {
                case Full_Time:
                EmpHrs = 8;
                Console.WriteLine("Employee is Present");
                    break;
            
                case Part_Time:            
                EmpHrs = 4;
                Console.WriteLine("Employee is Present Part-time");
                    break;
                default:
                Console.WriteLine("Employee is Absent");
                    break;
            }
            EmpWage = Emp_Rate_Per_Hr * EmpHrs;
            Console.WriteLine("Employee Wage Per Day:{0}", EmpWage);

        }
    }
}