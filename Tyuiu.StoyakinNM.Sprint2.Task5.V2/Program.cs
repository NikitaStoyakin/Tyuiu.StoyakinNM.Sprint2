using Tyuiu.StoyakinNM.Sprint2.Task5.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Стоякин Н.М. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Стоякин Никита Михайлович | ПКТб 24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* По данному месяцу, определите в какую пору года попадает этот месяц     *");
        Console.WriteLine("* (Зима, Лето, Весна, Осень).                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите номер месяца: ");
        int numMouth = Convert.ToInt32(Console.ReadLine());

        string res;

        if ((numMouth < 1) || (numMouth > 12))
        {
            res = "Введено неверное значение!";
        }
        else
        {
            res = "Это месяц:" + ds.FindMonthSeason(numMouth);
        }


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ;                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(res);
        Console.ReadKey();
    }
}