public class Main {

    public static void main(String[] args) {


        int firstNum= 2, secondNum = 3;
        Human defaultHum = new Human();
        Human newMan = new Human(18, "Manny");
        System.out.println(defaultHum.age + " and " + defaultHum.name + "and mister \n" + newMan.name + newMan.age );

        System.out.println( firstNum + secondNum);


    }

    public static class Human{

        private int age;
        private String name;

        public Human(){
            name = "JohnDoe";
            age = 24;
      }
        public Human(int age, String name){
            this.name = name;
            this.age = age;
        }
    }


}
