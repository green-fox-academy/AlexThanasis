package object;

import java.awt.*;

public class Player extends Object {

    public Player(float x, float y, int width, int height, ID id) {
        super(x, y, width, height, id);
    }

    @Override
    public void tick() {

        x += velX;
        y += velY;

    }

    @Override
    public void render(Graphics g) {

        g.setColor(Color.black);
        g.fillRect((int)x, (int)y, width, height);

    }
}
