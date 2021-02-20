using System;

namespace MyDictionaryy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Students and Number of Students");
            Console.WriteLine("");

            MyDictionaryy<int, string> studentsNumber = new MyDictionaryy<int, string>();
            Console.WriteLine("List of Student");
            studentsNumber.Add(165, "Ayşe Aydın");
            studentsNumber.Add(245, "Fatma Güler");
            studentsNumber.Add(328, "Ali Enginn");
            studentsNumber.Add(825, "Mehmet Çetin");
            studentsNumber.Add(1026, "Hasan Çelik");

            studentsNumber.List();
            Console.WriteLine(" ");
            Console.WriteLine("Number of Students");
            Console.WriteLine(studentsNumber.Count());

        }


    }


}

