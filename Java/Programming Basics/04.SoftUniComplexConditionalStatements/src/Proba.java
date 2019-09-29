import java.util.Scanner;

public class Proba {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int examHours = Integer.parseInt(scan.nextLine());
        int examMinutes = Integer.parseInt(scan.nextLine());
        int studentHours = Integer.parseInt(scan.nextLine());
        int studentMinutes = Integer.parseInt(scan.nextLine());

        int examTime = examHours * 60 + examMinutes;
        int studentTime = studentHours * 60 + studentMinutes;
        int minutesDifference = studentTime - examTime;
        int hours = 0;
        int minutes = 0;

        if (minutesDifference < -30)
            System.out.println("Early");
        else if (minutesDifference <= 0)
            System.out.println("On time");
        else
            System.out.println("Late");

        if (minutesDifference != 0) {
            hours = Math.abs(minutesDifference / 60);
            minutes = Math.abs(minutesDifference % 60);
            if (hours > 0) {
                if (minutes < 10)
                    System.out.print(hours + ":0" + minutes + " hours");
                else
                    System.out.print(hours + ":" + minutes + " hours");
            } else
                System.out.print(minutes + " minutes");
            if (minutesDifference < 0)
                System.out.print(" before the start");
            else
                System.out.print(" after the start");
        }
    }
}

