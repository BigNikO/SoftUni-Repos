import java.util.Scanner;

public class PointOnFigure {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int x = Integer.parseInt(sc.nextLine());
        int y = Integer.parseInt(sc.nextLine());
        if (x>=4&&x<=10&&y<=3&&y>=-5)
            System.out.println("in");
        else if (x>=2&&x<=12&&y<=1&&y>=-3)
            System.out.println("in");
        else
            System.out.println("out");
    }
}
