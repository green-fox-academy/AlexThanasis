package object;

import java.awt.*;
import java.awt.image.BufferedImage;

public class Block extends Object {

    public Block(float x, float y, int width, int height, ID id, BufferedImage texture) {
        super(x, y, width, height, id, texture);
    }

    @Override
    public void tick() {

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
