public class Executor implements Runnable {

    private int id;

    public Executor(int id) {
        this.id = id;
    }

    @Override
    public void run() {
        System.out.println("Task has been launched. id: " + id);
        try{
            Thread.sleep(300);
        }
        catch(InterruptedException ex){
            System.out.println("" + ex);
        }
        System.out.println("Task has been finished. id: " + id);
    }
}
