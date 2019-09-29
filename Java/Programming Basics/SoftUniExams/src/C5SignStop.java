import java.util.Scanner;

public class C5SignStop {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n=Integer.parseInt(sc.nextLine());
        System.out.println(strRep(".",(n+1))+strRep("_",2*n+1)+strRep(".",(n+1)));
        for (int i=0;i<=n;i++){
            if (i==n)
                System.out.println(strRep(".",n-i)+"//"+strRep("_",(2*n-1+2*i)/2-2)+"STOP!"
                        +strRep("_",(2*n-1+2*i)/2-2)+"\\\\" +strRep(".",n-i));
            else System.out.println(strRep(".",n-i)+"//"+strRep("_",2*n-1+2*i)+"\\\\"
                    +strRep(".",n-i));
        }
        for (int j=n;j>=1;j--){
            System.out.println(strRep(".",n-j)+"\\\\"+strRep("_",2*n-1+2*j)+"//"
                    +strRep(".",n-j));
        }
    }
    static String strRep(String repStr,int count){
        String text="";
        for (int i=1;i<=count;i++){
            text=text+repStr;
        }
        return text;
    }
}
