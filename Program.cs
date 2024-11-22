using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Student> list = new List<Student>();
            {
                list.Add(new Student(1, "Hậu", 17));
                list.Add(new Student(2, "Hưng", 18));
                list.Add(new Student(3, "Đô", 20));
                list.Add(new Student(4, "Khoa", 12));
                list.Add(new Student(5, "An", 14));
                list.Add(new Student(6, "Anh", 23));

            };

            // a
            Console.WriteLine("Danh sách các học sinh là: ");
            list.ForEach(student => Console.WriteLine(student));

            //b
            Console.WriteLine("------------------------------");
            Console.WriteLine("Học sinh có tuổi từ 15 đến 18 ");
            var find = list.Where(x => x.Age > 15 && x.Age <= 18).ToList();
            find.ForEach(student => Console.WriteLine(student));

            //c 
            Console.WriteLine("------------------------------");
            Console.WriteLine("Học sinh có tên bắt đầu bằng chữ A");
            var findC = list.Where(x => x.Name[0] == 'A').ToList();
            findC.ForEach(x => Console.WriteLine(x));

            //d
            Console.WriteLine("------------------------------");
            var sum = list.Sum(x => x.Age);
            Console.WriteLine("Tổng tuổi của tất cả học sinh: " + sum);

            //e
            Console.WriteLine("------------------------------");
            var age_Max = list.OrderByDescending(x => x.Age).FirstOrDefault();
            Console.WriteLine("Học sinh có tuổi lớn nhất là " + age_Max);

            //f
            Console.WriteLine("------------------------------");
            var sorted = list.OrderBy(x => x.Age).ToList();
            Console.WriteLine(" Danh sách học sinh sau khi sắp xếp ");
            sorted.ForEach(x => Console.WriteLine(x));
        }
    }
}
