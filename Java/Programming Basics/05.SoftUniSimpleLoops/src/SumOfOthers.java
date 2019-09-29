import java.util.Scanner;
public class SumOfOthers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        int p = Integer.parseInt(sc.nextLine());
        int sum=p;
        for (i=0;i<n-1;i++){
            int q = Integer.parseInt(sc.nextLine());
            if (p<q)
                p=q;
            sum = sum + q;
        }
        if ((sum-p) == p)
        System.out.println("Yes, Sum = " + (sum - p));
        else
            System.out.println("No, Diff = " + Math.abs(sum-p-p));
    }
}
