using System;
namespace HashTable {
    public class Entry<T>
    {
        public int key;
        public T value;
        public Entry<T> Next;
        public Entry(int key, T value)
        {
            this.key = key;
            this.value = value;
            this.Next = null;
        }
    }
    public class Hash
    {
        public int size;
        public int []Table; 
        public Hash(int size)
        {
            this.size = size;
            Table= new int[this.size];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}