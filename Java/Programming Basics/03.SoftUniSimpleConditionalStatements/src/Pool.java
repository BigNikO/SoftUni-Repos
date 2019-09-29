import java.util.Scanner;

public class Pool {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a;
        int b;
        int c;
        int v = Integer.parseInt(sc.nextLine());
        int p1 = Integer.parseInt(sc.nextLine());
        int p2 = Integer.parseInt(sc.nextLine());
        double h = Double.parseDouble(sc.nextLine());
        if ((p1*h+p2*h)<= v){
            c = (int)((((p1*h+p2*h)/v)*100));
            a = (int)(((p1*h)/(p1*h+p2*h))*100);
            b = (int)(((p2*h)/(p1*h+p2*h))*100);
            System.out.println("The pool is " + c + "% full. ");
            System.out.print("Pipe 1: "+a+"%. "+"Pipe 2: "+b+"%.");
        }
        else
            System.out.println("For " + h + " hours the pool overflows with " + (p1*h+p2*h-v)+" liters.");
    }
}
