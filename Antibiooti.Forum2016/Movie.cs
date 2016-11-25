using System;
using System.IO;
using System.Text;

class Movie {
    public string path;
    
    public Movie(string path) {
        this.path = path;
    }
    public string readFile()
    {
          try {              
                string[] fs = File.ReadAllLines(this.path);
                foreach (string line in fs)
                {
                    // Use a tab to indent each line of the file.
                    Console.WriteLine("\t" + line);
                }
            }
        catch (Exception) {
                return "An unexpected error in opening file happened. Please try again.";                
            }
        return "";
    }
}