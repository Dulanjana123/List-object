using System;
using System.Collections.Generic;

namespace List_object
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //int type list
            List<int> nums = new List<int>();

            nums.Add(1);
            nums.Add(2);
            nums.Add(4);

            //object type list
            List<object> objlist = new List<object>();

            objlist.Add(new  { name = "dulanjana", age = 18, address = "Polgolla" });
            objlist.Add(new { name = "amila", age = 20, address = "nawayalathanna" });

            foreach(object obj in objlist)
            {
                Console.WriteLine(obj + "\n");
            }

            //create new linked list from subjects class
            LinkedList<Subjects> subjects = new LinkedList<Subjects>();

            subjects.AddLast(new Subjects { subject = "cs", semester = 1 });
            subjects.AddLast(new Subjects { semester = 2, subject = "dsa" });

            foreach (Subjects s in subjects)
            {
                Console.WriteLine("subject = {0}" + " " + "semester = {1}\n", s.subject, s.semester);
            }




            
        }
    }
}
