import java.util.Scanner;

public class nToOne {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        for (i=n;i>=1;i--)
            System.out.println(i);
    }
}
