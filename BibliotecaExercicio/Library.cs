using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaExercicio
{
    internal class Library
    {
        private string name;
        public string Name { get; set; }

        private List<Book> books;
        
        private Dictionary<string, Book> category;

        public Library(string name)
        {

        }
        public Library() { }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddBook(Book book, string category)
        {

        }

        public void RemoveBook(Book book) 
        {
            
        }

        public List<Book> GetBooks() 
        {
            return books;
        }

        public List<Book> GetBooks(string category) 
        {
            return books;
        }
    }
}
