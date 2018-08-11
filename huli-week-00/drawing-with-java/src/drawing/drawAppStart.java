package drawing;
import javax.swing.*;

public class    drawAppStart {
    public static void main(String[] args){
        JFrame f = new JFrame("Drawing");
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        AnimApplet drawApp = new AnimApplet();
        f.add(drawApp);
        f.setSize(400, 250);
        f.setVisible(true);
    }
}
