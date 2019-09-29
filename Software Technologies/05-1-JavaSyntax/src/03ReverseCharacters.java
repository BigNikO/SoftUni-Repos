import java.util.Scanner;

public class ReverseCharacters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String letterOne = scanner.nextLine();
        String letterTwo = scanner.nextLine();
        String LetterThree = scanner.nextLine();
        String reversed = LetterThree+letterTwo+letterOne;
        System.out.println(reversed);

    }
}
