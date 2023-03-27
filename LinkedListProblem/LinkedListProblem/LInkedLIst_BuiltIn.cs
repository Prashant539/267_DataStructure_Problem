using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LInkedLIst_BuiltIn
    {
        public static void LinkedList()
        {
            List<string> list= new List<string>();
            list.Add("My");
            list.Add("Name Is");
            list.Add("Prashant");
            list.Add("Chaurasiya");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(" value at index 3  : " + list[3]);
            if(list.Remove("My"))
            {
                Console.WriteLine("String removed sussesfully");
            }
            else
            {
                Console.WriteLine("Not removed");
            }
            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
           
        }
    }
}
