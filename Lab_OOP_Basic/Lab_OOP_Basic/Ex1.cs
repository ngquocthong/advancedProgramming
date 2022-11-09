
namespace Lab_OOP_Basic
{
    public class Triangle
    {
        private int length { get; set; }
        private int width { get; set; }
        private int height{ get; set; }
        public Triangle()
        {
            this.length = 3;
            this.width = 4;
            this.height = 5;
        }
        public Triangle(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        
        public double perimeter()
        {
            return this.length + this.width + this.length;
        }
        public double area()
        {
            double p = perimeter()/2;
            return Math.Sqrt(p * (p - length) * (p - width) * (p - height));
        }

    }
}
