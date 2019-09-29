import java.util.Scanner;

public class LittleShop {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String p = sc.nextLine();
        String city = sc.nextLine();
        Double x = Double.parseDouble(sc.nextLine());
        if (city.equals("Sofia")){
            if (p.equals("coffee"))
                System.out.println(x*0.5);
            else if (p.equals("water"))
                System.out.println(x*0.8);
            else if (p.equals("beer"))
                System.out.println(x*1.2);
            else if (p.equals("sweets"))
                System.out.println(x*1.45);
            else if (p.equals("peanuts"))
                System.out.println(x*1.6);
        } else if (city.equals("Plovdiv")){
            if (p.equals("coffee"))
                System.out.println(x*0.4);
            else if (p.equals("water"))
                System.out.println(x*0.7);
            else if (p.equals("beer"))
                System.out.println(x*1.15);
            else if (p.equals("sweets"))
                System.out.println(x*1.30);
            else if (p.equals("peanuts"))
                System.out.println(x*1.5);
        } else if (city.equals("Varna")){
            if (p.equals("coffee"))
                System.out.println(x*0.45);
            else if (p.equals("water"))
                System.out.println(x*0.7);
            else if (p.equals("beer"))
                System.out.println(x*1.10);
            else if (p.equals("sweets"))
                System.out.println(x*1.35);
            else if (p.equals("peanuts"))
                System.out.println(x*1.55);
        }
    }
}
