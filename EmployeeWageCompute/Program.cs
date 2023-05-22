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
            int randomInput = random.Next(0, 2);
            if (Full_Time == randomInput)
            {
                EmpHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            else if (Part_Time == randomInput)
            {
                EmpHrs = 4;
                Console.WriteLine("Employee is Present Part-time");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            EmpWage = Emp_Rate_Per_Hr * EmpHrs;
            Console.WriteLine("Employee Wage Per Day:{0}", EmpWage);

        }
    }
}