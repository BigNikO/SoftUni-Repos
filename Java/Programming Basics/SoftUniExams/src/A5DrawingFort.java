import java.util.Scanner;

public class A5DrawingFort {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        System.out.println("/"+repeatStr("^",n/2)+"\\"+repeatStr("_",2*n-4-n/2-n/2)+"/"
                +repeatStr("^",n/2)+"\\");
        for (int i=1;i<=n-3;i++)
            System.out.println("|"+repeatStr(" ",2*n-2)+"|");
        System.out.println("|"+repeatStr(" ",n/2)+" "+repeatStr("_",2*n-4-n/2-n/2)+" "
                +repeatStr(" ",n/2)+"|");
        System.out.println("\\"+repeatStr("_",n/2)+"/"+repeatStr(" ",2*n-4-n/2-n/2)+"\\"
                +repeatStr("_",n/2)+"/");
    }
    static  String repeatStr(String strToRepeat, int count){
        String text="";
        for (int i = 1; i<=count;i++){
            text=text+strToRepeat;
        }
        return text;
    }
}
