import java.util.Scanner;

public class D1Money {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double uanToEuro = (0.15*1.76)/1.95;
        double bitCoinToEuro = 1168/1.95;
        int bitCoin = Integer.parseInt(sc.nextLine());
        double uan = Double.parseDouble(sc.nextLine());
        double comision = Double.parseDouble(sc.nextLine())/100;
        double result = ((double)bitCoin*bitCoinToEuro + uan*uanToEuro);
        result = result - result*comision;
        System.out.printf("%.2f",result);
    }
}
