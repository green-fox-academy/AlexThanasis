package object;

import game.Handler;

import java.awt.*;

public class Player extends Object {

    private float gravity = 0.5f;
    private float maxSpeed = 10.0f;
    private boolean falling, jumping;
    private Handler handler;

    public Player(float x, float y, int width, int height, ID id, Handler handler) {
        super(x, y, width, height, id);
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
            }
        }
    }

    @Override
    public void render(Graphics g) {

        g.setColor(Color.black);
        g.fillRect((int)x, (int)y, width, height);

    }

    @Override
    public Rectangle getBounds() {
        return new Rectangle((int)x, (int)y, width, height);
    }
}
