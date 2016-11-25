using System;

namespace Antibiooti.Forum2016
{

    class Character : ICharacter
    {
        private char[,] _buffer = new char[5,5];
        public char[,] buffer() { return _buffer; }
    }

}