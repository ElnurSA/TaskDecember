using System;
using Taks.Models;

namespace Taks.Service
{
	public class BookService
	{
        public void GetFilteredBooks(List<Book> books, Predicate<string> predicate)
        {
            foreach (var item in books)
            {
                if (predicate(item.Author))
                {
                    Console.WriteLine($"{item.Name} - {item.Author} - {item.Count}");
                }
            }
        }
    }
}

