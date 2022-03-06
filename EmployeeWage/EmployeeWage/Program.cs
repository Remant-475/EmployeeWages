

int Present = 1;
int Emp_per_rate = 20;
int EmpWage = 0;
int Emphr = 0;
Random random = new Random();
int Employeestatus = random.Next(0, 2);
if (Employeestatus == Present)
{
    Console.WriteLine("Employee is Present");
    Emphr = 8;
}
else
{
    Console.WriteLine("Employee is absent");
    Emphr = 0;
}

EmpWage = Emp_per_rate * Emphr;
Console.WriteLine("Employee daily wage is " + EmpWage);

