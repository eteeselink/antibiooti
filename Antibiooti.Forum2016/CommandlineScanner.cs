using System;


namespace Antibiooti.Forum2016
{
    public class CommandlineScanner
    {
    
        public void ProcessArgs(string[] args) {

            if (args.Length < 1) {
                OutputErrorMessage();
                return;
            }

            string func = args[0].ToLower();

            if (func != "text" && func != "movie" && func != "char") {
                OutputErrorMessage();
                return;
            }

               if (func == "text")
               {
                   if (args.Length <= 2) {
                        OutputErrorMessage();
                        return;
                   }

                    string text = args[1];
                    string color = args[2];
                   string textInput = text + ";" + color;
                   Console.WriteLine(textInput);

                   Text outputText = new Text();
                   outputText.processText(textInput);
                   //Go to text function
               }
               else if (func == "movie")
               {
                   string filePath = args[1]; 
                   Console.WriteLine(filePath);

                  Movie outputMovie = new Movie(filePath);
                  outputMovie.readFile();

               }
               else if (func == "char")
                 
               {
                    string pos = args[1];
                    string chr = args[2];
                    string color = args[3];

                    Console.WriteLine(pos);
                    Console.WriteLine(chr);
                    Console.WriteLine(color);

                    int pos2 = Int32.Parse(pos);

                Screen scr=new Screen();
                Character c = new Character(chr[0]);
           
           // TODO Convert the color to ConsoleColor.
           scr.printCharacter(c, pos2, ConsoleColor.White);
                   
               }
               else {
                   OutputErrorMessage();
               }

        }

        private void OutputErrorMessage()
        {
            System.Console.WriteLine("Please provide valid inputs");
        }
    }
}
