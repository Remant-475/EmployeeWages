

int Present = 1;
Random random = new Random();
int Employeestatus = random.Next(0, 2);
if (Employeestatus == Present)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is absent");
}

