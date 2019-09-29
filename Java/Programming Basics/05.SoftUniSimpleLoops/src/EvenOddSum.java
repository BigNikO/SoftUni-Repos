import java.util.Scanner;

public class EvenOddSum {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        int s1 = 0;
        int s2 = 0;
        for (i=1;i<=n;i++){
            int q = Integer.parseInt(sc.nextLine());
            if (i%2==0)
                s1=s1+q;
            else
                s2=s2+q;
        }
        if (s1==s2)
            System.out.println("Yes, sum = " + s1);
        else if (s1>s2)
            System.out.println("No, diff = " + (s1-s2));
        else
            System.out.println("No, diff = " + (s2-s1));

    }
}

