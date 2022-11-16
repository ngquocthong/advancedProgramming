

namespace Demo4
{
    internal class Animal
    {
        private int limb;
        public int Limb
        {
            get { return limb; }
            set {
                if (value < 0)
                    throw new ArgumentException("Limb >= 0");
                limb = value;
            }
            
        }
        public string move()
        {
            return "moving";
        }
    }
}
