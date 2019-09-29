import java.util.Scanner;

public class SumNums {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        int p=0;
        for (i=0;i<n;i++){
            int q = Integer.parseInt(sc.nextLine());
            p=p+q;
        }
        System.out.println(p);
    }
}

