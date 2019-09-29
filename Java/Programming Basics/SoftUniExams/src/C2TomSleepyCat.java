import java.util.Scanner;

public class C2TomSleepyCat {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int restDays = Integer.parseInt(sc.nextLine());
        int workDays = 365-restDays;
        int gameTime = restDays*127+workDays*63;
        int difference = 30000-gameTime;
        int hours=Math.abs(difference)/60;
        int minutes=Math.abs(difference)%60;
        if  (difference<0){
            difference=Math.abs(difference);
            System.out.printf("Tom will run away%n%d hours and %d minutes more for play",hours,minutes);
        } else
            System.out.printf("Tom sleeps well%n%d hours and %d minutes less for play",hours,minutes);

    }
}

