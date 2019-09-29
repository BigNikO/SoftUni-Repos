import java.util.Scanner;

public class ThePoint {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Double x1 = Double.parseDouble(sc.nextLine());
        Double y1 = Double.parseDouble(sc.nextLine());
        Double x2 = Double.parseDouble(sc.nextLine());
        Double y2 = Double.parseDouble(sc.nextLine());
        Double x = Double.parseDouble(sc.nextLine());
        Double y = Double.parseDouble(sc.nextLine());
        if (x>=x1 && x<=x2 && y>=y1 && y<=y2)
            System.out.println("Inside");
        else
            System.out.println("Outside");

    }
}
