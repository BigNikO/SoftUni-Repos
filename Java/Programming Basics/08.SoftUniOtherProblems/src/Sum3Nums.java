import java.util.Scanner;

public class Sum3Nums {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a = Integer.parseInt(sc.nextLine());
        int b = Integer.parseInt(sc.nextLine());
        int c = Integer.parseInt(sc.nextLine());
        if (a+b==c)
            if (a<=b)
                System.out.println(a+" + "+b+" = "+c);
            else
                System.out.println(b+" + "+a+" = "+c);
        else if (b+c==a)
            if (b<=c)
                System.out.println(b+" + "+c+" = "+a);
            else
                System.out.println(c+" + "+b+" = "+a);
        else if (a+c==b)
            if (a<=c)
                System.out.println(a+" + "+c+" = "+b);
            else
                System.out.println(c+" + "+a+" = "+b);
        else
            System.out.println("No");
    }
}
