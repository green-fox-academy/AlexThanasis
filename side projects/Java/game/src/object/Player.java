package object;

import java.awt.*;

public class Player extends Object {

    public Player(float x, float y, int width, int height, ID id) {
        super(x, y, width, height, id);
    }

    @Override
    public void tick() {

    }

    @Override
    public void render(Graphics g) {
        g.setColor(Color.BLACK);
        g.fillRect((int)x, (int)y, width, height);
        g.setColor(Color.GREEN);
        g.drawRect((int)x + 50, (int)y + 50, width, height);
    }
}