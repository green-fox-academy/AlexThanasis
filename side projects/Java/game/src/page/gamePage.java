package page;

import game.Game;
import game.Handler;
import input.KeyInput;
import object.Block;
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

        for (int i = 0; i < 10; i++) {

            handler.addObject(new Block(10 + (i * 32), Game.Height -160, 32, 32, ID.Block));

        }
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
