using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vs = { 1, 2, 3 };

            foreach (var item in vs)
            {

            }
            List<int> vs1 = new List<int> { 1, 2, 3 };

            foreach (var item in vs1)
            {

            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i*10);
            }

            foreach (var item in new Sidra10To100())
            {
                Console.WriteLine(item);
            }

            foreach (var item in new Hezka(4))
            {
                Console.WriteLine(item);
            }


            List<Student> studentlist = new List<Student>() { new Student("Fabi", 60), new Student("Yonatan", 150), new Student("Itay", 120), new Student("Elad", 99) };
            foreach (var studentGrade in new PracticeALot(studentlist))
            {
                Console.WriteLine(studentGrade);
            }
            
        }
    }
}
