
using System.Data;

namespace Lab_OOP_Basic
{
    public class Matrix
    {
        public int row;
        public int col;
        private int[,] elements = new int[255, 255];

        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
        public int getValueAt(int row, int col)
        {
            return elements[row, col];
        }
        public int getRow()
        {
            return row;
        }
        public int getCol()
        {
            return col; 
        }
        public void setAtPosition(int row, int col, int value)
        {
            elements[row,col] = value;
        }
        public Matrix addMatric(Matrix matrix2) 
        {
            Matrix resultMatrix = new Matrix(this.row, this.col);
            if(matrix2.getRow() ==  this.row && matrix2.getCol() == this.row)
            {
                for(int i = 0; i < this.row; i++)
                {
                    for(int j = 0; j<this.col; j++)
                    {
                        resultMatrix.elements[i,j] = this.elements[i, j] + matrix2.elements[i, j];
                    }
                }
                return resultMatrix;
            } else
            {
                Console.WriteLine("Cannot Add 2 Matrix");
                return resultMatrix;
            }
        }

    }
}
