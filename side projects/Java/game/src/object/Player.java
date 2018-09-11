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

    private void collision() {
        for (int i = 0; i < handler.objects.size(); i++) {

            Object temp = handler.objects.get(i);

            if  ()
        }
    }

    @Override
    public void render(Graphics g) {

        g.setColor(Color.black);
        g.fillRect((int)x, (int)y, width, height);

    }
}
