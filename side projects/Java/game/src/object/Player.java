package object;

import game.Handler;

import java.awt.*;
import java.awt.image.BufferedImage;

public class Player extends Object {

    private float gravity = 0.5f;
    private float maxSpeed = 10.0f;
    private boolean falling, jumping;
    private Handler handler;

    public Player(float x, float y, int width, int height, ID id, BufferedImage texture, Handler handler) {
        super(x, y, width, height, id, texture);
        this.handler = handler;
    }

    public void setJumping(boolean jumping) {
        this.jumping = jumping;
    }

    public boolean isJumping() {
        return jumping;
    }

    public boolean isFalling() {
        return falling;
    }

    public void setFalling(boolean falling) {
        this.falling = falling;
    }

    @Override
    public void tick() {

        x += velX;
        y += velY;

        if (falling){
            velY += gravity;
            if (velY >= maxSpeed){
                velY = maxSpeed;
            }
        }
        collision();
    }

    public void collision() {
        for (int i = 0; i < handler.objects.size(); i++) {

            Object temp = handler.objects.get(i);

            if  (temp.getId() == ID.Block){
                if(getBounds().intersects(temp.getBounds())){

                    falling = false;
                    jumping = false;
                    velY = 0;
                    y = temp.getY() - height;
                }
                else{
                    falling = true;
                }

                if (getBoundsTop().intersects(temp.getBounds())){
                    y = temp.getY() + height;
                    velY = 0;
                }

                if (getBoundsRight().intersects(temp.getBounds())){
                    x = temp.getX() - width;
                }

                if (getBoundsLeft().intersects(temp.getBounds())){
                    x = temp.getX() + width;
                }
            }
        }
    }

    @Override
    public void render(Graphics g) {

       g.drawImage(texture, (int)x, (int)y, width, height, null);

    }

    @Override
    public Rectangle getBounds() {return new Rectangle((int)x + 5, (int)y + (height - 5), width - 10, 5); }
    public Rectangle getBoundsTop() {return new Rectangle((int)x + 5, (int)y, width - 10, 5);}
    public Rectangle getBoundsLeft() {return new Rectangle((int)x, (int)y + 5, 5, height - 10);}
    public Rectangle getBoundsRight() {return new Rectangle((int)x + (width - 5), (int)y + 5, 5, height - 10);


    }
}
