public class Text {
string text, color;
char[] arrayText, arrayColor;
    public void processText(string s) {
        string[] source;
        string text, color;
        source = s.Split(';');
        this.text = source[0];//text
        this.color = source[1];//color
        this.arrayText = source[0].value.ToCharArray();
        this.arrayColor = source[1].value.ToCharArray();
        //loop through array text
        //inside the loop 
        //send the posi (loop i),char of array text, char of array color 
        //ddne
        for(int i = 0; i < this.arrayText.length; i ++) {
            //
        }
    }

    public string getText() {
        return this.text;
    }
    public string getColor() {
        return this.color;
    }
    

} 