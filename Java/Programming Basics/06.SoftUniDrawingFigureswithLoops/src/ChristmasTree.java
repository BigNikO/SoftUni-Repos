import java.util.Scanner;

public class ChristmasTree {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int i;
        int j;
        int n = Integer.parseInt(sc.nextLine());
        for (i = 0; i <= n; i++) {
                System.out.print(" ");
        }
            System.out.print("|");
        for (i = 0; i <= n; i++) {
            for (j=1;j<=n-i;j++){
                System.out.print(" ");
            }
            for (j = 1; j <= i ; j++) {
                if (j==i) {
                    System.out.print("* | ");
                    for (j=1;j<=i;j++)
                        System.out.print("*");
                }
                else
                    System.out.print("*");
            }
            System.out.println();
        }
    }
}
