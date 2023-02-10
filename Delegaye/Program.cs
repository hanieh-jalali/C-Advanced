
var x = new SUM();
School one = x.method1;
School two = x.method2;
one.Invoke(10,"");

int z = 10;
z.School(20);
Console.WriteLine(z.School(20));

static class Student
{

    public static int School(this int age, int y)
    { 
        return age+y; 
    }

}

public delegate int School(int age, string student);


public class SUM
{
    public int method1(int age, string student)
    {
        return 10;
    }
    public int method2(int age, string student)
    {
        return 20;
    }
}