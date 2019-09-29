import java.util.Scanner;

public class RhombusOfsStars {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int i;
        int j;
        int n = Integer.parseInt(sc.nextLine());
        for (i = 1; i <= n-1; i++) {
            for (j=1;j<=n-i;j++){
                System.out.print(" ");
            }
            System.out.print("*");
            for (j = 1; j <= i - 1; j++) {
                System.out.print(" *");
            }
            System.out.println();
        }
        for (i = n; i >= 1; i--) {
            for (j=1;j<=n-i;j++){
                System.out.print(" ");
            }
            System.out.print("*");
            for (j = 1; j <= i - 1; j++) {
                System.out.print(" *");
            }
            System.out.println();
        }
    }
}
