using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_course
{
    class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string CourseDep { get; set; }
        Student[] students;
        public int totalstudent { get; set; }
        public Course()
        {

        }
        public Course(string coursename, string coursecode, string coursedep)
        {
            CourseName = coursename;
            CourseCode = coursecode;
            CourseDep = coursedep;
            students = new Student[100];
        }
        public void EnrollStudent(params Student[] students)
        {
            foreach (var S in students)
            {
                this.students[totalstudent++] = S;
            }
        }

        virtual public void StudentInfo()
        {

            for (int i = 0; i < totalstudent; i++)
            {
                students[i].ShowInfo();
            }
        }

        virtual public void ShowInfoCourse()
        {
            Console.WriteLine("Course Name: {0}", CourseName);
            Console.WriteLine("Course Code: {0}", CourseCode);
            Console.WriteLine("Course Department :{0}", CourseDep);
            Console.WriteLine("Total number of students in {0} is :{1}", CourseName, totalstudent);
            Console.WriteLine();
            Console.WriteLine("######################################");
            Console.WriteLine();
        }
    }
}
