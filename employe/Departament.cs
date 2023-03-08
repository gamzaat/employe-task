using System;
namespace Employe
{
	public class Departament
	{
		public string Name { get; set; }

		public int EmployeeLimit { get; set; }

		public int SalaryLimit { get; set; }

		public string Employees { get; set; }


		public Departament(string name, int employeeLimit, int salaryLimit, string employees)
		{
			Name = name;
			EmployeeLimit = employeeLimit;
			SalaryLimit = salaryLimit;
			Employees = employees;

		}

		
    }

}

