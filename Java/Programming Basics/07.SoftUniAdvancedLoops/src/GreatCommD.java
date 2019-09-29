import java.util.Scanner;

public class GreatCommD {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a = Integer.parseInt(sc.nextLine());
        int b = Integer.parseInt(sc.nextLine());
        while (b != 0) {
            int prevB = b;
            b = a % b;
            a = prevB;
        }
        System.out.println(a);

    }
}
