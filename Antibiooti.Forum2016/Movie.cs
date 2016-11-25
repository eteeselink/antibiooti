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
                FileStream fs = File.Open(this.path, FileMode.Open);
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b,0,b.Length) > 0) 
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        catch (Exception e) {
                return "An unexpected error in opening file happened. Please try again.";                
            }
        return "";
    }
}