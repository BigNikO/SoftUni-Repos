import java.util.Scanner;

public class RectAngleWithStars {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        int j;
        int x=0;
        if (n%2==0)
            x=1;
        else
            x=2;
        for (i=1;i<=n+x;i++){
           for (j=1;j<=2*n;j++)
               if (i==1||i==n+x)
                   System.out.print("%");
                else if (j==1||j==2*n)
                   System.out.print("%");
                else if (i==(n+x+1)/2&&((j==n||j==n+1)))
                   System.out.print("*");
                else
                   System.out.print(" ");
            System.out.println();
        }
    }
}
