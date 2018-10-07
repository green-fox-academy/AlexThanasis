public class Main {

    public static void main(String[] args) {
        Y x = null;
        Y y = new Y();
        System.out.println(x.i);
    }
}

class X {
    static int i = 1111;

    static {i = i-- - --i;}

    {i = i++ + ++i;}

    public X() {i = i++ + --i;}
}

class Y extends X {
    static {i = --i - i--;}
    {i = ++i + i++;}
}
