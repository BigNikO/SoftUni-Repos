import java.util.Scanner;

public class IncreasingFourNumbers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num1 = Integer.parseInt(sc.nextLine());
        int num2 = Integer.parseInt(sc.nextLine());
        int i, j, k, l;
        if (num2-num1<3)
            System.out.println("No");
        else
            for (i = num1; i <= num2 - 3; i++)
                for (j = i+1; j <= num2 - 2; j++)
                    for (k = j+1; k <= num2 - 1; k++)
                        for (l = k+1; l <= num2; l++) {
                            System.out.printf("%d %d %d %d", i, j, k, l);
                            System.out.println();
                        }
    }
}
