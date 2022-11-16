

using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Demo3
{
    internal class Program
    {
        public static void main(string[] agrs)
        {
            int size = int.Parse(Console.ReadLine());
            for(int stCount = 1; stCount <= size; stCount++)
            {
                printRow(size, stCount);
            }
            for (int stCount = size; stCount > 1; stCount--)
            {
                printRow(size, stCount);
            }

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
}
