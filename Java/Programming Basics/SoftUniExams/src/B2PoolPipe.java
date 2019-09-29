import java.util.Scanner;

public class B2PoolPipe {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int v = Integer.parseInt(sc.nextLine());
        int p1 = Integer.parseInt(sc.nextLine());
        int p2 = Integer.parseInt(sc.nextLine());
        double h = Double.parseDouble(sc.nextLine());
        double l = p1*h+p2*h;
        double p=l*10;
        double q=h*10;
        int x = (int)(l*100/v);
        int y = (int)(p1*h*100/l);
        int z = (int)(p2*h*100/l);
        if (l<=v)
            System.out.println("The pool is " + x +"% full. Pipe 1: "+y+"%. Pipe 2: "+z+"%." );
        else{
            if (q%10==0)
                System.out.println("For " +(int)h +" hours the pool overflows with "+ (l-v) +" liters.");
            else
                System.out.println("For " +h +" hours the pool overflows with "+ (l-v) +" liters.");
        }
    }
}
