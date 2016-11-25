using System;

namespace Antibiooti.Forum2016
{
public class Text {
string text;
string[] color;
char[] arrayText;
    public void processText(string s) {
        string[] source;
        string text, color;
        source = s.Split(';');
        this.text = source[0];//text
        this.color = source[1].Split(',');//color
        ConsoleColor[] consoleColors = new ConsoleColor[this.color.Length];

        for (int i = 0; i < this.color.Length; i++) {
            if (this.color[i] == "b") {
                consoleColors[i] = ConsoleColor.Blue;
            }
            else if (this.color[i] == "r") {
                consoleColors[i] = ConsoleColor.Red;
            }
            else if (this.color[i] == "g") {
                consoleColors[i] = ConsoleColor.Green;
            }

        }

        this.arrayText = source[0].ToCharArray();
        Character[] arrayLight = new Character[this.arrayText.Length];
        Screen screen = new Screen();
        for(int i = 0; i < this.arrayText.Length; i ++) {
            arrayLight[i] = new Character(this.arrayText[i]);
            screen.printCharacter(arrayLight[i], i, consoleColors[i]);
        }
    }
} 
}