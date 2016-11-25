using System;

namespace Antibiooti.Forum2016
{

    class UnknownCharacter : Exception {}

    class Character : ICharacter
    {
        private char[,] _buffer;

        public Character(char c) {
            this._buffer = new char[5,5];
            for(int i = 0; i < 5; ++i)
                for(int j = 0; j < 5; ++j)
                    this._buffer[i,j] = ' ';

            if (c == '.') {
                _buffer[2,2] = '*';
            } 
            else if (c == '\\') {
                _buffer[0,0] = '*';
                _buffer[1,1] = '*';
                _buffer[2,2] = '*';
                _buffer[3,3] = '*';
                _buffer[4,4] = '*';
            } 
            else if (c == '/') {
                _buffer[0,4] = '*';
                _buffer[1,3] = '*';
                _buffer[2,2] = '*';
                _buffer[3,1] = '*';
                _buffer[4,0] = '*';
            } else {
                throw new UnknownCharacter();
            }
        }

        public char[,] buffer() { return this._buffer; }
    }

}