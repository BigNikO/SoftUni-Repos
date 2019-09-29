import java.util.Scanner;

public class MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] numbersStr = scanner.nextLine().split(" ");
        int[] numbers  = new int[numbersStr.length];
        for (int i = 0; i <numbers.length ; i++) {
            numbers[i] = Integer.parseInt(numbersStr[i]);
        }
        int counter = 1;
        int bestCounter = counter;
        int number = numbers[0];
        for (int i = 0; i < numbers.length-1; i++) {
            for (int j = i+1; j < numbers.length; j++) {
                if (numbers[i]==numbers[j]){
                    counter++;
                }
            }
            if (counter>bestCounter){
                bestCounter=counter;
                number=numbers[i];
            }
            counter=1;
        }
        System.out.println(number);
    }
}
