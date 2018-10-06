class TaskerByThread extends Thread {

    public void run(){

        for (int i = 0; i < 5; i++){

            System.out.println("Thread: " + i);
            try {
                Thread.sleep(1000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}

class TaskerByRunnable implements Runnable {

    @Override
    public void run(){

        for (int i = 0; i < 5; i++){

            System.out.println("Thread: " + i);
            try {
                Thread.sleep(1000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }

}

public class Main {

    public static void main(String[] args) {
        TaskerByThread run1 = new TaskerByThread();
        run1.start();
        TaskerByThread run2 = new TaskerByThread();
        run2.start();

        Thread t1 = new Thread(new TaskerByRunnable());
        Thread t2 = new Thread(new TaskerByRunnable());
        t1.start();
        t2.start();
    }
}
