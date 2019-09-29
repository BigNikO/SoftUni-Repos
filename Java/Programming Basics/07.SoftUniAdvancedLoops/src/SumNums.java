import java.util.Scanner;

public class SumNums {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int a=0;
        do {
            a=a+n%10;
            n=n/10;
        } while (n>0);
        System.out.println(a);
    }
}
