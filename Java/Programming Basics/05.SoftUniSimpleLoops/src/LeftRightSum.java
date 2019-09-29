import java.util.Scanner;

public class LeftRightSum {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        int s1 = 0;
        int s2 = 0;
        for (i=1;i<=2*n;i++){
            int q = Integer.parseInt(sc.nextLine());
            if (i<=n)
                s1=s1+q;
            else
                s2=s2+q;
        }
        if (s1==s2)
            System.out.println("Yes, sum = " + s1);
        else
            System.out.println("No, diff = " + Math.abs(s1-s2));

    }
}
