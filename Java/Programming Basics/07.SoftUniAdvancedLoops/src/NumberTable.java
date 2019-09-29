import java.util.Scanner;

public class NumberTable {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int br = 1;
        int n = Integer.parseInt(sc.nextLine());
        int  p = n+1;
        int num=0;
        for (int row = 0; row<n;row++){
            for (int cow=0; cow<n; cow++){
                num = row+cow+1;
                if (num>n){
                    num=2*n-num;
                }
                System.out.print(num+ " ");
            }
            System.out.println();
        }
    }
}
