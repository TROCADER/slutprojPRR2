using System;
using Raylib_cs;

namespace slutprojPRR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "TETRIS");
            Raylib.SetTargetFPS(60);

            TetrisBoard tetrisBoard = new TetrisBoard();
            
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.BLACK);

                Raylib.EndDrawing();
            }
        }
    }
}
