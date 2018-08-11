package drawing;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class AnimApplet extends JApplet {

    boolean animationDone;
    int centerX, centerY;
    int w, h;

    public void init(){
        centerX = centerY = 200;
        w = h = 100;
        new Thread(){
            @Override
            public void run(){
                while(!animationDone){
                    updateAnimation();
                    repaint();
                    delayAnimation();
                }
            }
        }.start();
    }

    public void updateAnimation(){
        w +=2;
        h +=2;
    }
    public void delayAnimation(){
       try{
           Thread.sleep(30);
       }
       catch (InterruptedException e){
           e.printStackTrace();
       }
    }
    public void paint(Graphics g){
        g.setColor(Color.GREEN);
        g.fillOval(centerX - w/2, centerY - h/2, 100, 100);
    }
}
