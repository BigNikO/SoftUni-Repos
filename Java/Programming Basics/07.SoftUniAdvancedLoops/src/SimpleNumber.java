import java.util.Scanner;
import static java.lang.StrictMath.sqrt;
public class SimpleNumber {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i=1;
        int h=1;
        while   (i<sqrt(n)){
            i++;
            if (n%i==0) {
                h = 0;
                break;
            }
        }
        if (((h==0)||(n<2))&&(n!=2))
            System.out.println("Not Prime");
        else System.out.println("Prime");
    }
}


