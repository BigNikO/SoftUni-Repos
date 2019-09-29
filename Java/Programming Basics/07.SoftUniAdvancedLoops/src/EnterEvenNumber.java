import java.util.Scanner;

public class EnterEvenNumber {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n;
        while (true){
            try {
                n = Integer.parseInt(sc.nextLine());
                if (n%2==0)
                    break;
                System.out.println("The number is not even.");
            }catch (NumberFormatException ex){
                System.out.println("Invalid number.");
            }
        }
        System.out.println("Even number enetered: " + n);
    }
}
