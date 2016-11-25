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
        //Character[] arrayLight;
        // for(int i = 0; i < this.arrayText.Length; i ++) {
        //   return this.arrayText[i];
        //   //  arrayLight[i] = new Character();
        //   //  arrayLight[i].printCharacter(this.arrayText[i], i, ConsoleColor.White);

        // }
        //return this.arrayText[this.arrayText.Length-1].ToString();
    }

    public string getText() {
        return this.text;
    }
    public string getColor() {
        return this.color;
    }
    

} 