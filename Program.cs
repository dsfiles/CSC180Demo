// version 4
public class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Tom", 55, "Computer Science");
        teacher.DisplayTeacher();
        Student student = new Student("Sara", 19, 3.5);
        student.DisplayStudent();
    }
}
