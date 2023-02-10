// See https://aka.ms/new-console-template for more information
//var animal = new Animal();
//animal.Wash();
//Animal bear = new Bear();
//bear.Wash();


List<Animal> zoo = new List<Animal>();
zoo.Add(new Bear());
Animal bear = new Bear();
zoo.Add(bear);
zoo.Add(new Dog());
zoo.Add(new Dock());
zoo.Add(new Cat());
foreach (Animal animal in zoo)
{
    animal.Wash();
}


public class Animal
{
    public virtual void Wash()
    {
        Console.WriteLine("Use Water and Soap");
    }
}
public class Bear : Animal
{
    public override void Wash()

    {
       Console.WriteLine(" Use bear Material And Water");
    }
    public double Plus(double a, double b)
    {
        double x = a + b;
        return x;
    }
}
public class Dog : Animal 
{
    public override void Wash()
    {
       Console.WriteLine("Use Dog Material And Water");
    }
}
public class Dock : Animal
{
    public void Wash()
    {
        Console.WriteLine("Use Dock Material And Water");
    }
}
public class Cat : Animal
{
}

