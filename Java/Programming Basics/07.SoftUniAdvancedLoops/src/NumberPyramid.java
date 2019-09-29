import java.util.Scanner;

public class NumberPyramid {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int br = 1;
        int n = Integer.parseInt(sc.nextLine());
        for (int i = 1; i<=n;i++){
            for (int j=1; j<=i; j++){
                System.out.print(br+" ");
                br = br+1;
                if (br==n+1)
                    break;
            }
            System.out.println();
            if (br==n+1)
                break;
        }
    }
}
