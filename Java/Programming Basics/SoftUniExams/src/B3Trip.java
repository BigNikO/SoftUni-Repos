import java.util.Scanner;

public class B3Trip {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double budget = Double.parseDouble(sc.nextLine());
        String season = sc.nextLine();
        String destination;
        String place="Camp";
        double p;
        if (season.equals("winter"))
            place="Hotel";
        if (budget<=100&&season.equals("summer")){
            destination = "Bulgaria";
            budget=budget*3/10;
        }else if (budget<=100){
            destination = "Bulgaria";
            budget=budget*7/10;
        }else if (budget<=1000&&season.equals("summer")){
            destination = "Balkans";
            budget=budget*4/10;
        }else if (budget<=1000){
            destination = "Balkans";
            budget=budget*8/10;
        }else{
            destination = "Europe";
            budget=budget*9/10;
            place = "Hotel";
        }
        System.out.printf("Somewhere in %s%n%s - %.2f",destination,place,budget);
    }
}
