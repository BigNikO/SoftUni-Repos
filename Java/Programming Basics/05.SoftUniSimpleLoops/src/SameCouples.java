import java.util.Scanner;

public class SameCouples {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int i;
        int n = Integer.parseInt(sc.nextLine());
        int var1 = Integer.parseInt(sc.nextLine());
        int var2 = Integer.parseInt(sc.nextLine());
        int s=var1+var2;
        int diff = 0;
        int diff1 = 0;
        for (i=3;i<2*n;i=i+2){
            var1 = Integer.parseInt(sc.nextLine());
            var2 = Integer.parseInt(sc.nextLine());
            if (s!=var1+var2){
                diff=Math.abs(s-(var1+var2));
                s=var1+var2;
                if (diff1<diff)
                    diff1=diff;
            }
        }
        if (diff1!=0)
            System.out.println("No, maxdiff="+diff1);
        else
            System.out.println("Yes, value="+s);
    }
}
