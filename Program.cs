namespace LabEncapsulation;

internal class Program
{
    static void Main()
    {
        // Read the data for 5 Persons
        int numPersons = 5;
        Person[] persons = new Person[numPersons];
        for (int i = 0; i < numPersons; i++)
        {
            string[] cmdArgs = Console.ReadLine()!.Split();
            persons[i] = new(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
        }

        // Sort and print the Persons by first name and age
        persons.OrderBy(person => person.FirstName)
               .ThenBy(person => person.Age)
               .ToList()
               .ForEach(person => Console.WriteLine(person.ToString()));
    }
}