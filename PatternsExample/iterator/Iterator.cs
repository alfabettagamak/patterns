using System.Collections;

namespace PatternsExample.iterator
{
    public interface IBookIterator
    {
        public bool HasNext();
        public Book Next();
    }

    interface IBookNumerable
    {
        public IBookIterator CreateNumerator();
        public int Count { get; }
        Book this[int index] { get; }
    }

    class LibraryNumerator : IBookIterator
    {
        private IBookNumerable aggregate;
        private int index = 0;

        public LibraryNumerator(IBookNumerable a)
        {
            aggregate = a;
        }
        
        public bool HasNext()
        {
            return index < aggregate.Count;
        }

        public Book Next()
        {
            return aggregate[index++];
        }
    }

}