

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Program Started");  


        Employee emp1 = new Employee(1, "Yara Hossam", 6000.75m, new DateTime(2023, 2, 10), 'F', SecurityLevel.Secretary);
        Employee emp2 = new Employee(2, "Sara Ahmed", 8000.90m, new DateTime(2020, 8, 25), 'F', SecurityLevel.DBA);
        
        
        Console.WriteLine(emp1.ToString());
        Console.WriteLine(emp2.ToString());
        Console.ReadLine();

    }
}