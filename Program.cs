namespace MatrixAssignment

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
                {
                { 4, 3, 2, 2},
                { 8, 1, 7, 3 },
                { 0, -1, 0, 0 },
                { 5, 3, 1, 1 }};

            int det = (matrix[1, 0] * ((matrix[1, 1] * ((matrix[2, 2] * matrix[3, 2]) - (matrix[3, 2] * matrix[2, 3])) - (matrix[3, 2] * ((matrix[2, 1] * matrix[1, 2]) - (matrix[3, 1] * matrix[2, 3])) + (matrix[1, 3] * ((matrix[2, 1] * matrix[3, 2]) - (matrix[3, 1] * matrix[2, 2]))))))) -
                (matrix[0, 1] * ((matrix[1, 0] * ((matrix[2, 2] * matrix[3, 2]) - (matrix[3, 2] * matrix[2, 3])) - (matrix[3, 2] * ((matrix[2, 0] * matrix[1, 2]) - (matrix[3, 0] * matrix[2, 3])) + (matrix[1, 3] * ((matrix[2, 0] * matrix[3, 2]) - (matrix[3, 0] * matrix[2, 2]))))))) +
                (matrix[0, 2] * ((matrix[1, 0] * ((matrix[2, 1] * matrix[3, 2]) - (matrix[3, 1] * matrix[2, 3])) - (matrix[3, 1] * ((matrix[2, 0] * matrix[1, 2]) - (matrix[3, 0] * matrix[2, 3])) + (matrix[1, 3] * ((matrix[2, 0] * matrix[3, 1]) - (matrix[3, 0] * matrix[2, 1]))))))) -
                (matrix[0, 3] * ((matrix[1, 0] * ((matrix[2, 1] * matrix[3, 2]) - (matrix[3, 1] * matrix[2, 2])) - (matrix[3, 1] * ((matrix[2, 0] * matrix[1, 2]) - (matrix[3, 0] * matrix[2, 2])) + (matrix[1, 2] * ((matrix[2, 0] * matrix[3, 1]) - (matrix[3, 0] * matrix[2, 1])))))));

            Console.WriteLine(det);
        }
    }
}