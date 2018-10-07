import java.util.Scanner;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;
import java.util.logging.Level;
import java.util.logging.Logger;

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

    private static boolean threadDemoOn = false;
    private static boolean runnableDemoOn = false;
    private static boolean volatileDemoOn = false;
    private static boolean unsynchronized = false;
    private static boolean synchronizationDemoOn = false;
    private static boolean lockDemoOn = false;
    private static boolean executorDemoOn = true;

    public static void main(String[] args) throws InterruptedException {

        if (threadDemoOn) {
            TaskerByThread run1 = new TaskerByThread();
            run1.start();
            TaskerByThread run2 = new TaskerByThread();
            run2.start();
        }
        if (runnableDemoOn) {
            Thread t1 = new Thread(new TaskerByRunnable());
            Thread t2 = new Thread(new TaskerByRunnable());
            t1.start();
            t2.start();
        }
        if (volatileDemoOn) {
            VolatileDemo tasker = new VolatileDemo();
            tasker.start();
            System.out.println("Hit the space bar to pause");
            Scanner sc = new Scanner(System.in);
            sc.nextLine();
            tasker.kill();
        }

        if (unsynchronized){

            Thread t1 = new Thread(new Runnable() {
                @Override
                public void run() {
                    for (int i = 0; i < 12000; i++) {
                        SynchronizationDemo.count2++;
                    }
                }
            });

            Thread t2 = new Thread(new Runnable() {
                @Override
                public void run() {
                    for (int i = 0; i < 12000; i++) {
                        SynchronizationDemo.count2++;
                    }
                }
            });

            t1.start();
            t2.start();

            t1.join();
            t2.join();

            System.out.println("Counter2: " + SynchronizationDemo.count2);
        }

        if (synchronizationDemoOn){

            Thread t1 = new Thread(new Runnable() {
                @Override
                public void run() {
                    for (int i = 0; i < 12000; i++) {
                        SynchronizationDemo.addToCount();
                    }
                }
            });

            Thread t2 = new Thread(new Runnable() {
                @Override
                public void run() {
                    for (int i = 0; i < 12000; i++) {
                        SynchronizationDemo.addToCount();
                    }
                }
            });

            t1.start();
            t2.start();

            t1.join();
            t2.join();

            System.out.println("Counter2: " + SynchronizationDemo.count2);
        }

        if (lockDemoOn){

            System.out.println("Let's start!");
            long start = System.currentTimeMillis();
            LockDemo locker = new LockDemo();

            Thread t1 = new Thread(new Runnable() {
                @Override
                public void run() {
                    try {
                        locker.doWork();
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                }
            });

            Thread t2 = new Thread(new Runnable() {
                @Override
                public void run() {
                    try {
                        locker.doWork();
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                }
            });

            long end = System.currentTimeMillis();
            System.out.println(end - start);

            t1.start();
            t2.start();
            t1.join();
            t2.join();
            System.out.println("numbers1 size " + locker.number1.size() + " numbers2 size " + locker.number2.size());
        }

        if (executorDemoOn){

            ExecutorService executor = Executors.newFixedThreadPool(2);
            for (int i = 1; i <= 5; i++) {
                executor.submit(new Executor(i));
            }

            executor.shutdown();

            System.out.println("Every work has been divided");

            executor.awaitTermination(60, TimeUnit.SECONDS);
            System.out.println("Every work has been finished");
        }
    }
}
