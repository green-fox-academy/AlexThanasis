package page;

import game.Game;
import game.Handler;
import input.KeyInput;
import object.ID;
import object.Player;

import java.awt.*;

public class gamePage extends Page {

    public Player player;
    public Handler handler;
    public KeyInput input;

    public gamePage(Game game) {

        handler = new Handler();
        player = new Player(100, 100, 32, 32, ID.Player, handler);
        input = new KeyInput(handler);
        handler.addObject(player);
        game.getWindow().getCanvas().addKeyListener(input);
    }

    public void render(Graphics g) {

        g.setColor(Color.white);
        g.fillRect(0, 0, Game.Width, Game.Height);
        handler.render(g);

    }

    public void tick() {

        handler.tick();

    }
}
