import java.util.Scanner;

public class OddEvenPoss {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int i;
        double neu = 1000000000.0;
        double oddMin = neu;
        double oddMax = -neu;
        double oddSum = 0.0;
        double evMin = neu;
        double evMax = -neu;
        double evSum = 0.0;
        for (i=0;i<=n-1;i++){
            double var = Double.parseDouble(sc.nextLine());
            if (i%2==0){
                oddSum = oddSum+var;
                if (oddMax<var)
                    oddMax=var;
                if (oddMin>var)
                    oddMin=var;
            } else {
                evSum = evSum+var;
                if (evMax<var)
                    evMax=var;
                if (evMin>var)
                    evMin=var;
            }
        }
        if (n<2&&n>0){
            System.out.println((oddSum*10)%10==0 ? "OddSum = " + (int)oddSum : "OddSum = " + oddSum);
            System.out.println((oddMin*10)%10==0 ? "OddMin = " + (int)oddMin : "OddMin = " + oddMin);
            System.out.println((oddMax*10)%10==0 ? "OddMax = " + (int)oddMax : "OddMax = " + oddMax);
            System.out.println((evSum*10)%10==0 ? "EvenSum = " + (int)evSum : "EvenSum = " + evSum);
            System.out.println("EvenMin=No");
            System.out.println("EvenMax=No");
        } else if (n>=2){
            System.out.println((oddSum*10)%10==0 ? "OddSum = " + (int)oddSum : "OddSum = " + oddSum);
            System.out.println((oddMin*10)%10==0 ? "OddMin = " + (int)oddMin : "OddMin = " + oddMin);
            System.out.println((oddMax*10)%10==0 ? "OddMax = " + (int)oddMax : "OddMax = " + oddMax);
            System.out.println((evSum*10)%10==0 ? "EvenSum = " + (int)evSum : "EvenSum = " + evSum);
            System.out.println((evMin*10)%10==0 ? "EvenMin = " + (int)evMin : "EvenMin = " + evMin);
            System.out.println((evMax*10)%10==0 ? "EvenMax = " + (int)evMax : "EvenMax = " + evMax);
        } else if (n==0){
            System.out.println((oddSum*10)%10==0 ? "OddSum = " + (int)oddSum : "OddSum = " + oddSum);
            System.out.println("OddMin=No");
            System.out.println("OddMax=No");
            System.out.println((evSum*10)%10==0 ? "EvenSum = " + (int)evSum : "EvenSum = " + evSum);
            System.out.println("EvenMin=No");
            System.out.println("EvenMax=No");
        }
    }
}

