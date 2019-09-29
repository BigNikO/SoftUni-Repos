import java.util.Scanner;

public class A3TruckDriver {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double sallary=0;
        String season = sc.nextLine();
        double km = Double.parseDouble(sc.nextLine());
        if (km>10000)
            sallary = km*1.45;
        else if (km>5000)
            if (season.equals("Winter"))
                sallary = km*1.25;
            else if (season.equals("Summer"))
                sallary = km*1.10;
            else
                sallary = km*0.95;
        else
            if (season.equals("Winter"))
                sallary = km*1.05;
            else if (season.equals("Summer"))
                sallary = km*0.90;
            else
                sallary = km*0.75;
        sallary = sallary*4;
        sallary = sallary-sallary*10/100;
        System.out.printf("%.2f",sallary);
    }
}
