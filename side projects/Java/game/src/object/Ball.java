package object;

import game.Handler;

import java.awt.*;
import java.awt.image.BufferedImage;

public class Ball extends Object {

    private float defaultX;
    private Handler handler;
    private int distanceOfShooting = 300;

    public Ball(float x, float y, int width, int height, ID id, BufferedImage texture, Handler handler) {
        super(x, y, width, height, id, texture);
        defaultX = x;
        velX = 15f;
        this.handler = handler;
    }

    @Override
    public void tick() {
        x += velX;

        if (x >= defaultX + distanceOfShooting) {

            handler.removeObject(this);
        }
    }

    @Override
    public void render(Graphics g) {

        g.setColor(Color.red);
        g.fillOval((int)x, (int)y, 16, 16);
    }

    @Override
    public Rectangle getBounds() {
        return new Rectangle((int)x, (int)y, width, height);
    }
}
