import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double a = Double.parseDouble(sc.nextLine());
        double ha = Double.parseDouble(sc.nextLine());
        double area = a*ha/2;
        System.out.printf("%.2f", area);
    }
}
