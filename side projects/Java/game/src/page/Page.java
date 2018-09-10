package page;

import java.awt.*;

public abstract class Page {

    private static Page currentPage = null;

    public static Page getCurrentPage() {
        return currentPage;
    }
    public static void setCurrentPage(Page currentPage) {
        Page.currentPage = currentPage;
    }
    public abstract void render(Graphics g);
    public abstract void tick();
}
