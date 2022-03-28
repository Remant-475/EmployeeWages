using System;

namespace EmployeeWage
{
    class Company
    {
        public int EmpWage_Per_Hour;
        public int FullTime_WorkingHrs_PerDay;
        public int PartTime_WorkingHrs_PerDay;
        public int Max_Working_Hrs;
        public int Max_Working_Days;
        public String CompanyName;

        public Company(string companyName, int EmpWage_Per_Hour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int Max_Working_Hrs, int Max_Working_Days)
        {
            CompanyName = companyName;
            this.EmpWage_Per_Hour = EmpWage_Per_Hour;
            this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
            this.PartTime_WorkingHrs_PerDay = PartTime_WorkingHrs_PerDay;
            this.Max_Working_Hrs = Max_Working_Hrs;
            this.Max_Working_Days = Max_Working_Days;
        }
    }
}