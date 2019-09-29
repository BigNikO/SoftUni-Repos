import java.util.Scanner;

public class evenPowersOfTwo {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        int a=1;
        System.out.println(a);
        for (i=2;i<=n;i+=2){
            a=a*4;
            System.out.println(a);
        }
    }
}
