namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(3, 4);
            Matrix matrix2 = new Matrix(4, 5);
            
            matrix.VerticalSnakeFromLeft(1);
            matrix.VerticalSnakeFromRight(12);
                       

            Matrix squareMatrix = new Matrix(4, 4);
            Matrix squareMatrix2 = new Matrix(8, 8);

            squareMatrix.DiagonalSnakeFromLeftSide(1);
            squareMatrix.DiagonalSnakeFromRightSide(22);            

            matrix.MatrixSnake();
            matrix2.MatrixSnake();
        }
    }
}