package gfx;

import java.awt.image.BufferedImage;

public class Assets {

    public static BufferedImage player, block;

    public Assets() {

        SpriteSheet sheet = new SpriteSheet(ImageLoader.loadImage("/textures/spritesheet.png"));
        player = sheet.out(0, 0, 32, 32);
        block = sheet.out(32, 0, 32, 32);
    }
}
