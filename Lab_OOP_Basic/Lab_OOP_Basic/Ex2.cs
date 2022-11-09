

namespace Lab_OOP_Basic
{
    public class Average
    {
        public Average(int n1, int n2, int n3) { 
            this.n1 = n1;
            this.n2 = n2;   
            this.n3 = n3; 
        }
        public int n1 { get; set; }
        public int n2 { get; set; }
        public int n3 { get; set; }  
        
        public double average()
        {   
            return (this.n1 + this.n2 + this.n3) / 3;
        } 
    }

}
