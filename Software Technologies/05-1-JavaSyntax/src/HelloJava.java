import java.util.Scanner;

public class HelloJava {
    public static void main(String[] args) {
        System.out.println("Hello Java!");
        System.out.print("Hello Java!");
        System.out.println();
        System.out.printf("Hello Java!");
        int a = 5;
        double grade = 6;
        float c = 5;
        String name = "Nikola";
        System.out.println();
        System.out.printf("%.0f%n", a+grade+c);
        System.out.printf("%s", name);
        System.out.println();
        Scanner  scanner =  new Scanner(System.in);
        double number1 = Double.parseDouble(scanner.nextLine());
        double number2 = Double.parseDouble(scanner.nextLine());
        double sum = number1+number2;
        System.out.printf("%.2f%n",sum);

    }
}
