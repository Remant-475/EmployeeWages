

int Present = 1;
int FullTime = 1;
int Emp_per_rate = 20;
int EmpWage = 0;
int EmpHr = 0;
Random random = new Random();
Random random1 = new Random();
int Employeestatus = random.Next(0, 2);
int Employee_Time=random1.Next(0, 2);
if (Employeestatus == Present)
{
    if(Employee_Time == FullTime)
    {
        Console.WriteLine("Employee is Present");
        EmpHr = 8;
    }
    else
    {
        Console.WriteLine("Employee is Part Time");
        EmpHr = 4;


    }
}
else
{
    Console.WriteLine("Employee is absent");
    EmpHr = 0;
}

EmpWage = Emp_per_rate * EmpHr;
Console.WriteLine("Employee daily wage is " + EmpWage);

