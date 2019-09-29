import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int x1 = Integer.parseInt(sc.nextLine());
        int y1 = Integer.parseInt(sc.nextLine());
        int x2 = Integer.parseInt(sc.nextLine());
        int y2 = Integer.parseInt(sc.nextLine());
        int x3 = Integer.parseInt(sc.nextLine());
        int y3 = Integer.parseInt(sc.nextLine());
        double a = Math.abs(x2-x3);
        double ha = Math.abs(y1-y2);
        double s = a*ha/2;
        System.out.println(s);
    }
}
