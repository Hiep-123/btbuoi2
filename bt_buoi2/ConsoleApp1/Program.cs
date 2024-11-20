using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student>  students = new List<student>();
            students.Add(new student(1,"hahahah",10));
            students.Add(new student(2, "hqưdasd", 16));
            students.Add(new student(3, "dkajsndkas", 30));
            students.Add(new student(4, "Admin", 40));
            students.Add(new student(5, "dkmasnkjas", 50));
            //Câu a
            Console.WriteLine(" Cau a Danh sach hoc sinh:");
            students.ForEach(student => Console.WriteLine(student));
            
            //Câu b
            var listStudenAge = students.Where(student => (student.age >15 && student.age<18)).ToList();
            Console.WriteLine("\nCau b Hoc sinh tu 15 toi 18 tuoi");
            listStudenAge.ForEach(student => Console.WriteLine(student));   

            //Cau c
            var studentA = students.Where (student => student.name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("\nCau c Hoc sinh bat day bang chu A");
            studentA.ForEach(student => Console.WriteLine(student));

            //Câu d
            int totalAge = students.Sum(s => s.age);
            Console.WriteLine($"\nCau d Tong so tuoi tat ca hoc sinh: {totalAge}");

            // Câu e
            int maxAge = students.Max(s => s.age);
            var studentAgeMax = students.Where(s => s.age == maxAge).ToList();
            Console.WriteLine("\nCau e Student co so tuoi cao nhat:");
            studentAgeMax.ForEach(student => Console.WriteLine(student));

            //Câu f
            var sortStudents = students.OrderBy(s => s.age).ToList();
            Console.WriteLine("\nCau f Sap xep student tang dan:");
            sortStudents.ForEach(student => Console.WriteLine( student)); 
            Console.ReadLine();
        }
    }
}
