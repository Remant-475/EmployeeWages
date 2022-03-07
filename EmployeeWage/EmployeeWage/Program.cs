



namespace EmployeeWage
{
    class program
    {
        public const int Full_Time = 1;
        public const int Part_time = 2;
        public const int Emp_Hr_Per_Rate = 20;
        public const int Num_of_Working_Days = 20;

        public static void Main(String[] args)

        {
            Console.WriteLine("Welcome to Employee Wage Calculation");
            int empHr = 0;
            int empwage = 0;
            int totalEmpwage = 0;
            for (int day = 0; day < Num_of_Working_Days; day++)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case Part_time:
                        empHr = 4;
                        break;
                    case Full_Time:
                        empHr = 8;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                empwage = (Emp_Hr_Per_Rate * empHr);
                totalEmpwage += empwage;
                Console.WriteLine("Daily Wage is :" + empwage);

            }
            Console.WriteLine("Total Wage:" + totalEmpwage);
        }
    }
}









