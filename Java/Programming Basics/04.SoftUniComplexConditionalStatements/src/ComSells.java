import java.util.Scanner;

public class ComSells {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        String c = sc.nextLine();
        Double v = Double.parseDouble(sc.nextLine());
        if (v<0)
            System.out.println("error");
        else {
            if (c.equals("Sofia")){
                if (v <= 500)
                    System.out.printf("%.2f",v*0.05);
                else if (v <= 1000)
                    System.out.printf("%.2f",v*0.07);
                else if (v <= 10000)
                    System.out.printf("%.2f",v*0.08);
                else
                    System.out.printf("%.2f",v*0.12);
            } else if (c.equals("Varna")){
                if (v <= 500)
                    System.out.printf("%.2f",v*0.045);
                else if (v <= 1000)
                    System.out.printf("%.2f",v*0.075);
                else if (v <= 10000)
                    System.out.printf("%.2f",v*0.1);
                else
                    System.out.printf("%.2f",v*0.13);
            } else if (c.equals("Plovdiv")){
                if (v <= 500)
                    System.out.printf("%.2f",v*0.055);
                else if (v <= 1000)
                    System.out.printf("%.2f",v*0.08);
                else if (v <= 10000)
                    System.out.printf("%.2f",v*0.12);
                else
                    System.out.printf("%.2f",v*0.145);
            } else
                System.out.println("error");
        }
    }
}
