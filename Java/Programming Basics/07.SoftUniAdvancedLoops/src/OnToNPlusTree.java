import java.util.Scanner;

public class OnToNPlusTree {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        for (i=1;i<=n;i+=3)
            System.out.println(i);
    }
}
