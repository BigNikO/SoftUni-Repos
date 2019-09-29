import java.util.Scanner;

public class InchesToCentimeters {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("inches:");
        double in = Double.parseDouble(sc.nextLine());
        double sm = 2.54*in;
        System.out.print("centimeters = " + sm);
    }
}
