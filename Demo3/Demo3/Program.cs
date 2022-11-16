
using Demo3;

class BankAccount
{
    public int ID { get; set; }
    public double Balance { get; set; }
    public void Deposit(double amount)
    {
        this.Balance += amount;

    }
    public void WithDraw(double amount)
    {
        this.Balance -= amount;
    }
    public void show()
    {
        Console.WriteLine($"Account {this.ID}, current balance {this.Balance}");
    }
}

class Student
{
    public string name { get; set; }
    public int age { get; set; }
    public double grade { get; set; }
    public Student (string name, int age, double grade) 
    {
        this.name = name;
        this.age = age;
        this.grade = grade;
    }

    public void Show()
    {
        Console.WriteLine($"Name: {this.name} Age: {this.age} Grade: {this.grade}");
    }
}



internal class Program
{
    enum CoffeSize{
        Small = 100,
        Normal = 150,
        Double = 300,
        Extra
    }
    public static void Main(string[] args)
    {
        /*var bankAcc = new BankAccount(); // EX 1
        bankAcc.ID = 1;
        bankAcc.Deposit(20);
        bankAcc.WithDraw(10);
        bankAcc.show();

        int size = int.Parse(Console.ReadLine()); // EX 2
        for (int stCount = 1; stCount <= size; stCount++)
        {
            printRow(size, stCount);
        }
        for (int stCount = size; stCount > 1; stCount--)
        {
            printRow(size, stCount);
        }*/
        /*
        Student[] studentList = new Student[100];
        while (true)
        {
            string cmd = Console.ReadLine();
            string[] token = cmd.Split(" ");
            switch (token[0])
            {
                case "Create":
                    Student stu = new Student(token[1], int.Parse(token[1]), double.Parse(token[3]));
                    studentList.Append(stu);
                    break;
                case "Show":
                    for (int i = 0; i < studentList.Length; i++)
                    {
                        if (studentList[i].name == token[1])
                        {
                            studentList[i].Show();
                        }
                    }
                    break;
                case "Exit":
                    Console.WriteLine("Hihi. Good bye");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Try Again");
                    break;
                    
            }
        }
        */

        //Console.WriteLine(((int)CoffeSize.Small));
        C1.number;

       
    }
    public static void printRow(int size, int stCount)
    {
        for (int i = 0; i < size - stCount; i++)
            Console.Write(" ");
        for (int col = 1; col < stCount; col++)
            Console.Write("* ");
        Console.WriteLine("*");

    }

}

