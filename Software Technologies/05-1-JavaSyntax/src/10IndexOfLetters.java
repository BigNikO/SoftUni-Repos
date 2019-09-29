import java.util.Scanner;

public class IndexOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String alphabet  = "abcdefghijklmnopqrstuvwxyz";
        char[] charAlphabet = new char[alphabet.length()];
        for (int i = 0; i <alphabet.length() ; i++) {
            charAlphabet[i]=alphabet.charAt(i);
        }
        String checkLetters = scanner.nextLine();
        for (int i = 0; i < checkLetters.length() ; i++) {
            char character = checkLetters.charAt(i);
            for (int j = 0; j <charAlphabet.length ; j++) {
                if (character==charAlphabet[j]){
                    System.out.println(character + " -> " + j);
                    break;
                }
            }
        }
    }
}
