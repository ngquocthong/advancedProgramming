
namespace Inheritance
{
    internal class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                    this.name = value;

            }
        }
        public Person(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
