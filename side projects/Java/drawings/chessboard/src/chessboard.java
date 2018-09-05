import java.awt.Color;
import java.awt.Graphics;
import javax.swing.JFrame;
import javax.swing.JPanel;

public class chessboard extends JPanel {

    int startX = 100;
    int startY = 100;
    int widthOfTheBoard = 400;
    int checkSize = widthOfTheBoard / 8;

    public void paint(Graphics g){
        g.fillRect(startX, startY, widthOfTheBoard, widthOfTheBoard);
        boolean switcher = true;
        for (int j = 1; j <= 8; j++){
            switcher = !switcher;
            for (int i = 1; i <= 8; i++){
                switcher = !switcher;
                if(switcher){
                    g.clearRect(startX + checkSize * (i - 1), startY + checkSize * (j - 1), checkSize, checkSize);}
            }
        }
    }

    public static void main(String[] args){
        JFrame jFrame = new JFrame();
        jFrame.setSize(400, 400);
        jFrame.getContentPane().add(new chessboard());
        jFrame.setLocationRelativeTo(null);
        jFrame.setBackground(Color.LIGHT_GRAY);
        jFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        jFrame.setVisible(true);
    }
}
