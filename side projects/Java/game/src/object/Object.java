package object;

import java.awt.*;
import java.awt.image.BufferedImage;

public abstract class Object {

    protected float x, y;
    protected int width, height;
    protected ID id;
    //protected BufferedImage texture;

    public abstract void tick();
    public abstract void render(Graphics g);
}
