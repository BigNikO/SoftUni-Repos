import java.util.Scanner;

public class InvalidNum {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num = Integer.parseInt(sc.nextLine());
        if (!(num>=100 && num<=200 || num==0))
        System.out.println("invalid");
    }
}
