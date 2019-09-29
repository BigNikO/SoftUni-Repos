import java.util.Scanner;

public class PerfectDiamond {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        int j;
        for (i=1;i<=n;i++){
            for (j=1;j<=n-i;j++)
                System.out.print(" ");
            for (j=1;j<=i;j++)
                if (j==1)
                System.out.print("*");
                else
                System.out.print("-*");
            System.out.println();
        }
        for (i=n-1;i>=1;i--){
            for (j=1;j<=n-i;j++)
                System.out.print(" ");
            for (j=1;j<=i;j++)
                if (j==1)
                    System.out.print("*");
                else
                    System.out.print("-*");
            System.out.println();
        }
    }
}
