import java.util.Scanner;

public class TrapezoidArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double a = Double.parseDouble(sc.nextLine());
        double b = Double.parseDouble(sc.nextLine());
        double h = Double.parseDouble(sc.nextLine());
        double area = (a+b)*h/2;
        System.out.println("Trapezoid area = " + area);
    }
}
