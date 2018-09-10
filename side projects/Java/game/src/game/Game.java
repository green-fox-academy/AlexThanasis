package game;

import window.Window;

import java.awt.*;
import java.awt.image.BufferStrategy;

public class Game implements Runnable {
    public static int Width, Height;
    public static String title;
    private boolean running = false;
    private Window window;
    private Thread thread;
    private BufferStrategy buffer;
    private Graphics g;

    public Game(int width, int height, String title) {
        Width = width;
        Height = height;
        Game.title = title;
        window = new Window(Width, Height, Game.title);
        start();
    }

    public void run(){
        window.getCanvas().requestFocus();
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
        stop();

    }

    public void start(){

        thread = new Thread(this);
        thread.start();
        running = true;
    }

    public void stop(){
        try {
            thread.join();
            running = false;
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void tick(){

    }

    public void render(){

        buffer = window.getCanvas().getBufferStrategy();
        if (buffer == null){
            window.getCanvas().createBufferStrategy(3);
            return;
        }
        g = buffer.getDrawGraphics();
        g.clearRect(0, 0, Width, Height);
        //DRAW
        /*
        g.setColor(new Color(255, 255, 100));
        g.fillRect(10, 10, 32, 32);
        g.setColor(Color.cyan);
        g.drawRect(60,60, 32,32);

        g.setFont(new Font("Arial", Font.BOLD, 25));
        g.draw3DRect(100, 100, 64, 64, true);
        g.drawString("staff to write", 200, 200);
        */
        //END
        g.setColor(Color.white);
        g.fillRect(0, 0, Width, Height);
        buffer.show();
        g.dispose();
    }
}
