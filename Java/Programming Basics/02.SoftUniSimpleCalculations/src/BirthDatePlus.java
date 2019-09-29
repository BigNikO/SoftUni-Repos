import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Date;
import java.util.Scanner;

public class BirthDatePlus {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        DateTimeFormatter datef = DateTimeFormatter.ofPattern("dd-MM-yyyy");
        // Метод - декларирам променливата datef, като указвам формата на датата.
        String text = sc.nextLine();
        LocalDate date = LocalDate.parse(text, datef);
//      Давам на променливата date - стойността на променливата текст от тип String чрез LocalDate.Parse , като указвам формата,
//      който съм избрал чрез променливата datef
        LocalDate plus = date.plusDays(999);
//      Добавяне на определен брой дни към въведената дата
        System.out.println(datef.format(plus));
//      Изходен резултат - променливата plus със съответните добавени дни, чрез променливата datef, за указване на формата на датата
    }
}
