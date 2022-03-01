using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            MyList<string> myList = new MyList<string>();
            myList.Add("Mardin");
            myList.Add("Diyarbakir");
            Console.WriteLine(myList.Count);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine("-------------------");
            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            //Array.Resize(ref _array, _array.Length + 1);
            //_array[_array.Length - 1] = item;


            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

        public T[] Items
        {
            get
            {
                return _array;
            }

        }

        //We make our class an Indexing
        public T this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
    }
}
