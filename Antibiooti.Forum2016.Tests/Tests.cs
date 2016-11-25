using System;
using Xunit;

namespace Antibiooti.Forum2016.Tests
{
    public class Tests
    {
        [Fact]
        public void FakeScreenWritesWhereItsSupposedTo() 
        {
            var fakeScreen = new FakeScreen();
            fakeScreen.Write(10, 10, "Hello", ConsoleColor.Blue);
            Assert.Equal(fakeScreen[14, 10].Char, 'o');            
            Assert.Equal(fakeScreen[14, 10].Color, ConsoleColor.Blue);    

            fakeScreen.Clear();
            Assert.Equal(fakeScreen[14, 10].Char, ' ');            
            Assert.Equal(fakeScreen[14, 10].Color, ConsoleColor.White);            
        }

        [Fact]
        public void CheckMovieFileGiven()
        {
            Movie movie = new Movie("");
            Assert.Equal(movie.readFile(), "An unexpected error in opening file happened. Please try again.");
            Movie movie2 = new Movie("movie.txt");
            Assert.Equal(movie2.readFile(), "Success");
        
        }

        [Fact]
        public void CheckMovieCommandFormat()
        {
            Movie movie2 = new Movie("movieWrongCommand.txt");
            Assert.Equal(movie2.readFile(), "The movie command is not in proper form");
        }

        [Fact]
        public void CheckCharacterDot() {
            ICharacter c = new Character('.');
            char[,] expectedBuffer = new char[,] {
                {' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' '},
                {' ',' ','*',' ',' '},
                {' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' '}
            };
            Assert.True(this.charEquals(expectedBuffer, c.buffer())); 
        }

        private bool charEquals(char[,] b1, char[,] b2) {
            Assert.Equal(b1.GetLength(0), b2.GetLength(0));
            Assert.Equal(b1.GetLength(1), b2.GetLength(1));
            for(int i = 0; i < b1.GetLength(0); ++i)
            for(int j = 0; j < b1.GetLength(1); ++j) {
                Assert.Equal(b1[i,j], b2[i,j]);                   
            }
        }
    }
}
