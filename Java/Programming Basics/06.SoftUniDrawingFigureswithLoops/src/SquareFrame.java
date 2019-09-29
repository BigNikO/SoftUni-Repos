import java.util.Scanner;

public class SquareFrame {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int i;
        int n = Integer.parseInt(sc.nextLine());
        for (i = 1; i <= n; i++) {
            if(i==1||i==n){
                System.out.print("+ ");
                for (int j = 1; j <= n-2; j++) {
                    System.out.print("- ");
                }
                System.out.print("+");
            } else {
                System.out.print("| ");
                for (int j = 1; j <= n-2; j++) {
                    System.out.print("- ");
                }
                System.out.print("|");
            }
            System.out.println();
        }
    }
}
