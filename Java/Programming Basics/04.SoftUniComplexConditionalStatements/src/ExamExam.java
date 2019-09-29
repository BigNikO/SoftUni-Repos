import java.util.Scanner;

public class ExamExam {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a = Integer.parseInt(sc.nextLine());
        int b = Integer.parseInt(sc.nextLine());
        int c = Integer.parseInt(sc.nextLine());
        int d = Integer.parseInt(sc.nextLine());
        int p = 60-b+d;
        int q = 60-d+b;
        int x;
        if (a-1<0&&c==23)
            x=23;
        else
            x=a-1;
        System.out.println(x);
        if (a>=0&&a<=23&&b>=0&&b<=59&&c>=0&&c<=23&&d>=0&&d<=59) {
            if ((a < c && c !=x ) || (a == c && b < d)) {
                System.out.println("Late");
                if (a < c && p >= 60 && (p - 60) < 10)
                    System.out.println((c - a) + ":0" + (p - 60) + " hours after the start");
                else if (a < c && p > 60)
                    System.out.println((c - a) + ":" + (p - 60) + " hours after the start");
                else if (a < c)
                    System.out.println(p + " minutes after the start");
                else
                    System.out.println((d - b) + " minutes after the start");
            } else if ((a == c && b >= d && (b - d) <= 30) || ((x == c) && (60 - d + b) <= 30)) {
                System.out.println("On time");
                if (a != c && q >= 60 && (q - 60) < 10)
                    System.out.println((a - c) + ":0" + (q - 60) + " hours before the start");
                else if (a != c && q > 60)
                    System.out.println((a - c) + ":" + (q - 60) + " hours before the start");
                else if (c != a)
                    System.out.println(q + " minutes before the start");
                else if (b != d)
                    System.out.println((b - d) + " minutes before the start");
            } else {
                System.out.println("Early");
                if (a != c && q >= 60 && (q - 60) < 10)
                    System.out.println((a - c) + ":0" + (q - 60) + " hours before the start");
                else if (a != c && q > 60)
                    System.out.println((a - c) + ":" + (q - 60) + " hours before the start");
                else if (c != a)
                    System.out.println(q + " minutes before the start");
                else
                    System.out.println((b - d) + " minutes before the start");
            }
        }

    }
}
