import java.util.Scanner;

public class IncreasingElements {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        int num;
        int previousNum=0;
        if (n>0) {
            num = Integer.parseInt(sc.nextLine());
            previousNum = num;
        }
        int shorterRow = 0;
        int longestRow = 1;
        int previousRow = 0;
        for (i=2;i<=n;i++){
            num = Integer.parseInt(sc.nextLine());
            if (num>previousNum)
                longestRow++;
            else if(longestRow>previousRow){
                previousRow = longestRow;
                longestRow = 1;
            } else
                longestRow = 1;
            previousNum=num;
        }
        if (previousRow>longestRow)
            longestRow=previousRow;
        System.out.println(longestRow);
    }
}
