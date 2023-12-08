using Taks.Models;
using Taks.Service;
#region Lists
List<Person> people = new()
        {
            new Person
            {
                Id = 1,
                Name = "Elnur",
                Surname = "Safiyev",
                Address = " Baki",
                Salary = 1100
            },
            new Person
            {
                Id = 2,
                Name = "Ali",
                Surname = "Aliyev",
                Address = " Ganja",
                Salary = 900
            },
            new Person
            {
                Id = 3,
                Name = "Togrul",
                Surname = "Alakbarov",
                Address = "London",
                Salary = 15000
            },
        };

List<Book> books = new()
{
    new Book
    {
        Id = 1,
        Count = 10,
        Author = "Nizami",
        Name = "Leyli and Mejnun"
    },
    new Book
    {
        Id = 2,
        Count = 25,
        Author = "Napoleon Hill",
        Name = "Think And Grow Rich"
    },
    new Book
    {
        Id = 3,
        Count = 19,
        Author = "Nizami",
        Name = "7 Beauties"
    },
};
#endregion

PersonService personService = new();
BookService bookService = new();

//Task 1

//bookService.GetFilteredBooks(books, m => m == "Nizami");

//Task 2

//personService.ShowFilterSalary(people, m=>m > 1000);

