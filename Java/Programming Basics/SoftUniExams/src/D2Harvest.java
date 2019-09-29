import java.util.Scanner;

public class D2Harvest {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int area = Integer.parseInt(sc.nextLine());
        double grape = Double.parseDouble(sc.nextLine())*((double)area*40/100);
        double needWine = Double.parseDouble(sc.nextLine());
        int workers = Integer.parseInt(sc.nextLine());
        double wine = grape/2.5;
        int result = (int)(Math.floor(Math.abs(needWine-wine)));
        int bigResult = (int)(Math.ceil(Math.abs(needWine-wine)));
        if (needWine>wine)
            System.out.printf("It will be a tough winter! More %d liters wine needed.",result);
        else{
            System.out.printf("Good harvest this year! Total wine: %d liters.%n",(int)wine);
            int forWorkers = (int)(Math.ceil((Math.abs(needWine-wine)/workers)));
            System.out.printf("%d liters left -> %d liters per person.",bigResult,forWorkers);
        }

    }
}
