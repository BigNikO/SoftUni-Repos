import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String checkString = scanner.nextLine();
        char check = checkString.charAt(0);
        if (check == 'A' || check == 'E'
                || check == 'I' || check == 'O'
                || check == 'U' || check == 'a' || check == 'e'
                || check == 'i' || check == 'o' || check == 'u') {
            System.out.println("vowel");
        } else if (Character.isDigit(check)) {
            System.out.println("digit");
        } else {
            System.out.println("other");
        }
    }
}
