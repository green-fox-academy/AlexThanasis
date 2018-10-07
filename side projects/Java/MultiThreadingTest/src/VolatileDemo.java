public class VolatileDemo extends Thread {

    private volatile boolean runner = true;

    @Override
    public void run(){

        while(runner){

            System.out.println("I am running");
            try {
                Thread.sleep(1000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }

    public void kill(){
        this.runner = false;
    }
}
