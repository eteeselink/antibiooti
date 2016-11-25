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

                  Movie outputMovie = new Movie(args[1]);

               }
               else if (func == "char")
               {
                   //Go to Char Function
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
