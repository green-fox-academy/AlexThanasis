package object;

import java.awt.*;
import java.awt.image.BufferedImage;

public abstract class Object {

    protected float x, y;
    protected int width, height;
    protected ID id;
    //protected BufferedImage texture;


    public Object(float x, float y, int width, int height, ID id) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        this.id = id;
    }

    public abstract void tick();
    public abstract void render(Graphics g);
}
