public class SynchronizationDemo {
   // private int count;
    public static int count2;

    public static synchronized void addToCount(){
        count2++;
    }

//    public void threadWork() throws InterruptedException {
//        Thread t1 = new Thread(new Runnable() {
//            @Override
//            public void run() {
//                for (int i = 0; i < 12000; i++) {
//                   count++;
//                }
//            }
//        });
//        Thread t2 = new Thread(new Runnable() {
//            @Override
//            public void run() {
//                for (int i = 0; i < 12000; i++) {
//                    count++;
//                }
//            }
//        });
//
//        t1.start();
//        t2.start();
//
//        System.out.println("Count értéke: " + count);
//    }
}
