using System;


namespace Antibiooti.Forum2016
{
    public class CommandlineScanner
    {
    
        public void ProcessArgs(string[] args) {
            if (args.length > 0) 
               for (int i = 0; i < length; i++)
            {
               if (args[0] == "text")
               {
                   textInput = args[1] + ";" + args[2];
                   Text outputText = new Text();
                   outputText.processText(textInput);
                   //Go to text function
               }
               else if (args[0] == "movie")
               {
                   //Go to Movie Function
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
