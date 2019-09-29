import java.util.Scanner;

public class Fibonachi {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int f0 = 1;
        int f1 = 1;
        for (int i = 2;i<=n;i++){
            int fnew = f1+f0;
            f0=f1;
            f1=fnew;
        }
        System.out.println(f1);
    }
}
