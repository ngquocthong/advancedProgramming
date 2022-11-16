using Demo;

internal class Program
{
    public static void Main(string[] agrs)
    {
        CLient c = new CLient();
        Console.Write("Please enter the client first name: ");
        string fname = Console.ReadLine();
        while (CLient.ValidateEmptyField(fname))
           {
             Console.WriteLine("Try Again: ");
             fname = Console.ReadLine();
            }
        c.FirstName = fname;

        Console.Write("Please enter the client last name: ");
        string lname = Console.ReadLine();
        Console.Write("Please enter the client age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Please enter the email age: ");
        string email = Console.ReadLine();
        Console.Write("Please enter the address: ");
        string address= Console.ReadLine();
        Console.Write("Please enter the phone: ");
        string phone = Console.ReadLine();

        Console.WriteLine(c.ToString());

    }
}