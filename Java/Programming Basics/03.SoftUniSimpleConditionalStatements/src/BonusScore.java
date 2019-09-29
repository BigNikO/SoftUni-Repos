import java.util.Scanner;

public class BonusScore {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in );
        double score = Double.parseDouble(sc.nextLine());
        double score1 =0;
        if (score<=100) {
            score1=5;
        }else if (score <= 1000) {
            score1 = score/5;
        }else if (score>1000) {
            score1 = score/10;
        }
        if (score % 2 ==0){
            score1 = score1 + 1;
        }else if (score % 5 == 0){
            score1 =  score1 + 2;
        }
        System.out.println(score1);
        System.out.println(score+score1);
    }
}
