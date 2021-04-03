 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_course
{
    class Program
    {
        static void Main(string[] args)
        {
            Course A = new Course("Java", "C1122", "CSE");
            Course B = new Course("C#", "C1123", "CSE");
            Course C = new Course("Microprocessor", "E1212", "EEE");
            Course D = new Course("Webtech", "C3301", "CSE");
            Course E = new Course("Compailer Design", "C2004", "CSE");

            Student x = new Student("Raad", "18-38242-2", "18-07-1998", 3.61f, 89);
            Student y = new Student("Saad", "18-38255-3", "04-02-1996", 3.39f, 130);
            Student z = new Student("Rudmila", "18-38302-2", "12-10-2004", 3.80f, 102);
            Student p = new Student("NUR", "18-3800-1", "12-12-2001", 3.56f, 90);

            x.AddingCourse(A, B, C, D, E);

            x.DelCourse(B);

            A.EnrollStudent(x, y, z, p);
            B.EnrollStudent(x, y);
            C.EnrollStudent(z, p);
            D.EnrollStudent(x, z, y);
            E.EnrollStudent(y);

            x.Show();

            C.StudentInfo();
            E.StudentInfo();

        }
    }
    }

