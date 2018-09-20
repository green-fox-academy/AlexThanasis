package gfx;

import java.awt.image.BufferedImage;

public class Assets {

    public static BufferedImage player, block, enemy;

    public Assets() {

        try {
            SpriteSheet sheet = new SpriteSheet(ImageLoader.loadImage("/spritesheet.png"));
            player = sheet.out(0, 0, 32, 32);
            block = sheet.out(32, 0, 32, 32);
            enemy = sheet.out(64, 0, 32, 32);
        }
        catch(Exception e){
            System.out.println("assets cannot be loaded!");
        }
    }
}
