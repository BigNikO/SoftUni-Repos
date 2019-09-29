import java.util.Scanner;

public class EqualSum {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] strNumbers  = scanner.nextLine().split(" ");
        int[] numbers = new int[strNumbers.length];
        for (int i = 0; i < numbers.length ; i++) {
            numbers[i] = Integer.parseInt(strNumbers[i]);
        }
        int leftSum = 0;
        int rightSum = 0;
        int index = -1;
        if (numbers.length==1){
            index=0;
        }
        for (int i = 1; i < numbers.length ; i++) {
            for (int j = numbers.length-1; j > i ; j--) {
                rightSum += numbers[j];
            }
            for (int j = 0; j < i ; j++) {
                leftSum += numbers[j];
           }

            if (leftSum==rightSum){
                index=i;
                break;
            }
            leftSum=0;
            rightSum=0;
        }
        if (index==-1) {
            System.out.println("no");
        }
        else {
            System.out.println(index);
        }
    }
}
