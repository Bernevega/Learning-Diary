using System;
using System.Collections.Generic;

class Task4
{
    public static void TaskFour()
    {
        Student student2 = new Student();
        student2.name = "John";
        student2.age = 23;
        student2.grade = 'B';
        student2.PrintInfo();

        Student student3 = new Student();
        student3.name = "Mary";
        student3.age = 19;
        student3.grade = 'C';
        student3.PrintInfo();
    }
}