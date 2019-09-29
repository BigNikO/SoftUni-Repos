import java.util.Scanner;

public class RowOfNums {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        int a=0;
        for (i=0;i<=n;i++){
            if (2*a+1>n)
                break;
            a = 2*a+1;
            System.out.println(a);
        }
    }
}
