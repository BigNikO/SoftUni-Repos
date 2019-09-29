import java.util.Scanner;

public class A3OnTimeForTheExam{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int examHour = Integer.parseInt(sc.next());
        int examMins = Integer.parseInt(sc.next());
        int studHour = Integer.parseInt(sc.next());
        int studMins = Integer.parseInt(sc.next());

        int examTime = 60*examHour+examMins;
        int studTime = 60*studHour+studMins;
        int minDiff = studTime-examTime;
        int hours= 0;
        int mins = 0;
        if (minDiff<-30)
            System.out.println("Early");
        else if (minDiff<=0)
            System.out.println("On time");
        else
            System.out.println("late");
        if (minDiff!=0){
            hours=Math.abs(minDiff)/60;
            mins=Math.abs(minDiff)%60;
            if (hours>0)
                if (mins<10)
                    System.out.print(hours + ":0" + mins + " hours");
                else
                    System.out.print(hours+ ":" + mins +" hours");
            else
                System.out.print(mins +" minutes");
            if (minDiff<0)
                System.out.print(" before the start");
            else
                System.out.print(" after the start");
        }
    }
}
