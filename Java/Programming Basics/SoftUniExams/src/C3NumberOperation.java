import java.util.Scanner;

public class C3NumberOperation {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num1 = Integer.parseInt(sc.nextLine());
        int num2 = Integer.parseInt(sc.nextLine());
        String operator = sc.nextLine();
        if (operator.equals("+")) {
            if ((num1 + num2) % 2 == 0)
                System.out.println(num1 + " + " + num2 + " = " + (num1 + num2) + " - even");
            else
                System.out.println(num1 + " + " + num2 + " = " + (num1 + num2) + " - odd");
        } else if (operator.equals("*")) {
            if ((num1 * num2) % 2 == 0)
                System.out.println(num1 + " * " + num2 + " = " + (num1 * num2) + " - even");
            else
                System.out.println(num1 + " * " + num2 + " = " + (num1 * num2) + " - odd");

        }else if (operator.equals("-")) {
            if ((num1 - num2) % 2 == 0)
                System.out.println(num1 + " - " + num2 + " = " + (num1 - num2) + " - even");
            else
                System.out.println(num1 + " - " + num2 + " = " + (num1 - num2) + " - odd");

        }else if (operator.equals("/")) {
            if (num2 == 0)
                System.out.println("Cannot divide " + num1 + " by zero");
            else
                System.out.printf("%d / %d = %.2f",num1,num2,(double)((double)num1/(double)num2));

        }else if (operator.equals("%")) {
            if (num2 == 0)
                System.out.println("Cannot divide " + num1 + " by zero");
            else
                System.out.println(num1+" % "+num2+" = "+ (num1%num2));

        }
    }
}