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
        public void CheckMovieNoFileGiven()
        {
            Movie movie = new Movie("");
            Assert.Equal(movie.readFile(), "An unexpected error in opening file happened. Please try again.");
        
        }

        [Fact]
        public void CheckMovieFileGiven()
        {
            Movie movie = new Movie("movie.txt");
            movie.readFile();
        
        }

        [Fact]
        public void TestCommandlineScanner()
        {
            string[] args = new string[] {"te", "111"};
            CommandlineScanner scanner = new CommandlineScanner();
            scanner.ProcessArgs(args);

            
            string[] args1 = new string[] {"text"};
            scanner = new CommandlineScanner();
            scanner.ProcessArgs(args1);

            
            string[] args2 = new string[] {"text", "oo.OO"};
            scanner = new CommandlineScanner();
            scanner.ProcessArgs(args2);

            string[] args3 = new string[] {"text", "oo.OO", "r,g,b,b,r"};
            scanner = new CommandlineScanner();
            scanner.ProcessArgs(args3);
        }
    }
}
