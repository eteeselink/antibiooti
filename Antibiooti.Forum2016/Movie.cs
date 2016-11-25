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
                    string[] commands = line.Split(';');
                    if (commands.Length != 3){
                        return "The movie command is not in proper form";
                    }
                    int n;
                    bool isInteger = int.TryParse(commands[2], out n);
                    if(!isInteger)
                        return "Last symbol is not an integer";

                }
            }
        catch (Exception) {
                return "An unexpected error in opening file happened. Please try again.";                
            }
        return "Success";
    }
}