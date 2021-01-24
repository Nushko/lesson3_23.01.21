using System;
using System.Security.Cryptography;

namespace lesson3_23._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Дано два числа A и B (A<B) выведите суму всех чисел, расположенных между
            данными числами на экран. 
            */
            
            Console.WriteLine("Введите два числа: ");
            int sum = 0, a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма всех чисел между {a} и {b} = ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = a + 1; i < b; i += 1)
                sum += i;
            Console.WriteLine(sum);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            /*
            Дано два числа A и B (A<B) выведите все нечетные значения, расположенные
            между данными числами
            */

            Console.WriteLine("Введите два числа: ");
            a = int.Parse(Console.ReadLine()); b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Все нечётные числа между {a} и {b}: ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = a + 1; i < b; i += 1)
            {
                if (i < 0)
                {
                    if (Math.Abs(i) % 2 == 1)
                        Console.WriteLine(i);
                }
                else
                {
                    if (i % 2 == 1)
                        Console.WriteLine(i);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ReadKey();
            
            /*
            Геометрические фигуры
            */

            Console.WriteLine("Прямоугольник");
            Console.ForegroundColor = ConsoleColor.Green;
            int n = 11, m = 6;
            for (int i = 1; i <= m; i += 1)
            {
                for (int j = 1; j <= n; j += 1)
                {
                    if ((j == 1 || j == n) || (i == 1 || i == m))
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Прямоугольный треугольник");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; i <= n; i += 1)
            {
                for (int j = 1; j <= n; j += 1)
                {
                    if (j == 1 || i == j || i == n)
                        Console.Write("*  ");
                    else
                        Console.Write("   ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Равносторонний треугольник");
            Console.ForegroundColor = ConsoleColor.Green;
            int nx = n, ny = n;
            for (int i = 1; i <= n; i += 1)
            {
                for (int j = 1; j < n * 2; j += 1)
                {
                    if (j == nx || j == ny || i == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                nx -= 1;
                ny += 1;
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Ромб");
            Console.ForegroundColor = ConsoleColor.Green;
            nx = n / 2 + 1;
            for (int i = 1; i <= n; i += 1)
            {
                for (int j = 1; j <= n; j += 1)
                {
                    if (j == nx || j == n - nx + 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                if (i <= n / 2)
                    nx -= 1;
                else
                    nx += 1;

                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            /*
            Начальный вклад в банке равен 1000 руб. Через каждый месяц размер вклада
            увеличивается на P процентов от имеющейся суммы (P — вещественное число, 0 < P <
            25). По данному P определить, через сколько месяцев размер вклада превысит 1100
            руб., и вывести найденное количество месяцев K (целое число) и итоговый размер
            вклада S (вещественное число).
            */

            double vklad = 1000;
            Console.Write("Введите значение P: ");
            int K = 0, P = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Ваш начальный вклад составляет {vklad}руб. \nМесяцев до превышения 1100руб.: ");
            while(vklad < 1100)
            {
                K += 1;
                vklad += (vklad / 100) * P;
            }
            Console.WriteLine($"{K}. Вклад будет равен {Math.Round(vklad, 2)}руб.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            /*
            Создать массив размера N элементов, заполнить его произвольными целыми
            значениями (размер массива задает пользователь).
            Вывести на экран:
            • Наибольшее значение массива;
            • Наименьшее значение массива;
            • Общую сумму всех элементов;
            • Среднее арифметическое всех элементов;
            • Вывести все нечетные значения;
            */

            Console.Write("Введите размер массива: ");
            int min = 0, max = 0, sz = int.Parse(Console.ReadLine());
            double sumarr = 0;
            if (sz != 0)
            {
                int[] arr1 = new int[sz];
                arr1[0] = 1;
                min = arr1[0];
                max = arr1[0];
                sumarr = arr1[0];
                for(int i = 1; i < sz; i += 1)
                {
                    arr1[i] = i + 1;
                    min = Math.Min(min, arr1[i]);
                    max = Math.Max(max, arr1[i]);
                    sumarr += arr1[i];
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Наибольшее значение массива: " + max);
                Console.WriteLine("Наименьшее значение массива: " + min);
                Console.WriteLine("Общая сумма всех элементов: " + sumarr);
                Console.WriteLine("Среднее арифметическое всех элементов: " + Math.Round(sumarr / sz, 2));
                Console.WriteLine("Нечётные значения: ");
                for(int i = 0; i < sz; i += 1)
                    if(arr1[i] % 2 == 1)
                        Console.WriteLine(arr1[i]);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив не имеет размер.");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            /*
            Создайте проект, который принимает в качестве аргумента массив целочисленных
            элементов и возвращает инвертированный массив (элементы массива в обратном
            порядке). 
            */

            Console.WriteLine("Введите размер массива: ");
            int sz1 = int.Parse(Console.ReadLine());
            int[] arr = new int[sz1], arrrev = new int[sz1];

            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0, j = sz1 - 1; i < sz1; i += 1, j -= 1)
            {
                arr[i] = int.Parse(Console.ReadLine());
                arrrev[j] = arr[i];
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Массив - ");
            for (int i = 0; i < sz1; i += 1)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            Console.Write("Инвертированный массив - ");
            for (int i = 0; i < sz1; i += 1)
                Console.Write(arrrev[i] + " ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            /*
            Создать массив размера N элементов, заполнить его произвольными целыми
            значениями (размер массива задает пользователь).
            1. Выведите на экран.
            2. Создайте целочисленную переменную count (задает пользователь), index
            (задает пользователь).
            3. Создайте новый массив верните часть полученного в качестве аргумента
            массива начиная с позиции, указанной в аргументе index, размерностью,
            которая соответствует значению аргумента count.
            4. Если аргумент count содержит значение больше, чем количество элементов,
            которые входят в выбираемую часть исходного массива (от указанного индекса
            index, до индекса последнего элемента), то при формировании нового массива
            размерностью в count, заполните единицами те элементы, которые не были
            скопированы из исходного массива.
            */

            Console.WriteLine("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] arrnew = new int[N];
            for (int i = 0; i < N; i += 1)
            {
                arrnew[i] = i + 1;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Массив - ");
            for (int i = 0; i < N; i += 1)
                Console.Write(arrnew[i] + " ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Введите count и index: ");
            int count = int.Parse(Console.ReadLine()), index = int.Parse(Console.ReadLine());
            int[] arrnew2 = new int[count];
            for (int i = 0; i < count; i += 1)
            {
                if (i + index >= N)
                {
                    arrnew2[i] = 1;
                    continue;
                }
                arrnew2[i] = arrnew[index + i];
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Новый массив - ");
            for (int i = 0; i < count; i += 1)
                Console.Write(arrnew2[i] + " ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
