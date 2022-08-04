class Employee

{
    public int x;
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class a
{
    public static void Main()
    {
        Employee emp = new Employee();
        emp.Id = 100;
        emp.Name = "Harish";
        emp.Age = 55;
        emp.x = 10;
        Console.WriteLine(emp.Id);
        Console.WriteLine(emp.Name); 
        Console.WriteLine(emp.Age);
        Console.WriteLine(emp.x);
    }
}
