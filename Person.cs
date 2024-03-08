namespace LabEncapsulation;

public class Person
{
    private string _firstName = default!;
    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (value.Length < 3)
                throw new ArgumentException(
                    "First name cannot contain fewer than 3 characters!");
            _firstName = value;
        }
    }

    private string _lastName = default!;
    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (value.Length < 3)
                throw new ArgumentException(
                    "Last name cannot contain fewer than 3 characters!");
            _lastName = value;
        }
    }
    
    private int _age;
    public int Age
    {
        get { return _age; }
        set
        {
            if (value <= 0)
                throw new ArgumentException(
                    "Age cannot be zero or a negative integer!"
                );
            _age = value;
        }
    }

    private decimal _salary;
    public decimal Salary
    {
        get { return _salary; }
        set
        {
            if (value < 460m)
                throw new ArgumentException(
                    "Salary cannot be less than 460 dollars!"
                );
            _salary = value;
        }
    }
    

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }
    
    public override string ToString()
        => $"{FirstName} {LastName} receives {Salary:C2}.";
    
    public void IncreaseSalary(decimal percentage)
    {
        // Assumes the value given is actually _percentage_
        // i.e. 20% is given by percentage=20, not percentage=.2
        // The input is halved if age < 30
        decimal scale = Age < 30 ? 2m : 1m;
        Salary *= 1m + percentage/(100m * scale);
    }
}