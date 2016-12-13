using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericList<int> wow = new GenericList<int>();
            
            wow.AddObject(5);
            wow.AddObject(7);
            wow.AddObject(12);
            wow.RemoveObject(12);
            wow.Print();
            Console.ReadLine();
            
        }
    }
}
