import java.util.Scanner;

public class A6ControlNumber {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n=Integer.parseInt(sc.nextLine());
        int m=Integer.parseInt(sc.nextLine());
        int control=Integer.parseInt(sc.nextLine());
        int sum=0;
        int moves=0;
        for (int i=1;i<=n;i++) {
            for (int j = m; j >= 1; j--) {
                sum = sum + i * 2 + j * 3;
                moves++;
                if (sum >= control)
                    break;
            }
            if (sum >= control)
                break;
        }
        if (sum>=control) {
            System.out.println(moves + " moves");
            System.out.println("Score: " + sum + " >= " + control);
        } else
            System.out.println(moves+ " moves");
    }
}