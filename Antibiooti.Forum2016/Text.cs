using System;

namespace Antibiooti.Forum2016
{
public class Text {
string text, color;
char[] arrayText, arrayColor;
    public void processText(string s) {
        string[] source;
        string text, color;
        source = s.Split(';');
        this.text = source[0];//text
        this.color = source[1];//color
        this.arrayText = source[0].ToCharArray();
        this.arrayColor = source[1].ToCharArray();
        Character[] arrayLight = new Character[this.arrayText.Length];
        Screen screen = new Screen();
        for(int i = 0; i < this.arrayText.Length; i ++) {
          arrayLight[i] = new Character(this.arrayText[i]);
          screen.printCharacter(arrayLight[i], i);
        }
    }
    public string getText() {
        return this.text;
    }
    public string getColor() {
        return this.color;
    }
    

} 
}