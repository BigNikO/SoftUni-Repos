import java.util.Scanner;

public class Bricks {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int bricks = Integer.parseInt(sc.nextLine());
        int workers = Integer.parseInt(sc.nextLine());
        int x = Integer.parseInt(sc.nextLine());
        double courses = Math.ceil((double)bricks/((double)workers*(double)x));
        System.out.println(courses);
    }
}

