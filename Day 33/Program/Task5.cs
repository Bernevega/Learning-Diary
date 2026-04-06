using System;
using System.Diagnostics;
using System.Xml.Linq;

class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
    public Employee(string name, int salary)
    {
        if (name == null)
        {
            Console.WriteLine("The name cannot be null!");
            Name = "Null";
        }
        else
            Name = name;

        if (salary <= 0)
        {
            Console.WriteLine("The salary cannot be 0 or less!");
            Salary = 0;
        }
        else
            Salary = salary;
    }
}

class Manager : Employee
{
    public string Department { get; set; }
    public Manager(string name, string department, int salary) : base(name, salary)
    {
        if (department == null)
        {
            Console.WriteLine("The department cannot be null!");
            Department = "Null";
        }
        else
            Department = department;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Manager {Name} from {Department} department has a salary of {Salary}€");
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        Manager manager1 = new Manager("Bob", "Sales", 3500);
        manager1.ShowInfo();

        Console.WriteLine();
    }
}