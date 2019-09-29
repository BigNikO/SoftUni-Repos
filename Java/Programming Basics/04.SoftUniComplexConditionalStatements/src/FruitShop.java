import java.util.Scanner;

public class FruitShop {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String f = sc.nextLine();
        String d = sc.nextLine();
        Double x = Double.parseDouble(sc.nextLine());
        if (d.equals("Monday") || d.equals("Tuesday") || d.equals("Wednesday") || d.equals("Thursday") || d.equals("Friday")){
            if (f.equals("banana"))
                System.out.println(x*2.5);
            else if (f.equals("apple"))
                System.out.println(x*1.2);
            else if (f.equals("orange"))
                System.out.println(x*0.85);
            else if (f.equals("grapefruit"))
                System.out.println(x*1.45);
            else if (f.equals("kiwi"))
                System.out.println(x*2.7);
            else if (f.equals("pineapple"))
                System.out.println(x*5.5);
            else if (f.equals("grapes"))
                System.out.println(x*3.85);
            else
                System.out.println("error");
        } else if (d.equals("Saturday")||d.equals("Sunday")){
            if (f.equals("banana"))
                System.out.println(x*2.7);
            else if (f.equals("apple"))
                System.out.println(x*1.25);
            else if (f.equals("orange"))
                System.out.println(x*0.9);
            else if (f.equals("grapefruit"))
                System.out.println(x*1.6);
            else if (f.equals("kiwi"))
                System.out.println(x*3);
            else if (f.equals("pineapple"))
                System.out.println(x*5.6);
            else if (f.equals("grapes"))
                System.out.println(x*4.2);
            else
                System.out.println("error");
        } else
            System.out.println("error");
    }
}
