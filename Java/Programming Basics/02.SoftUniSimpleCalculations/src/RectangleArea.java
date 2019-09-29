import java.util.Scanner;

public class RectangleArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double x1 = Double.parseDouble(sc.nextLine());
        double y1 = Double.parseDouble(sc.nextLine());
        double x2 = Double.parseDouble(sc.nextLine());
        double y2 = Double.parseDouble(sc.nextLine());
        double x=x1-x2;
        x=Math.abs(x);
        double y=y1-y2;
        y=Math.abs(y);
        double area = x*y;
        double perimeter = 2*(x+y);
        System.out.println(area);
        System.out.println(perimeter);
    }
}
