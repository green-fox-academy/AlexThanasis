package game;

import java.awt.*;
import java.util.LinkedList;
import object.Object;

public class Handler {

    public LinkedList<Object> objects = new LinkedList<Object>();
    public void tick(){
        for (int i = 0; i < objects.size(); i++){
            Object temp = objects.get(i);
            temp.tick();
        }
    }
    public void render(Graphics g){
        for (int i = 0; i < objects.size(); i++){
            Object temp = objects.get(i);
            temp.render(g);
        }
    }

    public void addObject(Object o){
        objects.add(o);
    }

    public void removeObject(Object o){
        objects.remove(o);
    }

}
