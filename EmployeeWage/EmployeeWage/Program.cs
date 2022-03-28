using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UC8 Employees monthly wage using Function for Multiple companies
            Console.WriteLine("Welcome to Employee Wage Computation!");
            Console.WriteLine();
            EmployeeWages Wage = new EmployeeWages();
            Wage.AddCompany("TATA", 20, 8, 4, 100, 20);
            Wage.AddCompany("Mahindra", 40, 8, 4, 100, 40);
            Wage.AddCompany("Reliance", 80, 8, 4, 100, 50);

            // UC10 Employee monthly wage using array
            int[] Emwages = new int[3];
            Emwages[0] = Wage.CalculateWage("Reliance");
            Emwages[1] = Wage.CalculateWage("TATA");
            Emwages[2] = Wage.CalculateWage("Mahindra");
           
            
            ArrayList CompanyWages = new ArrayList();
            CompanyWages.Add(Wage.CalculateWage("Reliance"));
            CompanyWages.Add(Wage.CalculateWage("TATA"));
            CompanyWages.Add(Wage.CalculateWage("Mahindra"));

            foreach (var item in CompanyWages)
            {
                Console.WriteLine(item);
            }

        }
    }
}