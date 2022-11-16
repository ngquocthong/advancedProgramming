

using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace Inheritance
{
    internal class Course
    {
        List<Student> students = new List<Student>();

        
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void setMidtermScore(int studentNumber, int score)
        {
            students[studentNumber].MidTermScore = score;
        }

        public void setFinalScore(int studentNumber, int score)
        {
            students[studentNumber].FinalScore = score;
        }
        public void passingStudent()
        {
            foreach(Student student in students)
            {
                if ((student.MidTermScore + student.FinalScore) / 2 > 5.0)
                    Console.WriteLine(student.ToString() + " " + "Pass");
            }
        }

        public override string ToString()
        {
            string re = "";
            foreach(Student student in students)
            {
                re+=student.ToString()+"\n";
            }
            return re;
        }
    }
}
