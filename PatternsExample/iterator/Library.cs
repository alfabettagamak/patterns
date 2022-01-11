using System.Collections;

namespace PatternsExample.iterator
{

    public class Book
    {
        public string Name { get; set; }
    }

    public class Library : IBookNumerable
    {
        private Book[] books;

        public Library()
        {
            books = new Book[]
            {
                new Book() {Name = "Гарри Поттер 1"},
                new Book() {Name = "Гарри Поттер 2"},
                new Book() {Name = "Гарри Поттер 3"}
            };
        }


        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }

        public int Count
        {
            get { return books.Length; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}