import java.util.Scanner;

public class twoOnN {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        int a=1;
        System.out.println(a);
        for (i=1;i<=n;i++){
            a=a*2;
            System.out.println(a);
        }
    }
}
