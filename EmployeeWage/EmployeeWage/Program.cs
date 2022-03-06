

int Emp_per_rate = 20;
int EmpWage = 0;
int EmpHr = 0;
Random random = new Random();
Random random1 = new Random();
int EmployeeAttendance = random.Next(0, 3);

switch (EmployeeAttendance)
{
    case 1:
        Console.WriteLine("Employee is Present ");
        EmpHr = 8;
        break;
    case 2:
        Console.WriteLine("Part Timer is Present");
        EmpHr = 4;
        break;
    default:
        Console.WriteLine("Employee is Absent ");
        break;
}

EmpWage = Emp_per_rate * EmpHr;
Console.WriteLine("Employee daily wage is " + EmpWage);

