import java.util.Scanner;

public class OnToHundred {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num = Integer.parseInt(sc.nextLine());
        while (num < 1 || num > 100) {
            System.out.println("Invalid number!");
            num = Integer.parseInt(sc.nextLine());
        }
        System.out.println("The number is: " + num);
    }
}
