namespace Lab_OOP_Basic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("\nTriangle:");
        Triangle t = new Triangle(4,5,6);
        Console.WriteLine(t.area());
        Console.WriteLine(t.perimeter());

        Console.WriteLine("\nAverage:");
        Average av = new Average(1, 2, 3);
        Console.WriteLine(av.average());

        Console.WriteLine("\nEmployee:");
        Employee em = new Employee("Ronaldo", 7, 10);
        em.getInfo();
        em.addSal();
        em.addWork();
        em.getInfo();

        Console.WriteLine("Matrix 1");
        Matrix mt1 = new Matrix(3, 3);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                mt1.setAtPosition(i, j, i);
            }
        }

        Matrix mt2 = new Matrix(3, 3);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                mt2.setAtPosition(i, j, i);
            }
        }
        Matrix afterAdd = mt1.addMatric(mt2);
        Console.WriteLine("Matrix after added");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
               Console.Write(afterAdd.getValueAt(i, j));
            }
            Console.WriteLine();
        }


    }
}