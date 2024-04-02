// version 6 - polymorphism
public class Program
{
    static void Main(string[] args)
    {
        Teacher student = new Teacher("Tom", 55, "Computer Science");
        
        Student teacher = new Student("Sara", 19, 3.5);
        student.DisplayInfo();
        //teacher.DisplayInfo();
    }
}
