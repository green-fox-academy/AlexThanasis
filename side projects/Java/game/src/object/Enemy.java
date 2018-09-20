package object;

import game.Handler;

import java.awt.*;
import java.awt.image.BufferedImage;

public class Enemy extends Object {

    private Handler handler;

    public Enemy(float x, float y, int width, int height, ID id, BufferedImage texture, Handler handler ) {
        super(x, y, width, height, id, texture);
        this.handler = handler;
        velX = -3.5f;
    }

    @Override
    public void tick() {

        x += velX;
        if (x + width < 0){

            handler.removeObject(this);

        }

        collision();
    }

    private void collision(){

        for (int i = 0; i < handler.objects.size(); i++) {

            Object tempObj = handler.objects.get(i);

            if (tempObj.getId() == ID.Player){
                Player player = (Player) tempObj;

                if (getBounds().intersects(player.getBounds()) && getBounds().intersects(player.getBoundsTop()) &&
                        getBounds().intersects(player.getBoundsRight()) && getBounds().intersects(player.getBoundsLeft())){

                        handler.removeObject(player);

                }
            }

            if(tempObj.getId() == ID.Ball){

                handler.removeObject(this);

            }
        }
    }



    @Override
    public void render(Graphics g) {

        g.drawImage(texture, (int)x, (int)y, width, height, null);

    }

    @Override
    public Rectangle getBounds() {
        return new Rectangle((int)x, (int)y, width, height);
    }
}
