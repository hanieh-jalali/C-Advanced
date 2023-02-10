 static (int id , string name, int age) GetTuples()
{
    return (1, "hanieh", 23);
}

public class school
{
    private int _id;

    private string _name;

    private int _age;


    public school(int id, string name, int age) => (_id, _name, _age) = (Id, Name, Age);


    public int Id {
        
        get { return _id; } 
        set { _id = value; } 
    }
    public string Name { 

        get { return _name; }
        set { _name = value; }
    }
    public int Age {

        get { return _id; } 
        set { _age = value; }
    }    

}
