import java.util.Scanner;

public class CircleOpratations {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double r = Double.parseDouble(sc.nextLine());
        double perimeter = Math.PI*2*r;
        double area = Math.PI*r*r;
        System.out.print("Area = " + area +"\n");
        System.out.println("Perimeter = " +perimeter);
    }
}
