
public class TenStarsRect {
    public static void main(String[] args) {
        int i;
        // Решение №1
        for (i=1;i<=10;i++) {
            System.out.println("**********");
        }
        System.out.println();
        // Решение №2
        for (i=1;i<=10;i++) {
            for (int j=1;j<=10;j++){
                System.out.print("*");
            }
            System.out.println();
        }
    }
}
