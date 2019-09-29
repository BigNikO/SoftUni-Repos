import java.util.Scanner;

public class GenerateRectangles {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int side = Integer.parseInt(sc.nextLine());
        int area = Integer.parseInt(sc.nextLine());
        if (side*side*4<area)
            System.out.println("No");
        else
            for (int i = -side; i<= side-1; i++)
                for(int j = -side; j<= side-1; j++)
                    for (int k =side;k >= - side+1;k--)
                        for (int l = side; l>= -side+1;l--){
                            if(i>=k||j>=l)
                                break;
                            int area1 = (k-i)*(l-j);
                            if (area1>=area) {
                                System.out.printf("(%d, %d) (%d, %d) -> %d", i, j, k, l, area1);
                                System.out.println();
                            }
                }
    }
}
