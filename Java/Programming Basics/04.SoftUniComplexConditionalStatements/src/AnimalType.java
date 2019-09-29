import java.util.Scanner;

public class AnimalType {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String a = sc.nextLine();
        switch (a)
        {
            case "dog": System.out.println("mammal"); break;
            case "crocodile":
            case "tortoise":
            case "snake": System.out.println("reptile"); break;
            default: System.out.println("unknown"); break;
        }
    }
}


