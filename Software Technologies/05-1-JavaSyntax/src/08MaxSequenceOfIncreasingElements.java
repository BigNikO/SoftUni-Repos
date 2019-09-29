import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfIncreasingElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] sequence = scanner.nextLine().split(" ");
        int currentLen = 1;
        int bestLen = currentLen;
        int start = 0;
        int bestStart = start;
        for (int i = 0; i < sequence.length-1 ; i++) {
            if (Integer.parseInt(sequence[i])<Integer.parseInt(sequence[i+1])){
               currentLen++;
            } else {
                currentLen = 1;
                start = i+1;
            }
            if (currentLen>bestLen){
                bestLen=currentLen;
                bestStart=start;
            }
        }
        System.out.println(String.join(" ", Arrays.copyOfRange(sequence, bestStart, bestStart+bestLen)));
    }
}
