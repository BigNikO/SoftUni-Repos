import java.util.Scanner;
public class Squre {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String fig = sc.nextLine();
        if (fig.equals("square")) {
            double s = Double.parseDouble(sc.nextLine());
            System.out.println(s * s);
        } else if (fig.equals("rectangle")) {
            double s = Double.parseDouble(sc.nextLine());
            double m = Double.parseDouble(sc.nextLine());
            System.out.println(s * m);
        } else if (fig.equals("circle")) {
            double s = Double.parseDouble(sc.nextLine());
            s = Math.PI*s*s;
            System.out.println(s);
        }else if (fig.equals("triangle")) {
            double s = Double.parseDouble(sc.nextLine());
            double m = Double.parseDouble(sc.nextLine());
            System.out.println((s * m)/2);
        }
    }
}
