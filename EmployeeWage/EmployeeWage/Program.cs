
namespace EmployeeWage
{
    class EmployeeWageComputation
    {
        public const int Full_Time = 1;
        public const int Part_time = 2;
        private float Emp_Hr_Per_Rate = 20;
        public  int Num_of_Working_Days = 20;
        public  int Max_Hr_Month = 100;
        public const int Absent = 0;
        float EmpDailyWage = 0;
        public float Totalwage = 0;
        public  int FullTime_WorkingHrs_PerDay = 8;
        public  int PartTime_WorkingHrs_PerDay = 4;
       


        public EmployeeWageComputation(int Emp_Hr_Per_Rate, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int Max_Hr_Month, int Num_of_Working_Days)
        {
            this.Emp_Hr_Per_Rate = Emp_Hr_Per_Rate;
            this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
            this.PartTime_WorkingHrs_PerDay = PartTime_WorkingHrs_PerDay;
            this.Max_Hr_Month = Max_Hr_Month;
            this.Num_of_Working_Days = Num_of_Working_Days;

        }
        private int IsEmployePresent()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            return empcheck;
        }
        public void CalculateWage()
        {
            int DayNumber = 1;
            int EmpHr = 0;
           
            int TotalWorkingHrs = 0;
           
            while (DayNumber<=Num_of_Working_Days && TotalWorkingHrs<=Max_Hr_Month)
            {
                switch (IsEmployePresent())

                {
                    case Full_Time:
                        EmpHr = FullTime_WorkingHrs_PerDay;
                        break;

                    case Part_time:
                        EmpHr = PartTime_WorkingHrs_PerDay;
                        break;
                    case Absent:
                        EmpHr = 0;
                        break;


                }
                EmpDailyWage = EmpHr * Emp_Hr_Per_Rate;
                Totalwage += EmpDailyWage;
                DayNumber++;
                 TotalWorkingHrs += EmpHr;

            }
            Console.WriteLine("Total working days :" + (DayNumber - 1) + "\n Totalworking hours : " + TotalWorkingHrs);
            Console.WriteLine("Total Wage :" + Totalwage);

        }
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Computation program ");
            EmployeeWageComputation employeeWageComputation = new EmployeeWageComputation(20, 8, 4, 100, 20);
            employeeWageComputation.CalculateWage();
        }
 
    } }

       








