public class Text {
string text, color;
    public void processText(string s) {
        string[] source;
        string text, color;
        source = s.Split(';');
        this.text = source[0];
        this.color = source[1];
    }

    public void getText() {
        return this.text;
    }
    public void getColor() {
        return this.color;
    }
    

} 