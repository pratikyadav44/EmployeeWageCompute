namespace EmployeeWageCompute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Full_Time = 1;
            const int Part_Time = 2;
            const int Emp_Rate_Per_Hr = 20;
            const int Max_Working_Days = 20;
            const int Max_Working_Hrs = 100;
            int EmpHrs = 0;
            int EmpWage = 0;
            int TotalWage = 0;
            int TotalHrs = 0;
            int day = 1;
            Console.WriteLine("Welcome to Employee Wage Computation");
            Random random = new Random();
            while (day <= Max_Working_Days && TotalHrs < Max_Working_Hrs )
            {
                int randomInput = random.Next(0, 3);
                switch (randomInput)
                {
                    case Full_Time:
                        EmpHrs = 8;
                       // Console.WriteLine("Employee is Present");
                        break;

                    case Part_Time:
                        EmpHrs = 4;
                        //Console.WriteLine("Employee is Present Part-time");
                        break;
                    /*default:
                        Console.WriteLine("Employee is Absent");
                        break;*/
                }
                EmpWage = Emp_Rate_Per_Hr * EmpHrs;
                TotalWage = EmpWage + TotalWage;
                TotalHrs = EmpHrs + TotalHrs;
                Console.WriteLine("Employee Wage Per Day{0}:{1}",day, EmpWage);
                day++;
            }
            Console.WriteLine("Total Wage For {0} days and {1} Hrs is: {2}",(day - 1),TotalHrs, TotalWage);
        }   
    }
}