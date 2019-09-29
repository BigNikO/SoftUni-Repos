import java.util.Scanner;

public class A4Histogram {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        double p = 100/(double)n;
        double p1=0,p2=0,p3=0,p4=0,p5=0;
        for (int i = 1; i<=n;i++){
            int number = Integer.parseInt(sc.nextLine());
            if (number<200)
                p1++;
            else if(number<400)
                p2++;
            else if(number<600)
                p3++;
            else if(number<800)
                p4++;
            else if(number>=800)
                p5++;
        }
        p1=p1*p;
        p2=p2*p;
        p3=p3*p;
        p4=p4*p;
        p5=p5*p;
        System.out.printf("%.2f%% %n%.2f%% %n%.2f%% %n%.2f%% %n%.2f%%",p1,p2,p3,p4,p5);
    }
}
