import java.util.Scanner;
public class Rect {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int a = Integer.parseInt(console.nextLine());
        int b = Integer.parseInt(console.nextLine());

        System.out.println("The surface is " + a*b);
    }
}

