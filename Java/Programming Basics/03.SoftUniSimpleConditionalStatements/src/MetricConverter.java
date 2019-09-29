import java.util.Scanner;

public class MetricConverter {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double met = Double.parseDouble(sc.nextLine());
        String met1 = sc.nextLine();
        String met2 = sc.nextLine();
        double result;
        //mm - 1
        if (met1.equals("mm") && met2.equals("m"))
            met = met / 1000;
        if (met1.equals("mm") && met2.equals("cm"))
            met = met / 10;
        if (met1.equals("mm") && met2.equals("mi"))
            met = met * 0.000621371192/1000;
        if (met1.equals("mm") && met2.equals("in"))
            met = met * 39.3700787/1000;
        if (met1.equals("mm") && met2.equals("km"))
            met = met * 0.001 / 1000;
        if (met1.equals("mm") && met2.equals("ft"))
            met = met * 3.2808399 / 1000;
        if (met1.equals("mm") && met2.equals("yd"))
            met = met * 1.0936133 / 1000;
        //cm - 2
        if (met1.equals("cm") && met2.equals("m"))
            met = met / 100;
        if (met1.equals("cm") && met2.equals("mm"))
            met = met * 10;
        if (met1.equals("cm") && met2.equals("mi"))
            met = 10*met * 0.000621371192/1000;
        if (met1.equals("cm") && met2.equals("in"))
            met = 10*met * 39.3700787/1000;
        if (met1.equals("cm") && met2.equals("km"))
            met = 10*met * 0.001 / 1000;
        if (met1.equals("cm") && met2.equals("ft"))
            met = 10*met * 3.2808399 / 1000;
        if (met1.equals("cm") && met2.equals("yd"))
            met = 10*met * 1.0936133 / 1000;
        //mi - 3
        if (met1.equals("mi") && met2.equals("m"))
            met = met / 0.000621371192;
        if (met1.equals("mi") && met2.equals("mm"))
            met = (met/0.000621371192)*1000;
        if (met1.equals("mi") && met2.equals("cm"))
            met = met * 100/0.000621371192;
        if (met1.equals("mi") && met2.equals("in"))
            met = met * 39.3700787/0.000621371192;
        if (met1.equals("mi") && met2.equals("km"))
            met = met * 0.001 / 0.000621371192;
        if (met1.equals("mi") && met2.equals("ft"))
            met = met * 3.2808399 / 0.000621371192;
        if (met1.equals("mi") && met2.equals("yd"))
            met = met * 1.0936133 / 0.000621371192;
        //in - 4
        if (met1.equals("in") && met2.equals("m"))
            met = met / 39.3700787;
        if (met1.equals("in") && met2.equals("cm"))
            met = met * 100/39.3700787;
        if (met1.equals("in") && met2.equals("mm"))
            met = met * 1000/39.3700787;
        if (met1.equals("in") && met2.equals("mi"))
            met = met * 0.000621371192/39.3700787;
        if (met1.equals("in") && met2.equals("km"))
            met = met * 0.001 / 39.3700787;
        if (met1.equals("in") && met2.equals("ft"))
            met = met * 3.2808399 / 39.3700787;
        if (met1.equals("in") && met2.equals("yd"))
            met = met * 1.0936133 / 39.3700787;
        //km - 5
        if (met1.equals("km") && met2.equals("m"))
            met = met / 0.001;
        if (met1.equals("km") && met2.equals("cm"))
            met = met * 100/0.001;
        if (met1.equals("km") && met2.equals("mm"))
            met = met * 1000/0.001;
        if (met1.equals("km") && met2.equals("mi"))
            met = met * 0.000621371192/0.001;
        if (met1.equals("km") && met2.equals("in"))
            met = met * 39.3700787/0.001;
        if (met1.equals("km") && met2.equals("ft"))
            met = met * 3.2808399 / 0.001;
        if (met1.equals("km") && met2.equals("yd"))
            met = met * 1.0936133 / 0.001;
        //km - 6
        if (met1.equals("ft") && met2.equals("m"))
            met = met / 3.2808399;
        if (met1.equals("ft") && met2.equals("cm"))
            met = met * 100/3.2808399;
        if (met1.equals("ft") && met2.equals("mm"))
            met = met * 1000/3.2808399;
        if (met1.equals("ft") && met2.equals("mi"))
            met = met * 0.000621371192/3.2808399;
        if (met1.equals("ft") && met2.equals("in"))
            met = met * 39.3700787/3.2808399;
        if (met1.equals("ft") && met2.equals("km"))
            met = met * 0.001/3.2808399;
        if (met1.equals("ft") && met2.equals("yd"))
            met = met * 1.0936133 / 3.2808399;
        //yd - 7
        if (met1.equals("yd") && met2.equals("m"))
            met = met / 1.0936133;
        if (met1.equals("yd") && met2.equals("cm"))
            met = met * 100/1.0936133;
        if (met1.equals("yd") && met2.equals("mm"))
            met = met * 1000/1.0936133;
        if (met1.equals("yd") && met2.equals("mi"))
            met = met * 0.000621371192/1.0936133;
        if (met1.equals("yd") && met2.equals("in"))
            met = met * 39.3700787/1.0936133;
        if (met1.equals("yd") && met2.equals("km"))
            met = met * 0.001/1.0936133;
        if (met1.equals("yd") && met2.equals("ft"))
            met = met * 3.2808399/1.0936133;
        //m - 8
        if (met1.equals("m") && met2.equals("yd"))
            met = met * 1.0936133;
        if (met1.equals("m") && met2.equals("cm"))
            met = met * 100;
        if (met1.equals("m") && met2.equals("mm"))
            met = met * 1000;
        if (met1.equals("m") && met2.equals("mi"))
            met = met * 0.000621371192;
        if (met1.equals("m") && met2.equals("in"))
            met = met * 39.3700787;
        if (met1.equals("m") && met2.equals("km"))
            met = met * 0.001;
        if (met1.equals("m") && met2.equals("ft"))
            met = met * 3.2808399;
        System.out.printf("%.7f", met);
    }
}
