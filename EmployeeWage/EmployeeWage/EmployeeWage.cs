using System;
using System.Collections.Generic;

namespace EmployeeWage
{

    class EmployeeWages

    {

        private const int _IsFullTime = 1;
        private const int _IsPartTime = 2;
        private int TotalWage = 0;
        float EmpDailyWage = 0;
        private Dictionary<string, Company> companies = new Dictionary<string, Company>();

        public void AddCompany(string CompanyName, int EmpWage_Per_Hour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int Max_Working_Hrs, int Max_Working_Days)
        {
            Company company = new Company(CompanyName.ToLower(), EmpWage_Per_Hour, FullTime_WorkingHrs_PerDay, PartTime_WorkingHrs_PerDay, Max_Working_Hrs, Max_Working_Days);
            companies.Add(CompanyName.ToLower(), company);
        }

        private int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        public int CalculateWage(string CompanyName)
        {
            int EmpWorkingHrs = 0;
            int TotalWorkingHrs = 0;
            int DayNumber = 0;

            if (!companies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company don't exist");
            companies.TryGetValue(CompanyName.ToLower(), out Company company);

            while (TotalWorkingHrs <= company.Max_Working_Hrs && DayNumber < company.Max_Working_Days)
            {
                switch (IsEmployeePresent())
                {
                    case _IsFullTime:
                        EmpWorkingHrs = company.FullTime_WorkingHrs_PerDay;
                        break;
                    case _IsPartTime:
                        EmpWorkingHrs = company.PartTime_WorkingHrs_PerDay;
                        break;
                    default:
                        EmpWorkingHrs = 0;
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * company.EmpWage_Per_Hour;
                TotalWorkingHrs += EmpWorkingHrs;
                DayNumber++;
            }
            TotalWage = TotalWorkingHrs * company.EmpWage_Per_Hour;
            Console.WriteLine("Company name: " + CompanyName);
            Console.WriteLine("Total working days : " + (DayNumber) + "\nTotal working hours :" + TotalWorkingHrs + "\n Total emoloyee wage: " + TotalWage);
            return TotalWage;
        }
    }
}