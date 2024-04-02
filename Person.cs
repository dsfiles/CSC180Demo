using System;
public class Person // parent class
{
    public string name;
    public int age;
    public void DisplayNameAge()
    {
        Console.WriteLine($"{name} is {age} years old.");
    }
}

class Teacher : Person // Child class
{
    public string subject;
}

class Student : Person // Child class
{
    public double gpa;
}
