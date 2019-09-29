import java.util.Scanner;

public class FigurePoint {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int h = Integer.parseInt(sc.nextLine());
        int x = Integer.parseInt(sc.nextLine());
        int y = Integer.parseInt(sc.nextLine());
        if (y==h && x>h && x<2*h)
            System.out.println("inside");
        else if (x>0&&x<3*h&&y>0&&y<h)
            System.out.println("inside");
        else if (x>h&&x<2*h&&y>h&&y<4*h)
            System.out.println("inside");
        else if ((x==0&&y<=h&&y>=0)||(x==3*h&&y<=h&&y>=0))
            System.out.println("border");
        else if ((y==0&&x<=3*h&&x>=0)||(y==h&&x<=3*h&&x>=0))
            System.out.println("border");
        else if ((x==h&&y>=h&&y<=4*h)||(x==2*h&&y>=h&&y<=4*h))
            System.out.println("border");
        else if ((y==4*h&&x<=2*h&&x>=h))
            System.out.println("border");
        else
            System.out.println("outside");
    }
}
