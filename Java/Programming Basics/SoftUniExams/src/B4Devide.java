import java.util.Scanner;

public class B4Devide {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        int n=Integer.parseInt(sc.nextLine());
        double count=100/(double)n;
        int i;
        double p1=0,p2=0,p3=0;
        for (i=1;i<=n;i++) {
            int num=Integer.parseInt(sc.nextLine());
            if (num % 2 == 0)
                p1++;
            if (num % 3 == 0)
                p2++;
            if (num % 4 == 0)
                p3++;
        }
        System.out.printf("%.2f%% %n%.2f%% %n%.2f%%",(p1*count),(p2*count),(p3*count));
    }
}
