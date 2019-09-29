import java.util.Scanner;

public class D5Diamond {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        System.out.println(strRep(".",n)+strRep("*",3*n)+strRep(".",n));
        for (int i=1;i<n;i++)
            System.out.println(strRep(".",n-i)+"*"+strRep(".",3*n+2*i-2)+"*"+strRep(".",n-i));
        System.out.println(strRep("*",5*n));
        for (int i=1;i<=2*n;i++)
            System.out.println(strRep(".",i)+"*"+strRep(".",5*n-2*i-2)+"*"+strRep(".",i));
        System.out.println(strRep(".",2*n+1)+strRep("*",n-2)+strRep(".",2*n+1));

    }

    static String strRep(String repStr, int count){
        String text="";
        for (int i=1;i<=count;i++){
            text = text + repStr;
        }
        return  text;
    }
}
