import java.util.Scanner;

public class A4ProblemBills {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        double electricity = 0;
        double water = 20.00;
        double internet = 15.00;
        double others =0;
        for (int i = 1; i<=n; i++){
            double electricity1 = Double.parseDouble(sc.nextLine());
            double other1 = electricity1+water+internet;
            others = others+other1+other1*20/100;
            electricity=electricity+electricity1;
        }
        water = water*(double)n;
        internet=internet*(double)n;
        double average = (water+electricity+internet+others)/(double)n;
        System.out.printf("Electricity: %.2f lv%n",electricity);
        System.out.printf("Water: %.2f lv%n",water);
        System.out.printf("Internet: %.2f lv%n",internet);
        System.out.printf("Other: %.2f lv%n",others);
        System.out.printf("Average: %.2f lv%n",average);
    }
}
