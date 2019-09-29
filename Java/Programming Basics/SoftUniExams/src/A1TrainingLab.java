import java.util.Scanner;

public class A1TrainingLab {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        double w = Double.parseDouble(sc.nextLine());
        double h = Double.parseDouble(sc.nextLine());
        double rows = Math.floor(w/1.2);
        System.out.println(rows);
        double colloms = Math.floor((h-1)/0.7);
        double p = rows*colloms -3;
        System.out.println(p);
    }
}