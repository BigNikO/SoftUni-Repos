import java.util.Scanner;

public class SumStep3 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int i;
        int sum1=0;
        int sum2=0;
        int sum3=0;
        int j;
        int x;
        int n = Integer.parseInt(sc.nextLine());
        for (i=1;i<=n;i++){
            x = Integer.parseInt(sc.nextLine());
            if (i==1||(i-1)%3==0)
                sum1 = sum1+x;
            else if(i==2||(i-2)%3==0)
                sum2 = sum2+x;
            else if(i%3==0)
                sum3 = sum3+x;
        }
        System.out.println(sum1);
        System.out.println(sum2);
        System.out.println(sum3);
    }
}
