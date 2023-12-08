using System;
using Taks.Models;

namespace Taks.Service
{
	public class PersonService
	{
		

        public void ShowFilterSalary(List<Person> people, Predicate<double> func)
        {
            foreach (var item in people)
            {
                if (func(item.Salary))
                {
                    Console.WriteLine($"{item.Name} - {item.Surname} - {item.Address}");
                }
            }
        }
	}
}

