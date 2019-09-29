import java.util.Scanner;

public class B6MagicNumber {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int magicNumber=Integer.parseInt(sc.nextLine());
        int i,j,k,l,m,n;
        for (i=1;i<=9;i++)
            for (j=1;j<=9;j++)
                for (k=1;k<=9;k++)
                    for (l=1;l<=9;l++)
                        for (m=1;m<=9;m++)
                            for (n=1;n<=9;n++)
                                if (i*j*k*l*m*n==magicNumber)
                                    System.out.printf("%d%d%d%d%d%d ",i,j,k,l,m,n);
    }
}
