using System;



public class EmployeeController
{
	public void ShowFilteredSalary()
	{
		decimal f = 1000;
		decimal t = 2000;

		EmployeeService employeeService = new();
		Employee[] employees = employeeService.GetByFilteredSalary(f, t);

		foreach (var item in employees)
		{
			var result = $"{item.name} - {item.surname} - {item.age} - {item.salary}";

			Console.WriteLine(result);
		}
	}
}


