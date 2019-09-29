import java.util.Scanner;

public class C6SpecialNumbers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int sN=Integer.parseInt(sc.nextLine());
        int i,j,k,l;
        for (i=1;i<=9;i++)
            for (j=1;j<=9;j++)
                for (k=1;k<=9;k++)
                    for (l=1;l<=9;l++)
                        if (sN%i==0&&sN%j==0&&sN%k==0&&sN%l==0)
                            System.out.print(i+""+j+""+k+""+l+" ");



    }
}
