import java.util.Scanner;

public class DatePlus5Days {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int day = Integer.parseInt(sc.nextLine());
        int month = Integer.parseInt(sc.nextLine());
        day = day + 5;
        if (month == 2 && day > 28) {
            day = day - 28;
            month++;
        }
        else if ((month==4 || month  == 6 || month == 9 || month == 11)&& day > 30) {
            day = day - 30;
            month++;
        }
        else if (day > 31) {
            day = day - 31;
            month++;
        }
        if (month<10)
            System.out.println(day+".0"+month);
        else if (month>12) {
            month=1;
            System.out.println(day + ".0" + month);
        }
        else System.out.println(day + "." + month);
    }
}
