import java.util.Scanner;

public class A1GrapeAndRakia {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double area = Double.parseDouble(sc.nextLine());
        double kilos = Double.parseDouble(sc.nextLine());
        double waster = Double.parseDouble(sc.nextLine());
        kilos = area*kilos-waster;
        double rakia=(kilos*0.45)/7.5;
        double grape=(kilos*0.55);
        System.out.printf("%.2f%n",(rakia*9.8));
        System.out.printf("%.2f",(grape*1.5));
    }
}
