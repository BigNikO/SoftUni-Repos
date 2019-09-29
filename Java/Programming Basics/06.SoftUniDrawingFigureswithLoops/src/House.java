import java.util.Scanner;

public class House {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int i;
        int j;
        int n = Integer.parseInt(sc.nextLine());
        if (n%2==0){
            for (i = 1; i <= n/2; i++) {
                for (j=1;j<=n/2-i;j++){
                    System.out.print("-");
                }
                for (j=1;j<=2*i;j++){
                    System.out.print("*");
                }
                for (j=1;j<=n/2-i;j++){
                    System.out.print("-");
                }
                System.out.println();
            }
            for (i=1;i<=n/2;i++){
                for (j=1;j<=n;j++){
                    if (j==1||j==n)
                        System.out.print("|");
                    else
                        System.out.print("*");
                }
                System.out.println();
            }
        } else{
            int p = -1;
            for (i = 1; i <= (n+1)/2; i++) {
                p=p+2;
                for (j=1;j<=(n+1)/2-i;j++){
                    System.out.print("-");
                }
                for (j=1;j<=p;j++){
                    System.out.print("*");
                }
                for (j=1;j<=(n+1)/2-i;j++){
                    System.out.print("-");
                }
                System.out.println();
            }
            for (i=1;i<=n/2;i++){
                for (j=1;j<=n;j++){
                    if (j==1||j==n)
                        System.out.print("|");
                    else
                        System.out.print("*");
                }
                System.out.println();
            }
        }

    }
}
