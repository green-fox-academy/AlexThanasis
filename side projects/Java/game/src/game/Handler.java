package game;

import java.util.LinkedList;

public class Handler {

    public LinkedList<Object> objects = new LinkedList<Object>();
    public void tick(){
        for (int i = 0; 1 < objects.size(); i++){
            Object temp = objects.get(i);
            temp.tick();
        }
    };

}
