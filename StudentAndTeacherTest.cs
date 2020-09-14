using System;

namespace OOPExample
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Greet();
            Student s = new Student();
            s.SetAge(21);
            s.Greet();
            s.ShowAge();
            Teacher t = new Teacher();
            t.SetAge(30);
            t.Greet();
            t.Explain();
        }
    }
}
