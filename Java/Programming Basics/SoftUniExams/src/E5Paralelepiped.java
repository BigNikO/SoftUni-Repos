import java.util.Scanner;

public class A5Paralelepiped {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        System.out.println("+"+strRep("~",n-2)+"+"+strRep(".",2*n+1));
        for(int i=0;i<2*n+1;i++)
            System.out.println("|"+strRep(".",i)+"\\"+strRep("~",n-2)+"\\"+strRep(".",2*n-i));
        for(int i=0;i<2*n+1;i++)
            System.out.println(strRep(".",i)+"\\"+strRep(".",2*n-i)+"|"+strRep("~",n-2)+"|");
        System.out.println(strRep(".",2*n+1)+"+"+strRep("~",n-2)+"+");

    }
    static String strRep(String repStr, int count){
        String text = "";
        for (int i=1;i<=count;i++){
            text = text+repStr;
        }
        return text;
    }
}
