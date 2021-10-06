using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList.Models
{
    public class Student
    {

        public string Name { get; set; }
        public string Image { get; set; }
        public string Date { get; set; }
    }

    public class StudentManager
    {
        public static List<Student> GetStudents()
        {
            var students = new List<Student>();

            students.Add(new Student { Name = "NguyenHung", Date = "20/20/2000", Image = "Assets/image01.jpg" });
            students.Add(new Student { Name = "NguyenNam", Date = "2/9/2000", Image = "Assets/image01.jpg" });
            students.Add(new Student { Name = "NguyenQuan", Date = "1/12/2000", Image = "Assets/image01.jpg" });
            students.Add(new Student { Name = "NguyenThang", Date = "28/3/2000", Image = "Assets/image02.jpg" });
            students.Add(new Student { Name = "NguyenLong", Date = "14/5/2000", Image = "Assets/image02.jpg" });
            students.Add(new Student { Name = "KieuLinh", Date = "19/3/2000", Image = "Assets/image02.jpg" });
            students.Add(new Student { Name = "NguyenThuy", Date = "14/12/2000", Image = "Assets/image02.jpg" });
            students.Add(new Student { Name = "ThuyLinh", Date = "2/10/2000", Image = "Assets/image02.jpg" });
            students.Add(new Student { Name = "NguyenHuyen", Date = "15/4/2000", Image = "Assets/image02.jpg" });
            students.Add(new Student { Name = "HuyenDieu", Date = "4/11/2000", Image = "Assets/image01.jpg" });

            return students;
        }
    }
}
