package game;

import window.Window;

public class Game {
    public static int Width, Height;
    public static String title;

    public Game(int width, int height, String title) {
        Width = width;
        Height = height;
        Game.title = title;
        new Window(Width, Height, Game.title);
    }
}
