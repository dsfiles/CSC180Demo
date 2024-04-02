using System;

public class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.name = "Allan";
        person.age = 21;

        Teacher teacher = new Teacher();
        teacher.name = "Tom";
        teacher.age = 55;
        teacher.subject = "Computer Science";
        teacher.DisplayNameAge();

        Student student = new Student();
        student.name = "Sara";
        student.age = 19;
        student.gpa = 3.5;
        student.DisplayNameAge();
    }
}
