using ChallengeApp;


Employee employee1 = new Employee("Jakub", "Gajda",25);
Employee employee2 = new Employee("Marcin","Wesołek",29);
Employee employee3 = new Employee("Kamil","Małek",21);

employee1.AddScore(10);
employee1.AddScore(10);
employee1.AddScore(10);
employee1.AddScore(10);
employee1.AddScore(10);

employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(9);

employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(1);

//var result1 = employee1.Result;
//Console.WriteLine(result1); 
//var result2 = employee2.Result;
//Console.WriteLine(result2); 
//var result3 = employee3.Result; 
//Console.WriteLine(result3); 



List<Employee> employees = new List<Employee>()
{
employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine("Pracownik z najwyższą liczbą ocen : ");
Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + "lat" + " " + employeeWithMaxResult.Age );
//dfghjkm,lqwerftgyhjkwedfghjyjc
//wetsrydtf
    