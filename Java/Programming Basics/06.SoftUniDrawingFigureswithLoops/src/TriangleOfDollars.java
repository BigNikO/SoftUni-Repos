import java.util.Scanner;

public class TriangleOfDollars {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        int i;
        int n = Integer.parseInt(sc.nextLine());
        for (i=1;i<=n;i++) {
            for (int j=0;j<i;j++){
                System.out.print("$ ");
            }
            System.out.println();
        }
    }
}
