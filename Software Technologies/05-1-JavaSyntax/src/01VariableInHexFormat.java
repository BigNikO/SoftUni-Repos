import java.util.Scanner;

public class JavaInHexaDecimalFormat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String number = scanner.nextLine();
        int intNumber = Integer.parseInt(number, 16);
        System.out.println(intNumber);
    }
}
