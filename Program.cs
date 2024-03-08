namespace LabEncapsulation;

internal class Program
{
    static void Main()
    {
        // Read the data for 5 Persons
        int numPersons = 5;
        List<Person> persons = [];
        for (int i = 0; i < numPersons; i++)
        {
            string[] cmdArgs = Console.ReadLine()!.Split();
            try
            {
                persons.Add(new(
                    cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    decimal.Parse(cmdArgs[3])));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        decimal bonus = decimal.Parse(Console.ReadLine()!);

        // Increase salary and display results
        persons.ForEach(person => person.IncreaseSalary(bonus));
        persons.ForEach(person => Console.WriteLine(person.ToString()));
    }
}