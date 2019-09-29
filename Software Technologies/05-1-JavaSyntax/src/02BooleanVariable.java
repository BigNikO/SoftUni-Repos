import java.util.Scanner;

public class BooleanVariable {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String checkString = scanner.nextLine();
        boolean checkBoolean = Boolean.valueOf(checkString);
        if (checkBoolean){
            System.out.println("Yes");
        } else{
            System.out.println("No");
        }
    }
}
