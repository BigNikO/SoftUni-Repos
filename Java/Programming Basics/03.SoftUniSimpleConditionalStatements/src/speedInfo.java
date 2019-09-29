import java.util.Scanner;

public class speedInfo {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double s = Double.parseDouble(sc.nextLine());
        if (s<=10)
            System.out.println("slow");
        else if (s<=50)
            System.out.println("average");
        else if (s<=150)
            System.out.println("fast");
        else if (s<=1000)
            System.out.println("ultra fast");
        else
            System.out.println("extremely fast");
    }
}