import java.util.Scanner;
public class SquareArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("a = ");
        int a = Integer.parseInt(sc.nextLine());
        int area= a*a;
        System.out.print("area = " + area);
    }
}
