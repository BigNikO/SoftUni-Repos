import java.util.Scanner;

public class C4SmartLily {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int even=0;
        int n=Integer.parseInt(sc.nextLine());
        double wmPrize=Double.parseDouble(sc.nextLine());
        int toyPrize=Integer.parseInt(sc.nextLine());
        int i;
        double sum=0.0;
        for (i=1;i<=n;i++){
            if (i%2==0) {
                even++;
                sum=sum-1+even*10;
            }
            else
                sum=sum+toyPrize;
        }
        sum=sum-wmPrize;
        if (sum>=0)
            System.out.printf("Yes! %.2f",sum);
        else{
            sum=Math.abs(sum);
            System.out.printf("No! %.2f",sum);
        }
    }
}
