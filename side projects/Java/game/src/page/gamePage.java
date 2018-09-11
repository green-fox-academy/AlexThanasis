package page;

import game.Game;
import game.Handler;
import object.ID;
import object.Player;

import java.awt.*;

public class gamePage extends Page {

    public Player player;
    public Handler handler;

    public gamePage() {

        handler = new Handler();
        player = new Player(10, 10, 32, 32, ID.Player);
        handler.addObject(player);

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
