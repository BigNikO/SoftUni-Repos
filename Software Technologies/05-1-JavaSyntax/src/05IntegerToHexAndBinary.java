import java.util.Scanner;

public class IntegerToHexAndBinary {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String number = scanner.nextLine();
        int hexNumber = Integer.parseInt(number);
        int binaryNumber = Integer.parseInt(number);
        System.out.println(Integer.toHexString(hexNumber).toUpperCase());
        System.out.println(Integer.toBinaryString(binaryNumber));
    }
}
