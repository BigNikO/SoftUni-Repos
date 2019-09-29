import java.util.Scanner;

public class SunGlasses {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int i;
        int j;
        int n = Integer.parseInt(sc.nextLine());
        for (i = 1; i <= n; i++) {
            if (i == 1 || i == n){
                for (j=1;j<=5*n;j++) {
                    if (j<=2*n)
                        System.out.print("*");
                    else if (j<=3*n)
                        System.out.print(" ");
                    else
                        System.out.print("*");
                }
            } else if (i==(((n-1)/2)+1)){
                for (j=1;j<=5*n;j++){
                    if (j==1||j==2*n||j==3*n+1||j==5*n)
                        System.out.print("*");
                    else if (j>2*n&&j<=3*n)
                        System.out.print("|");
                    else
                        System.out.print("/");
                }
            } else {
                for (j=1;j<=5*n;j++){
                    if (j==1||j==2*n||j==3*n+1||j==5*n)
                        System.out.print("*");
                    else if (j>2*n&&j<=3*n)
                        System.out.print(" ");
                    else
                        System.out.print("/");
                }
            }
                System.out.println();
        }
    }
}
