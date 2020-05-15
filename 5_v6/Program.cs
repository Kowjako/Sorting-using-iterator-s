using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_v6
{
    class Program 
    {
        static MyContainer cont = new MyContainer();
        static IEnumerator<int> ie; //iterator
        static void Main(string[] args)
        {
            //Input numbers//
            string numbers = Console.ReadLine();
            //Add elements to container//
            cont.AddContainer(numbers);
            CheckContainer();
            //Sort by count of 0-bits//
            Console.WriteLine("Sorting by 0-bits count");
            cont.BinarySort();
            //--//
            CheckContainer();
            Console.ReadKey();
        }
        static void CheckContainer()
        {
            ie = cont.GetIterator(); //get iterator from our container
            while (ie.MoveNext())
            {
                int tmp = ie.Current;
                Console.Write(tmp+ " ");
            }
            Console.WriteLine();
        }  
    }
}
