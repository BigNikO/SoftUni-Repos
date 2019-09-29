import java.util.Scanner;

public class Diamond {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int i;
        int j;
        int n = Integer.parseInt(sc.nextLine());
        int p=0;
        int a=1;
        for (i = 0; i < n/2; i++) {
            for (j=1;j<=(n-1)/2-i;j++){
                System.out.print("-");
            }
            if (n%2==0||i>0) {
                if (n%2==0){
                    p = 1;
                    a=3;
                }
                System.out.print("*");
            }
            if (2*i>0)
                for (j=1;j<2*i+p;j++){
                    System.out.print("-");
                }
            System.out.print("*");
            for (j=1;j<=(n-1)/2-i;j++){
                System.out.print("-");
            }
            if (n==2)
                break;
            System.out.println();
        }
        for (i = (n-a)/2; i >= 0; i--) {
            if (n==2)
                break;
            for (j=1;j<=(n-1)/2-i;j++){
                System.out.print("-");
            }
            if (n%2==0||i>0) {
                System.out.print("*");
            }
            if (2*i>0)
                for (j=1;j<2*i+p;j++){
                    System.out.print("-");
                }
            System.out.print("*");
            for (j=1;j<=(n-1)/2-i;j++){
                System.out.print("-");
            }
            System.out.println();
        }
    }
}
