
namespace Inheritance
{
    internal class Teacher:Person
    {
        public Teacher(String name):base(name)
        {

        }

        public void Explain()
        {
            Console.WriteLine("Explaining");
        }
    }
}
