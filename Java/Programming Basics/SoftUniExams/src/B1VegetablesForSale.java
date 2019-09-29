import java.util.Scanner;

public class B1VegetablesForSale {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double priceVeg = Double.parseDouble(sc.nextLine());
        double priceFruit = Double.parseDouble(sc.nextLine());
        int vegKilo=Integer.parseInt(sc.nextLine());
        int fruitKilo=Integer.parseInt(sc.nextLine());
        System.out.printf("%f", (priceVeg*vegKilo + priceFruit*fruitKilo)/1.94);
    }
}
