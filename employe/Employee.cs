using System;
namespace Employe
{
	public class Employee :Departament
	{
		public string Name { get; set; }

        public string Surname { get; set; }

		public int  Salary { get; set; }

		public Employee(string name, string surname, int salary, int employeeLimit, int salaryLimit, string employees) :base(name, employeeLimit, salaryLimit, employees)
		{
			Name = name;
			Surname = surname;
			Salary = salary; 
		}

		public int SalaryCheck( int Salary)
		{
			if (Salary < 250)
			{
				Console.WriteLine("Maash 250 den ashagi ola bilmez");
			}
			return Salary;
		}
		public string NameChecker( string Name)
		{

				if (char.IsLower(Name[0]))
				{
					return "boyuk herifnen yazin";
				}
			return Name;
		}

        public string SurnameChecker(string Surname)
        {

            if (char.IsLower(Surname[0]))
            {
               return "boyuk herifnen yazin";
            }
			return Surname;
        }

    }
}

