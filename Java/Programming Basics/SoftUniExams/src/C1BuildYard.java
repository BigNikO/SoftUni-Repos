import java.util.Scanner;

public class C1BuildYard {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        int n=Integer.parseInt(sc.nextLine());
        double w=Double.parseDouble(sc.nextLine());
        double l=Double.parseDouble(sc.nextLine());
        int m=Integer.parseInt(sc.nextLine());
        int o=Integer.parseInt(sc.nextLine());
        double Area = ((double)n*(double)n-(double)m*(double)o);
        double result = Area/(l*w);
        double time=result*0.2;
        System.out.printf("%.2f%n%.2f",result,time);
    }
}
