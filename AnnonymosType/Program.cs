
var Student = new { name = "hanieh", lastname = "jalali", age = 10};

var Apple = new { name = "hanieh", lastname = "jalai" };

var student2 = Student with { age = 20 };

var equal = new Do();
var resultEqual = equal.Equal(Student, Apple);
var resultTypeEqual = equal.TypeEqual(Student, Apple);
var resultEqual2 = equal.Equal2(Student,Apple);

Console.WriteLine(resultEqual);
Console.WriteLine(resultTypeEqual);
Console.WriteLine(resultEqual2);
Console.WriteLine(Student.GetType());

public class Do
{
    public object Student { get; set; }
    public object Apple { get; set; }

    public bool Equal(object student, object apple)
    {
        Student = student;  
        Apple = apple;
        if (Student == Apple)
            return true;
        else
            return false;   
    }
    public bool TypeEqual(object student, object apple)
    {
        Student = student;
        Apple = apple;
        if (Student.GetType() == Apple.GetType())
            return true;
        else
            return false;
    }
    public bool Equal2(object student, object apple)
    {
        Student = student;
        Apple = apple;
        if (Apple.Equals(Student))
            return true;
        else
            return false;
    }
}



