using System;

namespace methodology
{
    public class PrintQualification : IprintQualification
    {
        Student student;

        public PrintQualification(Student student)
        {
            this.student = student;
        }

        public string PrintExamScore() => $"{student.getName()}  {student.getExamScore().ToString("F2")}";  

        public Student GetStudent() => student;
    }
}