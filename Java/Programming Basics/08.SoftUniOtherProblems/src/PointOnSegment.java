import java.util.Scanner;

public class PointOnSegment {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int first = Integer.parseInt(sc.nextLine());
        int second = Integer.parseInt(sc.nextLine());
        int point = Integer.parseInt(sc.nextLine());
        int difference = Math.abs(first-point);
        if (difference>Math.abs(second-point))
            difference=Math.abs(second-point);
        if (first>second){
            int previous = first;
            first = second;
            second=previous;
        }
        if (point>=first&&point<=second)
            System.out.println("in");
        else
            System.out.println("out");
        System.out.println(difference);
    }
}
