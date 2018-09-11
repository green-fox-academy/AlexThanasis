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

    public float getX() {
        return x;
    }

    public void setX(float x) {
        this.x = x;
    }

    public float getY() {
        return y;
    }

    public void setY(float y) {
        this.y = y;
    }

    public int getWidth() {
        return width;
    }

    public void setWidth(int width) {
        this.width = width;
    }

    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        this.height = height;
    }

    public ID getId() {
        return id;
    }

    public void setId(ID id) {
        this.id = id;
    }

    public abstract void tick();
    public abstract void render(Graphics g);
}
