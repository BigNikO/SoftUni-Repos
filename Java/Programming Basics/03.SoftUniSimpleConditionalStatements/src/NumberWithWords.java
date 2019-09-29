import java.util.Scanner;

public class NumberWithWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num1 = Integer.parseInt(sc.nextLine());
        if (num1 == 0) {
            System.out.println("zero");
            ;
        } else {
            if (num1 == 1) {
                System.out.println("one");
                ;
            } else {
                if (num1 == 2) {
                    System.out.println("two");
                    ;
                } else {
                    if (num1 == 3) {
                        System.out.println("three");
                        ;
                    } else {
                        if (num1 == 4) {
                            System.out.println("four");
                            ;
                        } else {
                            if (num1 == 5) {
                                System.out.println("five");
                                ;
                            } else {
                                if (num1 == 6) {
                                    System.out.println("six");
                                    ;
                                } else {
                                    if (num1 == 7) {
                                        System.out.println("seven");
                                        ;
                                    } else {
                                        if (num1 == 8) {
                                            System.out.println("eight");
                                            ;
                                        } else {
                                            if (num1 == 9) {
                                                System.out.println("nine");
                                                ;
                                            } else {
                                                if (num1 > 9) {
                                                    System.out.println("number too big");
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