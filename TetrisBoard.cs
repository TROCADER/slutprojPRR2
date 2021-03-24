using System;

namespace slutprojPRR2
{
    public class TetrisBoard
    {
        Square[,] squares = new Square[7, 20];

        public TetrisBoard()
        {
            for (int y = 0; y < squares.GetLength(1); y++)
            {
                for (int x = 0; x < squares.GetLength(0); x++)
                {
                    squares[x, y] = new Square(x, y);
                }
            }
        }
    }
}
