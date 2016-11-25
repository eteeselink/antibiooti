using System;


namespace Antibiooti.Forum2016
{
    public class CommandlineScanner
    {
    
        public void ProcessArgs(string[] args) {
            if (args.Length > 0) 
            
            {
               if (args[0] == "text")
               {
                   string textInput;
                   textInput = args[1] + ";" + args[2];
                   Text outputText = new Text();
                   outputText.processText(textInput);
                   //Go to text function
               }
               else if (args[0] == "movie")
               {
                  Movie outputMovie = new Movie(args[1]);

               }
               else 
               {
                   //Go to Char Function
               }

            }
            else
            {
                System.Console.WriteLine("Please provide valid inputs");
        }
        }
}
}
