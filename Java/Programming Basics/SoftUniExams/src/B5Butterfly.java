import java.util.Scanner;

public class B5Butterfly {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n=Integer.parseInt(sc.nextLine());
        for (int i=3;i<=n;i++)
            if (i%2==0)
                System.out.println(repStr("-",n-2)+"\\ /"+repStr("-",n-2));
            else
                System.out.println(repStr("*",n-2)+"\\ /"+repStr("*",n-2));
        System.out.println(repStr(" ",n-1)+"@"+repStr(" ",n-1));
        for (int i=3;i<=n;i++)
            if (i%2==0)
                System.out.println(repStr("-",n-2)+"/ \\"+repStr("-",n-2));
            else
                System.out.println(repStr("*",n-2)+"/ \\"+repStr("*",n-2));
    }
    static String repStr(String strRep,int count){
        String text="";
        for (int i=1;i<=count;i++){
            text=text+strRep;
        }
        return text;
    }
}
