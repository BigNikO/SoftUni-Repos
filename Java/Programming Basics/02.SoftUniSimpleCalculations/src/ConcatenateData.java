import java.util.Scanner;

public class ConcatenateData {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String firstName = sc.nextLine();
        String lastName = sc.nextLine();
        int age = Integer.parseInt(sc.nextLine());
        String town = sc.nextLine();
        System.out.println("You are " + firstName+ " " + lastName + ", " + "a " + age + "-years old person from " + town+"." );
        System.out.printf("You are %s %s, a %d-years old person from %s.",firstName,lastName,age,town);
    }
}
