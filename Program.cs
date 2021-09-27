using System;
using System.Collections.Generic;

namespace linklistt
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> mylist = new LinkedList<int>();
            mylist.AddFirst(23);
            mylist.AddFirst(34);
            mylist.AddLast(134);
            mylist.AddLast(354);
            foreach (int tt in mylist)
            {
                Console.Write(tt+" ");
            }
            mylist.RemoveLast();
            Console.WriteLine("\nAfter removing last element");
            foreach (int tt in mylist)
            {
                Console.Write(tt + " ");
            }
        }
       
    }
}
