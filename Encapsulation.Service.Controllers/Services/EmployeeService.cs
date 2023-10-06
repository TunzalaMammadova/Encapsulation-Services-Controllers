using System;





public class EmployeeService
{
    private Employee[] GetAll()
    {
        Employee employee1 = new()
        {
            name = "Tunzale",
            surname = "Memmedova",
            age = 24,
            salary = 500

        };

        Employee employee2 = new()
        {
            name = "Semed",
            surname = "Huseynov",
            age = 26,
            salary = 1500

        };


        Employee employee3 = new()
        {
            name = "Elnur",
            surname = "Memmedov",
            age = 20,
            salary = 1300

        };


        Employee employee4 = new()
        {
            name = "Nergiz",
            surname = "Memmedova",
            age = 25,
            salary = 2500
        };

        return new Employee[] { employee1, employee2, employee3, employee4 };

    }

    public Employee[] GetByFilteredSalary(decimal f, decimal t)
    {
        Employee[] employees = GetAll();

        var result = employees.Where(m => m.salary > f && m.salary < t).ToArray();

        return result;

    }


}
    
