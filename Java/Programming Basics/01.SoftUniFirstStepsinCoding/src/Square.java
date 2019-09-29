import java.util.Scanner;
public class Square {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        for (int i = 1; i < n+1; i++) {
            for (int j = 1; j<n+1; j++) {
                System.out.print((j==1)||(j==n)||(i==1)||(i==n) ? "*":" ");
            }
            System.out.println("");
        }
    }
}
