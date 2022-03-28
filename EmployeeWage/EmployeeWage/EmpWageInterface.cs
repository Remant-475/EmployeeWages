using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal interface EmpWageInterface
    {
        void AddCompany(string CompanyName, int EmpWage_Per_Hour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int Max_Working_Hrs, int Max_Working_Days);
        int CalculateWage(string CompanyName);
    }

}
