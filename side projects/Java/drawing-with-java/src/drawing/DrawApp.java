package drawing;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;


public class DrawApp extends JPanel {

    public void paintComponent(Graphics g) {
        super.paintComponent(g);
        this.setBackground(Color.CYAN);

        g.setColor(Color.BLUE);
        g.fillRect(25, 25, 100, 30);

        g.setColor(new Color(190, 81, 215));
        g.fillRect(25, 65, 100, 30);

        g.setColor(Color.RED);
        g.drawString("this is a text", 25, 120);
    }
}
