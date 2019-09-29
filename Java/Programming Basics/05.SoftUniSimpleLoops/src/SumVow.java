import java.util.Scanner;

public class SumVow {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String word = sc.nextLine();
        int i;
        int sum = 0;
        for (i=1;i<word.length();i++){
            switch (word.charAt(i)){
                case 'a' : sum+=1; break;
                case 'e' : sum+=2; break;
                case 'i' : sum+=3; break;
                case 'o' : sum+=4; break;
                case 'u' : sum+=5; break;
            }
        }
        System.out.println("Vowels sum = " + sum);
    }
}
