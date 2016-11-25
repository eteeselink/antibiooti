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
            Movie movie = new Movie("movieWrongCommand.txt");
            Assert.Equal(movie.readFile(), "The movie command is not in proper form");
            Movie movie2 = new Movie("movieRightCommand.txt");
            Assert.Equal(movie2.readFile(), "Last symbol is not an integer");
        }
    }
}
