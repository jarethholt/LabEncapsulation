namespace LabEncapsulation;

public class Person
{
    private string _firstName = default!;
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    private string _lastName = default!;
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    
    private int _age;
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    
    public override string ToString()
        => $"{FirstName} {LastName} is {Age} years old.";
}