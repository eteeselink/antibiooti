using System;

namespace Antibiooti.Forum2016
{
    class Screen : IScreen, IDisposable
    {
        public Screen(){

            for(int i = 0; i < 29; ++i)
                for(int j = 0; j < 5; ++j)
                    this._buffer[i,j] = ' ';

        }


        public void Write(int x, int y, string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.ForegroundColor = color;
            Console.Write(text);

            // somehow, CursorVisible = false doesn't seem to do much
            // so we move the cursor to left top so it's a bit out of the way.
            Console.CursorVisible = false;
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            
        }
// 
        private int[,] _buffer = new int[29,5];
        public void printCharacter(ICharacter c, int gridId, ConsoleColor color) {
        //public void printCharacter(int[][] d, ConsoleColor color) {

            char[,] charBuffer = c.buffer();


                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j < 5; j++) {
                        _buffer[i + gridId * 6, j] = charBuffer[i, j];
                    }
                }
            

            if (gridId == 4) {
                // print to screen
                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j < 29; j++) {
 //                       Console.ForegroundColor=color;
                        Console.Write("*");

                    }
                    Console.WriteLine();
                }
            }

        // for (int i=0; i<d.Length; i++){
        //       for(int j=0;j<d[i].Length;j++)
        //       {
        //         Console.CursorLeft=d[i][j];
        //         Console.CursorTop=d[j][i];
        //         Console.ForegroundColor=color;
        //         Console.Write("*");
        //       }
        //     }




        }

        public void Clear()
        {
            Console.Clear();
            Console.ResetColor();
        }

        public void Dispose()
        {
            Clear();
        }
    }

}