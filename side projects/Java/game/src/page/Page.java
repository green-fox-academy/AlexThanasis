package page;

import java.awt.*;

public abstract class Page {

    public static Page currentPage = null;

    public abstract void render(Graphics g);
    public abstract void tick();
}
