import java.util.Scanner;

public class MinNum {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        int p = Integer.parseInt(sc.nextLine());
        for (i=0;i<n-1;i++){
            int q = Integer.parseInt(sc.nextLine());
            if (p>q){
                p=q;
            }
        }
        System.out.println(p);
    }
}

