using System;
namespace Taks.Models
{
	public class Person : BaseEntity
	{ 
		public double Salary { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }
	}
}

