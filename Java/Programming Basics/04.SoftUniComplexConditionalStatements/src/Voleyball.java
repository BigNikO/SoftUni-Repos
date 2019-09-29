import java.util.Scanner;

public class Voleyball {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String y = sc.nextLine();
        int p = Integer.parseInt(sc.nextLine());
        int h = Integer.parseInt(sc.nextLine());
        double r;
        r = (2*(double)p/3 + ((48-(double)h)*3/4)+(double)h);
        if (y.equals("leap"))
            r = r*1.15;
        System.out.println((int)r);
    }
}
