
namespace Inheritance
{
    internal class Student: Person 
    {
        private int midtermScore;
        private int finalScore;

        public int MidTermScore
        {
            get { return midtermScore; }
            set { 
                if(value <  0) throw new ArgumentOutOfRangeException("value invalid");
                
                midtermScore = value; 
            }
        }

        public int FinalScore
        {
            get { return finalScore; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value invalid");

                finalScore = value;
            }
        }

        public Student(string name): base(name)
        {

        }

        public void Study()
        {
            Console.WriteLine("Studying");   
        }
    }
}
