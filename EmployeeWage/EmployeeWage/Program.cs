
namespace EmployeeWage
{
    class program
    {
        public const int Full_Time = 1;
        public const int Part_time = 2;
        public const int Emp_Hr_Per_Rate = 20;
        public const int Num_of_Working_Days = 20;
        public const int Max_Hr_Month = 100;


        public static void Main(String[] args)

        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            int EmpHr = 0;
            int totalworkingDays = 0;
            int totalEmpHr = 0;
            while (totalEmpHr <= Max_Hr_Month && totalworkingDays < Num_of_Working_Days)
            {
                totalworkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case Part_time:
                        EmpHr = 4;
                        Console.WriteLine("Employee is Present");
                        Console.WriteLine("Employee is Part time");
                        break;

                    case Full_Time:
                        EmpHr = 8;
                        Console.WriteLine("Employee is Present");
                        Console.WriteLine("Employee is Full time");
                        break;
                    default:
                        EmpHr = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                totalEmpHr += EmpHr;
                Console.WriteLine("Days=" + totalworkingDays + "EmpHrs" + EmpHr);

            }
            int TotalEmpwage = (Emp_Hr_Per_Rate * totalEmpHr);
            Console.WriteLine("Total Emp Wage:" + TotalEmpwage);
        }
    }
}









