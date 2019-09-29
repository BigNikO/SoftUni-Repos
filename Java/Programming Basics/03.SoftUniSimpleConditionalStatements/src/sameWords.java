import java.util.Scanner;

public class sameWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String word1 = sc.nextLine();
        String word2 = sc.nextLine();
        word1 = word1.toLowerCase();
        word2 = word2.toLowerCase();
        if (word1.equals(word2))
            System.out.println("yes");
        else
            System.out.println("no");
    }
}
