import java.util.Scanner;

public class TimePlus {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        int h = Integer.parseInt(sc.nextLine());
        int m = Integer.parseInt(sc.nextLine());
        m=m+15;
        if ((h>=0 && h<=23)){
            if (m<60 && m>=10)
                System.out.println(h+":"+m);
            else if (m<60)
                System.out.println(h+":0"+m);
            else if (((m-60)<10)&&h<23)
                System.out.println((h+1)+":0"+(m-60));
            else if (h<23)
                System.out.println((h+1)+":"+(m-60));
            else if ((m-60)<10)
                System.out.println("0"+":0"+(m-60));
            else System.out.println("0"+":"+(m-60));

        }
    }
}
