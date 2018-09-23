package page;

import game.Game;
import game.Handler;
import gfx.Assets;
import input.KeyInput;
import object.Block;
import object.Enemy;
import object.ID;
import object.Player;

import java.awt.*;

public class gamePage extends Page {

    public Player player;
    public Handler handler;
    public KeyInput input;

    public gamePage(Game game) {

        new Assets();
        handler = new Handler();
        player = new Player(100, 100, 32, 32, ID.Player, Assets.player, handler);
        input = new KeyInput(handler);
        handler.addObject(player);
        game.getWindow().getCanvas().addKeyListener(input);

        handler.addObject(new Block(42, Game.Height - 192, 32, 32, ID.Block, Assets.block));
        handler.addObject(new Block(10 + 5 * 32, Game.Height - 256, 32, 32, ID.Block, Assets.block));
        handler.addObject(new Enemy(250, Game.Height - 192, 32, 32, ID.Enemy, Assets.enemy, handler));
        handler.addObject(new Enemy(350, Game.Height - 192, 32, 32, ID.Enemy, Assets.enemy, handler));
        for (int i = 0; i < 20; i++) {

            handler.addObject(new Block(10 + (i * 32), Game.Height -160, 32, 32, ID.Block, Assets.block));

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
