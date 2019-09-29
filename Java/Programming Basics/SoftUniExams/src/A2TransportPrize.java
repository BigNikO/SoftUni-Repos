import java.util.Scanner;

public class A2TransportPrize {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        Double n = Double.parseDouble(sc.nextLine());
        String d = sc.nextLine();
        if (n>=100)
            n=n*0.06;
        else if (n>=20)
            n=n*0.09;
        else
        {if (d.equals("night"))
            n=n*0.9+0.7;
        else
            n=n*0.79+0.7;
        }
        System.out.println(n);
    }
}