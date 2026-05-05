using System;
using System.Collections;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new DataContainer();

            foreach (var item in collection)
            {
                item.Change(item.Value));
            }
        }
    }
}
