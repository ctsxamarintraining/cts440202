using System;
using System.Collections.Generic;

namespace WriteAndReadAFile
{
	public class JSONSerialization
	{
		public JSONSerialization ()
		{
		}
	}
	/// <summary>
	/// Company info
	/// </summary>
	public class Company
	{
		public string Title { get; set; }
		public List<Employee> Employees { get; set; }


		/// <summary>
		/// Function that use upper classes to simulate some data
		/// </summary>
		/// <returns></returns>
		public static Company GetData()
		{
			return new Company()
			{
				Title = "Company Ltd",
				Employees = new List<Employee>()
				{
					new Employee(){ Name = "Mark CEO", EmployeeType = EmployeeType.CEO },
					new Employee(){ Name = "Matija Božičević", EmployeeType = EmployeeType.Developer },
					new Employee(){ Name = "Steve Developer", EmployeeType = EmployeeType.Developer}
				}
			};
		}
	}

	/// <summary>
	/// Employee info
	/// </summary>
	public class Employee
	{
		public string Name { get; set; }
		public EmployeeType EmployeeType { get; set; }
	}

	/// <summary>
	/// Types of employees
	/// (just to se how JSON deals with enums!)
	/// </summary>
	public enum EmployeeType
	{
		CEO,
		Developer
	}


}

