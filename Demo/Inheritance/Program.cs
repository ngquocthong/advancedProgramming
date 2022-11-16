using Inheritance;

internal class Program
{
    public static void Main(string[] agrs)
    {
        Student A = new Student("A");
        Student B = new Student("B");
        Student C = new Student("C");
        Teacher D = new Teacher("D");




        Console.WriteLine(A);
        A.Study();
        Console.WriteLine(D);
        D.Explain();

        Course csr = new Course();
        csr.AddStudent(A);
        csr.AddStudent(B);
        csr.AddStudent(C);


        csr.setMidtermScore(0, 8);
        csr.setFinalScore(0, 8);

        csr.setMidtermScore(1, 3);
        csr.setFinalScore(1, 4);

        csr.setMidtermScore(2, 9);
        csr.setFinalScore(2, 10);

        csr.passingStudent();

    }
}