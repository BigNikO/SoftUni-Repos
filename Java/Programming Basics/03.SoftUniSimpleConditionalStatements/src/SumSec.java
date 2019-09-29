import java.util.Scanner;

public class SumSec {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int s1 = Integer.parseInt(sc.nextLine());
        int s2 = Integer.parseInt(sc.nextLine());
        int s3 = Integer.parseInt(sc.nextLine());
        int s = s1 + s2 + s3;
        if (s % 60 < 10) {
            System.out.println(s/60 + ":" + 0 + "" + s%60);
        }
        else{
            System.out.println(s/60+":"+s%60);
        }
    }
}
