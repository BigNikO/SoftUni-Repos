import java.util.Scanner;

public class A2Styrofoam {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double budget = Double.parseDouble(sc.nextLine());
        double area = Double.parseDouble(sc.nextLine());
        int windows = Integer.parseInt(sc.nextLine());
        double stPack = Double.parseDouble(sc.nextLine());
        double stPrize = Double.parseDouble(sc.nextLine());
        area = area - (double)windows*2.4;
        area = area + area*10/100;
        double spent = Math.ceil(area/stPack)*stPrize;
        if (budget<spent)
            System.out.printf("Need more: %.2f",(spent-budget));
        else
            System.out.printf("Spent: %.2f%nLeft: %.2f",spent,(budget-spent));
    }
}
