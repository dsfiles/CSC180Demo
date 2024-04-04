// version 7 – Properties
public class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Tom", 55, "Computer Science");
        teacher.DisplayInfo();
        Student student = new Student("Sara", 19, 3.5);
        student.DisplayInfo();
        student.Gpa = 3.8;
        student.DisplayInfo();
    }
}
