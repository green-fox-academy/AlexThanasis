package page;

import game.Game;

import java.awt.*;

public class gamePage extends Page {
    @Override
    public void render(Graphics g) {

        g.setColor(Color.white);
        g.fillRect(0, 0, Game.Width, Game.Height);

    }

    @Override
    public void tick() {

    }
}
