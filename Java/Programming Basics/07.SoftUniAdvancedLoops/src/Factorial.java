import java.util.Scanner;

public class Factorial {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        int a=1;
        for (i=1;i<=n;i++){
            a=a*i;
            System.out.println(a);
        }
    }
}
