package input;

import game.Handler;
import object.Ball;
import object.ID;
import object.Object;
import object.Player;

import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class KeyInput extends KeyAdapter {

    private Handler handler;
    private boolean[] keyDown = new boolean[2];

    public KeyInput(Handler handler) {

        this.handler = handler;
        keyDown[0] = false;
        keyDown[1] = false;
    }

    @Override
    public void keyPressed(KeyEvent e) {
        int key = e.getKeyCode();
        for (int i = 0; i < handler.objects.size(); i++) {
            Object temp = handler.objects.get(i);
            if (temp.getId() == ID.Player) {
                Player player = (Player)temp;
                if (key == KeyEvent.VK_W && player.isJumping() == false) {
                    player.setVelY(-10);
                    player.setJumping(true);
                }
                if (key == KeyEvent.VK_A) {player.setVelX(-3); keyDown[0] = true;}
                if (key == KeyEvent.VK_D) {player.setVelX(3); keyDown[1] = true;}
                if (key == KeyEvent.VK_SPACE){if (player.shoot == false){
                    player.shoot = true;
                    player.shootTimer = 0;
                    handler.addObject(new Ball((int)player.getX(), (int)player.getY(), 16, 16, ID.Ball, null, handler ));
                }}
            }
        }
    }

    @Override
    public void keyReleased(KeyEvent e) {
        int key = e.getKeyCode();
        for (int i = 0; i < handler.objects.size(); i++) {
            Object temp = handler.objects.get(i);
            if (temp.getId() == ID.Player) {
                Player player = (Player)temp;
                if (key == KeyEvent.VK_A) {keyDown[0] = false;}
                if (key == KeyEvent.VK_D) {keyDown[1] = false;}

                if (!keyDown[0] && ! keyDown[1]){player.setVelX(0);}
            }
        }
    }

    @Override
    public void keyTyped(KeyEvent e) {
        super.keyTyped(e);
    }


}
