using hw7.Services.Interfaces;
using hw7.Core.Models;

namespace hw7.Services.Implimentations 
{

    internal class BookService : IBookService
    {
        private Book[] Books = new Book[0];

        public void ShowBooks()
        {
            if (Books.Length == 0)
            {
                Console.WriteLine("Not Available");
            }

            foreach (Book book in Books)
            {
                book.GetFullInfo();
            }

        }

        public void CreateBook()
        {
            Book NewBook = new Book();

            Console.WriteLine("Add Name");
            NewBook.Name = Console.ReadLine();

            Console.WriteLine("Add Price");
            NewBook.Price = Convert.ToDouble(Console.ReadLine());

            Array.Resize(ref Books, Books.Length + 1);

            Books[Books.Length - 1] = NewBook;

        }
    }
}

