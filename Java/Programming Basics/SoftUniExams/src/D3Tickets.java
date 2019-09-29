import java.util.Scanner;

public class D3Tickets {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double money = Double.parseDouble(sc.nextLine());
        String category = sc.nextLine();
        int group = Integer.parseInt(sc.nextLine());
        double transport = money/100;
        double needMoney;
        double result;
        if (category.equals("VIP"))
            needMoney = 499.99*group;
        else
            needMoney = 249.99*group;
        if (group<=4)
            transport = transport*75;
        else if (group<10)
            transport = transport*60;
        else if (group<25)
            transport = transport*50;
        else if (group<50)
            transport = transport*40;
        else
            transport = transport*25;
        needMoney=needMoney+transport;
        result = money-needMoney;
        if (result>=0)
        System.out.printf("Yes! You have %.2f leva left.",result);
        else{
            result=Math.abs(result);
            System.out.printf("Not enough money! You need %.2f leva.",result);
        }

    }
}
