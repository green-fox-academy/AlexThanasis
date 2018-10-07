import java.util.ArrayList;

public class LockDemo {

    private Object lockOne = new Object();
    private Object lockTwo = new Object();

    public ArrayList<Integer> number1 = new ArrayList<Integer>();
    public ArrayList<Integer> number2 = new ArrayList<Integer>();

    public void doorOne() throws InterruptedException{
        synchronized(lockOne){
            number1.add(10);
            Thread.sleep(1);
        }

    }

    public void doorTwo() throws InterruptedException{
        synchronized(lockTwo) {
            number2.add(10);
            Thread.sleep(1);
        }
    }

    public void doWork() throws InterruptedException{
        for (int i = 0; i < 500; i++) {
            doorOne();
            doorTwo();
        }
    }
}
