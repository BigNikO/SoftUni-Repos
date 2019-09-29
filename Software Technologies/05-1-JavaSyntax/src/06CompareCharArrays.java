import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] firstArr = scanner.nextLine().split(" ");
        String[] secondArr = scanner.nextLine().split(" ");
        String[] shorterArr = firstArr;
        String[] longerArr = secondArr;
        if (firstArr.length > secondArr.length){
            shorterArr=secondArr;
            longerArr=firstArr;
        }
        for (int i = 0; i < shorterArr.length; i++){
            if (longerArr[i].charAt(0) < shorterArr[i].charAt(0)){
                System.out.println(String.join("", longerArr));
                System.out.println(String.join("", shorterArr));
                return;
            } else if (longerArr[i].charAt(0) > shorterArr[i].charAt(0)){
                System.out.println(String.join("", shorterArr));
                System.out.println(String.join("", longerArr));
                return;
            }
        }
        System.out.println(String.join("", shorterArr));
        System.out.println(String.join("", longerArr));
    }
}
