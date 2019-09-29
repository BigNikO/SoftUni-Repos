import java.util.Scanner;

public class Cinema {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String p = sc.nextLine();
        int r = Integer.parseInt(sc.nextLine());
        int c = Integer.parseInt(sc.nextLine());
        if (p.equals("Premiere"))
            System.out.printf("%.2f",(double)r*c*12);
        else if (p.equals("Normal"))
            System.out.printf("%.2f",(double)r*c*7.5);
        else if (p.equals("Discount"))
        System.out.printf("%.2f",(double)r*c*5);
        else
            System.out.println("error");
    }
}
