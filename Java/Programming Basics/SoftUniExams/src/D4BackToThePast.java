import java.util.Scanner;

public class D4BackToThePast {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double inheritedMoney = Double.parseDouble(sc.nextLine());
        int yearToLive = Integer.parseInt(sc.nextLine());
        double needMoney = 0;
        int i;
        for (i=0;i<=yearToLive-1800;i++)
            if  (i%2==0)
                needMoney += 12000;
            else
                needMoney = needMoney + 12000 + (18+i) * 50;
        if (needMoney>inheritedMoney)
            System.out.printf("He will need %.2f dollars to survive.",(needMoney-inheritedMoney));
        else
            System.out.printf("Yes! He will live a carefree life and will have %.2f dollars left.",(Math.abs(needMoney-inheritedMoney)));


    }
}
