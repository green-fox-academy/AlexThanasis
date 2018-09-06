package game;

import window.Window;

public class Game implements Runnable {
    public static int Width, Height;
    public static String title;
    private boolean running = false;
    private Thread thread;

    public Game(int width, int height, String title) {
        Width = width;
        Height = height;
        Game.title = title;
        new Window(Width, Height, Game.title);
    }

    public void run(){
        long lastTime = System.nanoTime();
        double amountOfTicks = 60.0;
        double ns = 1000000000 / amountOfTicks;
        double delta = 0;
        long timer = System.currentTimeMillis();
        int updates = 0;
        int frames = 0;
        while (running){
            long now = System.nanoTime();
            delta += (now - lastTime) / ns;
            lastTime = now;
            while (delta >= 1){
                tick();
                updates++;
                delta--;
            }
            render();
            frames++;

            if (System.currentTimeMillis() - timer > 1000){
                timer += 1000;
                System.out.println("FPS: " + frames + " TICKS: " + updates);
                frames = 0;
                updates = 0;
            }
        }

    };

    public void start(){

    };

    public void stop(){

    };

    public void tick(){

    }

    public void render(){

    }
}
