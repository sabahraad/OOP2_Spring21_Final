using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_course
{
    class Student
    {
        public string Name { get; set; }
        public string ID { get; }
        public string DOB { get; set; }
        public float Cgpa { get; set; }
        public int Credit { get; set; }
        Course[] courses;
        public int countCourse { get; set; }
        public Student() { }
        public Student(string name, string id, string dob, float cgpa, int credit)
        {
            Name = name;
            ID = id;
            DOB = dob;
            Cgpa = cgpa;
            Credit = credit;
            courses = new Course[5];
        }
        public void AddingCourse(params Course[] courses)
        {
            foreach (var c in courses)
            {
                this.courses[countCourse++] = c;
            }
        }
        public void DelCourse(Course A)
        {
            for (int i = 0; i < countCourse; i++)
            {
                if (courses[i] == A)
                {
                    int pos = i;
                    for (i = pos; i < countCourse - 1; i++)
                    {
                        courses[i] = courses[i + 1];
                    }
                }
            }
            countCourse--;
        }

        public void Show()
        {
            for (int i = 0; i < countCourse; i++)
            {
                courses[i].ShowInfoCourse();
            }
        }


        virtual public void ShowInfo()
        {
            Console.WriteLine("Name:{0}", Name);
            Console.WriteLine("ID:{0}", ID);
            Console.WriteLine("DOB:{0}", DOB);
            Console.WriteLine("Cgpa:{0} ", Cgpa);
            Console.WriteLine("Credit:{0}", Credit);
            Console.WriteLine();
            Console.WriteLine("################################");
            Console.WriteLine();
        }

    }
}
