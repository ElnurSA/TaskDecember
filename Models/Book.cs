using System;
namespace Taks.Models
{
	public class Book : BaseEntity
	{
		public string Author { get; set; }
		public string Name { get; set; }
		public int Count { get; set; }
	}
}

