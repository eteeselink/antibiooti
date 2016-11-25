using System;

namespace Antibiooti.Forum2016
{

    class Character : ICharacter
    {
        private char[,] _buffer;

        Character(char c) {
            this._buffer = new char[5,5];
            for(int i = 0; i < 5; ++i)
                for(int j = 0; j < 5; ++j)
                    this._buffer[i,j] = ' ';

            if (c == '.') {
                _buffer[2,2] = '*';
            } 
        }

        public char[,] buffer() { return this._buffer; }
    }

}