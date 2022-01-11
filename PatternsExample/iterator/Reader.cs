using System;

namespace PatternsExample.iterator
{
    public class Reader
    {
        public void SeeBook(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();
            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
}