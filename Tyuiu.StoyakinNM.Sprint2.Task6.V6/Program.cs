using Tyuiu.StoyakinNM.Sprint2.Task6.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Стоякин Н.М. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Стоякин Никита Михайлович | ПКТб 24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
        Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти «червы»   *");
        Console.WriteLine("* — 4, а достоинству карт: «валету» — 11, «даме» — 12, «королю» — 13,     *");
        Console.WriteLine("* «тузу» — 14 (порядковые номера карт остальных достоинств соответствуют  *");
        Console.WriteLine("* их названиям: «шестерка», «девятка» и т. п.). По заданным номеру масти  *");                                             
        Console.WriteLine("* m (1 <= m <= 4) и номеру достоинства карты k (6 <= k <= 14) определить  *");
        Console.WriteLine("* полное название (масть и достоинство) соответствующей карты в виде      *");
        Console.WriteLine("* «Дама пик», Шестерка бубен» и т. п                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите номер масти: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите номер достоинства: ");
        int n = Convert.ToInt32(Console.ReadLine());


        string res;

        if ((m < 1) || (n > 14) || (n <= 5) || (m >= 5))
        {
            res = "Введено неверное значение!";
        }
        else
        {
            res = "Это: " + ds.FindCardNameAndValue(m, n);
        }


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ;                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();

      
    }
}