import java.util.Scanner;

public class A6StupidPass {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int letters = Integer.parseInt(sc.nextLine());
        char a = 'a';
        char k,l;
        int i,j,m;
        char b='a'-1;
        for (int letter = 1; letter<=letters;letter++)
            b++;
        for (i=1;i<=n;i++)
            for(j=1;j<=n;j++)
                for (k=a;k<=b;k++)
                    for (l=a;l<=b;l++)
                        for (m=i+1;m<=n;m++)
                            if (m>j)
                                System.out.printf("%d%d%c%c%d ",i,j,k,l,m);
    }
}
