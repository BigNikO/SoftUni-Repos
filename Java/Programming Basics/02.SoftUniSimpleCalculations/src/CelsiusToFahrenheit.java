import java.util.Scanner;

public class CelsiusToFahrenheit {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double cel = Double.parseDouble(sc.nextLine());
        double far = cel*1.8+32;
        System.out.printf("%.2f", far);
    }
}
