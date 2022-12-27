using System;
using System.Collections.Generic;
using System.Text;

namespace Session_2
{
    class Person
    {
        protected string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Hello!! my name is " + Name;
        }
    }
    class Student:Person
    {
        public Student(string name):base(name)
        {
            Name = name;
        }
        public void Study()
        {
            Console.WriteLine("Study");
        }

    }
    class Teacher:Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }
        public void Explain()
        {
            Console.WriteLine("Explain");
        }
    }
    class Class3
    {
        public static void Main4()
        {
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Student(Console.ReadLine());
                }

            }

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).Explain();
                }
                else
                {
                    ((Student)persons[i]).Study();
                }

            }

        }
    }
}
