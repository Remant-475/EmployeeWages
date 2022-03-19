using System;
using System.Collections.Generic;

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
    class EmployeeWageComputaion
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

        public void CalculateWage(string CompanyName)
        {
            int EmpWorkingHrs=0;
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
            Console.WriteLine("Total working days : "+ (DayNumber)+"\nTotal working hours :"+ TotalWorkingHrs+"\n Total emoloyee wage: "+ TotalWage);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // UC8 Employees monthly wage using Function for Multiple companies
            Console.WriteLine("Welcome to Employee Wage Computation!");
            Console.WriteLine();
            EmployeeWageComputaion wage = new EmployeeWageComputaion();
            wage.AddCompany("TATA", 20, 8, 4, 100, 20);
            wage.AddCompany("Mahindra", 30, 8, 4, 100, 20);
            wage.CalculateWage("Tata");
            wage.CalculateWage("Mahindra");
        }
    }
}