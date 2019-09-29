import java.util.Scanner;

public class ExellentResult {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double n = Double.parseDouble(sc.nextLine());
        if (n>=5.5) {
            System.out.println("Excellent!");
        }
    }
}
