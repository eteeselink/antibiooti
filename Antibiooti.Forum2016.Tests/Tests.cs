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

/*
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
            this.assertCharEquals(expectedBuffer, c.buffer()); 
        }

        [Fact]
        public void CheckCharacterBar() {
            ICharacter c = new Character('|');
            char[,] expectedBuffer = new char[,] {
                {' ',' ','*',' ',' '},
                {' ',' ','*',' ',' '},
                {' ',' ','*',' ',' '},
                {' ',' ','*',' ',' '},
                {' ',' ','*',' ',' '}
            };
            this.assertCharEquals(expectedBuffer, c.buffer()); 
        }

        [Fact]
        public void CheckCharacterDash() {
            ICharacter c = new Character('-');
            char[,] expectedBuffer = new char[,] {
                {' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' '},
                {'*','*','*','*','*'},
                {' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' '}
            };
            this.assertCharEquals(expectedBuffer, c.buffer()); 
        }

        [Fact]
        public void CheckCharacterSlash() {
            ICharacter c = new Character('/');
            char[,] expectedBuffer = new char[,] {
                {' ',' ',' ',' ','*'},
                {' ',' ',' ','*',' '},
                {' ',' ','*',' ',' '},
                {' ','*',' ',' ',' '},
                {'*',' ',' ',' ',' '}
            };
            this.assertCharEquals(expectedBuffer, c.buffer()); 
        }

        [Fact]
        public void CheckCharacterBackslash() {
            ICharacter c = new Character('\\');
            char[,] expectedBuffer = new char[,] {
                {'*',' ',' ',' ',' '},
                {' ','*',' ',' ',' '},
                {' ',' ','*',' ',' '},
                {' ',' ',' ','*',' '},
                {' ',' ',' ',' ','*'}
            };
            this.assertCharEquals(expectedBuffer, c.buffer()); 
        }

        [Fact]
        public void CheckCharacterUnknown() {
            bool e = false;
            try {
                ICharacter c = new Character('p');
            } catch(UnknownCharacter) {
                e = true;
            }
            Assert.Equal(e, true);
        }   
        */

        private void assertCharEquals(char[,] b1, char[,] b2) {
            Assert.Equal(b1.GetLength(0), b2.GetLength(0));
            Assert.Equal(b1.GetLength(1), b2.GetLength(1));
            for(int i = 0; i < b1.GetLength(0); ++i)
            for(int j = 0; j < b1.GetLength(1); ++j) {
                Assert.Equal(b1[i,j], b2[i,j]);                   
            }
        }

        [Fact]
        public void CheckTextProcessing()
        {
            Text text = new Text();
            text.processText("/////;b,b,b,b,b");
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
