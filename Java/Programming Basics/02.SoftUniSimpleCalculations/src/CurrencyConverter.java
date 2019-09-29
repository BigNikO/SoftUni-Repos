import java.util.Scanner;

public class CurrencyConverter {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double sum = Double.parseDouble(sc.nextLine());
        String currency = sc.nextLine();
        String currency1 = sc.nextLine();
        double result;
        if (currency.equals("USD") && currency1.equals("BGN")) {
            result = sum * 1.79549;
            System.out.printf("%.2f BGN", result);
        } else {
            if (currency.equals("BGN") && currency1.equals("USD")) {
                result = sum / 1.79549;
                System.out.printf("%.2f USD", result);
            } else {
                if (currency1.equals("BGN")) {
                    result = sum * 1.95583;
                    System.out.printf("%.2f BGN", result);
                } else {
                    if (currency.equals("BGN") && currency1.equals("EUR")) {
                        result = sum / 1.95583;
                        System.out.printf("%.2f EUR", result);
                    } else {
                        if (currency.equals("GBP") && currency1.equals("BGN")) {
                            result = sum * 2.53405;
                            System.out.printf("%.2f BGN", result);
                        } else {
                            if (currency.equals("BGN") && currency1.equals("GBP")) {
                                result = sum / 2.53405;
                                System.out.printf("%.2f GBP", result);
                            } else {
                                if (currency.equals("EUR") && currency1.equals("GBP")) {
                                    result = sum * 1.95583 / 2.53405;
                                    System.out.printf("%.2f GBP", result);
                                } else {
                                    if (currency.equals("GBP") && currency1.equals("EUR")) {
                                        result = sum * 2.53405/1.95583;
                                        System.out.printf("%.2f EUR", result);
                                    } else {
                                        if (currency.equals("EUR") && currency1.equals("USD")) {
                                            result = sum * 1.95583/1.795491;
                                            System.out.printf("%.2f USD", result);
                                        } else {
                                            if (currency.equals("USD") && currency1.equals("EUR")) {
                                                result = sum * 1.795491/1.95583;
                                                System.out.printf("%.2f EUR", result);
                                            } else {
                                                if (currency.equals("USD") && currency1.equals("GBP")) {
                                                    result = sum * 1.795491/2.53405;
                                                    System.out.printf("%.2f GBP", result);
                                                } else {
                                                    if (currency.equals("GBP") && currency1.equals("USD")) {
                                                        result = sum * 2.53405/1.795491;
                                                        System.out.printf("%.2f USD", result);
                                                    } else {
                                                        System.out.printf("ERROR");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}