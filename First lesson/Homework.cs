using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task 1 (Вывести на экран число e (основание натурального логарифма) с точностью до десятых.)");
            Console.WriteLine("Число е с точностью до десятых: 2.7");
            double e = Math.E;


            Console.WriteLine("Task 2 (Вывести на экран числа 50 и 10 одно под другим.)");
            Console.WriteLine("50");
            Console.WriteLine("10");

            Console.WriteLine("Task 3 (Составить программу вывода на экран «столбиком» четырех любых чисел.)");
            Console.WriteLine("10");
            Console.WriteLine("5");
            Console.WriteLine("2");
            Console.WriteLine("24");


            Console.WriteLine("Task 4 (Пользователь вводит число.Выведите на экран число, которое больше введенного на 10.)");
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            num += 10;
            Console.WriteLine("Новое число " + num);


            Console.WriteLine("Task 5 (Дана сторона квадрата.Найти его периметр.)");
            Console.WriteLine("Введите сторону квадрата");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Периметр квадрата: " + side * side);


            Console.WriteLine("Task 6 (Дан радиус окружности. Найти длину окружности и площадь круга.)");
            Console.WriteLine("Enter the circle radius");
            float radius = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("The length of the circle is " + 2 * Math.PI * radius);
            Console.WriteLine("The area of the circal is " + 3.14 * radius * radius);


            Console.WriteLine("Task 7 (Найти значение y=cos(x))");
            Console.WriteLine("Enter the angle");
            float angle = Convert.ToSingle(Console.ReadLine());
            float anglerad = (angle * (Math.PI)) / 180;
            Console.WriteLine("The value of cos is " + MathF.Cos(anglerad));


            Console.WriteLine("Task 8 (Даны основания и высота равнобедренной трапеции. Найти ее периметр.)");
            Console.WriteLine("Enter the top base of isosceles trapezium");
            float top = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the bottom bas of trapezium");
            float bottom = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the hight of trapezium");
            float hight = Convert.ToSingle(Console.ReadLine());
            float part = (bottom - top) / 2; //часть основания трапеции
            float sqrside = hight * hight + part * part;
            sqrside = Convert.ToSingle(Math.Sqrt(sqrside));
            float perimeter = top + bottom + 2 * sqrside;
            Console.WriteLine("The perimeter of trapezium is " + perimeter);

            
            Console.WriteLine("Task 9 (Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если " +
                "купили  х кг конфет, у кг печенья и z кг яблок.)");
            float candy = 60;
            float cookies = 73;
            float apple = 80;
            Console.WriteLine("Enter weight of candy in kg");
            float a0 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter weight of cookies in kg");
            float b0 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter weight of apples in kg");
            float c0 = Convert.ToSingle(Console.ReadLine());
            float sum = candy * a0 + cookies * b0 + apple * c0;
            Console.WriteLine("The total sum of purchase is " + sum);

            

            Console.WriteLine("Task 10 ( Напишите программу, выводит на экран три строки Мир ,  Tруд  и  Май " +
                "(кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:  Мир Труд Май. Затем так:)");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("\tТруд");
            Console.WriteLine("         Май");


            Console.WriteLine("Task 11 (Программа просит пользователя ввести 2 числовые переменные. " +
                "А после она меняет их местами и выводит результат на экран. Но, так как пользователь " +
                "может ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести, " +
                "например, букву или строку, а так же учесть, что число может быть дробным, " +
                "и для выделения её дробной части одни используют точку, другие – запятую.)");
            Console.WriteLine("Enter first number");
            double first;
            while (!double.TryParse(Console.ReadLine().Replace(".", ","), out first))
            {
                Console.WriteLine("This is not a number!"); //буква не будет принята
                Console.WriteLine("Enter first number");
            }
            Console.WriteLine("Enter second number");
            double second;
            while (!double.TryParse(Console.ReadLine().Replace(".", ","), out second))
            {
                Console.WriteLine("This is not a number!");
                Console.WriteLine("Enter second number");
            }
            Console.WriteLine(second);
            Console.WriteLine(first);


            Console.WriteLine("Task 12 (Программа для подсчета периметра и площади фигур (треугольник, четырехугольник, круг)." +
                " Пользователь выбирает фигуру, указывает, что программа будет считать – площадь или периметр. " +
                "Задаётся все необходимые значения, а на основе полученных результатов, программа должна подсчитать, " +
                "какими могли бы быть периметры или площади остальных фигур.)");

            Console.WriteLine("Choose figure: ");
            Console.WriteLine("1 - triangle");
            Console.WriteLine("2 - rectangle");
            Console.WriteLine("3 - circle");

            int answer12 = Convert.ToInt32(Console.ReadLine());

            if (answer12 == 1)
            {
                Console.WriteLine("Выберите необходимое значение");
                Console.WriteLine("1 - perimeter");
                Console.WriteLine("2 - area");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Enter first side of triangale");
                    float a1 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter second side of triangle");
                    float b1 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter third side of triangle");
                    float c1 = Convert.ToSingle(Console.ReadLine());
                    float a1b1c1 = a1 + b1 + c1;
                    Console.WriteLine($"The perimeter is " + a1b1c1);
                }
                else
                {
                    Console.WriteLine("Enter side of triangle");
                    float a2 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter hight if triangle");
                    float h2 = Convert.ToSingle(Console.ReadLine());
                    float a2h2 = a2 * h2 / 2;
                    Console.WriteLine($"The area is " + a2h2);
                }
            }
            else if (answer12 == 2)
            {
                Console.WriteLine("Выберите необходимое значение");
                Console.WriteLine("1 - perimeter");
                Console.WriteLine("2 - area");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Enter first side of rectangle");
                    float a3 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter second side of rectangle");
                    float b3 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter third side of rectangle");
                    float c3 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter fourth side of rectangle");
                    float d3 = Convert.ToSingle(Console.ReadLine());
                    float abcd = a3 + b3 + c3 + d3;
                    Console.WriteLine($"The perimeter is " + abcd);
                }
                else
                {
                    Console.WriteLine("Enter first diagonal of rectangle");
                    float d1 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter second diagonal of rectangle");
                    float d2 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter sinof angle between these diagonals");
                    float sin = Convert.ToSingle(Console.ReadLine().Replace(".", ","));
                    float d1d2 = d1 * d2 * sin / 2;
                    Console.WriteLine($"The area is " + d1d2);
                }
            }
            else
            {
                Console.WriteLine("Выберите необходимое значение");
                Console.WriteLine("1 - length");
                Console.WriteLine("2 - area");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Enter radius of the circle");
                    float rad = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine($"The lenght is " + 2 * 3.14 * rad);
                }
                else
                {
                    Console.WriteLine("Enter radius of the circle");
                    float rad = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine($"The area is " + 3.14 * rad * rad);
                }
            }


            Console.WriteLine("Task 13 (Составить программу вывода на экран числа, вводимого с клавиатуры. " +
                "Вводимому числу должно предшествовать сообщение «Вы ввели число».)");
            Console.WriteLine("Введите первое число");
            double num12;
            while (!double.TryParse(Console.ReadLine().Replace(".", ","), out num12))
            {
                Console.WriteLine("Это не число!"); //буква не будет принята
                Console.WriteLine("Введите первое число");
            }
            Console.WriteLine($"Вы ввели число: " + num12);


            Console.WriteLine("Task 14 (Составить программу вывода на экран следующей информации: 2кг  13 17)");
            Console.WriteLine("2kg");
            Console.WriteLine("13 17");

            
            Console.WriteLine("Task 15 (Составить программу вывода на экран «столбиком» четырех случайных чисел.)");
            Random ran = new Random();
            int num141 = ran.Next();
            int num142 = ran.Next();
            int num143 = ran.Next();
            int num144 = ran.Next();
            Console.WriteLine(num141);
            Console.WriteLine(num142);
            Console.WriteLine(num143);
            Console.WriteLine(num144);


            Console.WriteLine("Task 16 (Найти корни квадратного уравнения(коэффициента задаются пользователем с клавиатуры)");

            Console.WriteLine("We will help you solve a quadratic equation. Just enter the values of a, b and c below");
            Console.WriteLine("Enter the value of a");
            int a15 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            int b15 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            int c15 = Convert.ToInt32(Console.ReadLine());
            int discriminant15 = (b15 * b15 - 4 * a15 * c15);
            Console.WriteLine("The first x equals " + (-b15 + discriminant15) / 2 * a15);
            int X152 = (-b15 - discriminant15) / 2 * a15;
            Console.WriteLine("the second x equals " + X152);

            //Task 17 (Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.)

            Console.WriteLine("Введите первое число");
            int num161 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num162 = Convert.ToInt32(Console.ReadLine());
            var res161 = (double)(num161 + num162) / 2; //подсчет среднего арифметического
            Console.WriteLine($"Среднее арифметическое: " + res161);
            int sum161 = num161 * num161 + num162 * num162;
            float sum162 = Convert.ToSingle(Math.Sqrt(sum161));
            Console.WriteLine($"Среднее геометрическое: " + sum162);

            //Task 18 (Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.)

            Console.WriteLine("Введите координату первой точки по х");
            float x171 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите координату первой точки по у");
            float y171 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите координату второй точки по х");
            float x172 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите координату второй точки по у");
            float y172 = Convert.ToSingle(Console.ReadLine());
            float res171 = Convert.ToSingle(Math.Sqrt((x172 - x171) * (x172 - x171) + (y172 - y171) * (y172 - y171)));
            Console.WriteLine("Расстояние между х и у: " + res171);

            //Task 19 (Составить программу обмена значениями трех переменных величин а, b, c по следующим двум схема 
            //а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
            //б) b присвоить значение а, с присвоить значение b, а присвоить значение с.)

            Console.WriteLine("Введите число а");
            int a18 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b18 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c18 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение a: " + a18 + " Значение b: " + b18 + " Значение с: " + c18);
            Console.WriteLine("Обмен по первой схеме");
            (a18, b18, c18) = (b18, c18, a18);
            Console.WriteLine("Значение а: " + a18 + " Значение b:" + b18 + " Значение с:" + c18);
            Console.WriteLine("Обмен по второй схеме");
            (a18, b18, c18) = (c18, a18, b18);
            Console.WriteLine("Значение а: " + a18 + " Значение b:" + b18 + " Значение с:" + c18);

            //Task 20 (С начала суток прошло n секунд. Определить: а) сколько полных часов прошло с начала суток;
            //б) сколько полных минут прошло с начала очередного часа; в) сколько полных секунд прошло с начала очередной минуты.)

            Console.WriteLine("Введите количество секунд, которое прошло с начала суток"); //проверить: 15816 (4:23:36)
            int sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество часов с начала суток: " + sec / 3600);
            Console.WriteLine("Количество минут с начала очередного часа: " + sec / 60 % 60);
            Console.WriteLine("Количество секунд с начала очередной минуты " + (double)sec % 60);

            //Task 21 (Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?)

            int big20 = 543 * 130;
            Console.WriteLine("Площадь большого прямоугольника: " + big20);
            int small20 = 130 * 130;
            Console.WriteLine("Площадь маленького квадрата " + small20);
            Console.WriteLine("Из большого прямоугольника можно вырезать " + big20 / small20 + " маленьких");

            //task 22 (Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.)

            Console.WriteLine("Введите трехзначное число");
            int num211 = Convert.ToInt32(Console.ReadLine());
            int num212 = num211 % 10;
            Convert.ToInt32(num212);
            Convert.ToInt32(num211);
            Console.WriteLine("Новое число: " + num212 + num211);

            //Task 23 ( Дано натуральное число n(n > 999). Найти: а) число сотен в нем; б) число тысяч в нем.)

            Console.WriteLine("Введите натуральное число больше 999");
            int num22 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число сотен в заданном числе: " + num22 / 100);
            Console.WriteLine("Число тысяч в заданном числе:" + num22 / 1000);

            //Task 24 (Дано четырехзначное число. Найти:
            //а) число, полученное при прочтении его цифр справа налево;
            //б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа.
            //в) число, образуемое при перестановке второй и третьей цифр заданного числа.
            //г) число, образуемое при перестановке двух первых и двух последних цифр заданного числа.)

            Console.WriteLine("Введите четырехзначное число");
            int num231 = Convert.ToInt32(Console.ReadLine());
            int one23 = num231 / 1000;
            int two23 = num231 / 100 % 10;
            int three23 = num231 % 100 / 10;
            int four23 = num231 % 10;
            int sum231 = one23 + two23 * 10 + three23 * 100 + four23 * 1000;
            Console.WriteLine("Число, получившееся при прочтении цифр изначального числа справа налево: " + sum231);
            int sum232 = two23 * 1000 + one23 * 100 + four23 * 10 + three23;
            Console.WriteLine("Число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа: " + sum232);
            int sum233 = one23 * 1000 + three23 * 100 + two23 * 10 + four23;
            Console.WriteLine("Число, образуемое при перестановке второй и третьей цифр заданного числа: " + sum233);
            int sum234 = three23 * 1000 + four23 * 100 + two23 * 10 + one23;
            Console.WriteLine("Число, образуемое при перестановке двух первых и двух последних цифр заданного числа: " + sum234);

            //Task 25 ( Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили на 10, а к частному слева
            //приписали последнюю цифру числа x, то получилось число n. Найти число x. Значение n вводится с клавиатуры,
            //100 ≤ n ≤ 999 и при этом число десятков в n не равно нулю.)

            Console.WriteLine("Введите число n");
            int num241 = Convert.ToInt32(Console.ReadLine());
            int one24 = num241 / 100;
            int two24 = num241 % 100 / 10;
            int three24 = num241 % 10;
            int bet241 = two24 * 10 + three24;
            int bet242 = bet241 * 10;
            int bet243 = bet242 + one24;
            Console.WriteLine("Число х: " + bet243);

            //Task 26 (Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент времени:
            //«h часов, m минут, s секунд». Определить угол (в градусах) между положением часовой стрелки в начале суток
            //и в указанный момент времени.)

            int angle251 = 360 / 12;
            int angle252 = 360 / 60;
            Console.WriteLine("Введите час");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуту");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секунду");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Угол между положением часовой стрелки в начале суток и в указанный момент времени: " + angle251 * h);
            Console.WriteLine("Угол между положением минутной стрелки в начале суток и в указанный момент времени: " + angle252 * m);
            Console.WriteLine("Угол между положением секундной стрелки в начале суток и в указанный момент времени: " + angle252 * s);

            //Task 27(Часовая стрелка образует угол y с лучом, проходящим через центр и через точку, соответствующую
            //12 часам на циферблате, 0 ≤ y ≤ 2.Определить значение угла для минутной стрелки, а также количество
            //полных часов и полных минут.)

            //Не поняла, что от меня требуется в этом задании

            //Task 28 (Создать программу, которая будет выводить на экран меньшее по модулю из трёх
            //введённых пользователем вещественных чисел)

            Console.WriteLine("Введите превое число");
            int a27 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b27 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c27 = Convert.ToInt32(Console.ReadLine());
            int newa27 = Math.Abs(a27);
            int newb27 = Math.Abs(b27);
            int newc27 = Math.Abs(c27);
            int big = 0;
            if ((newa27 > newb27) && (newa27 > newc27))
                big = newa27;
            else if ((newb27 > newa27) && (newb27 > newc27))
                big = newb27;
            else if ((newc27 > newa27) && (newc27 > newb27))
                big = newc27;
            Console.WriteLine("Наибольшее из трех чисел по модулю= " + big);

            //Task 29 (Найти сумму большего и меньшего из трёх заданных чисел)

            Console.WriteLine("Введите превое число");
            int a29 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b29 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c29 = Convert.ToInt32(Console.ReadLine());
            int big29 = 0;
            int small = 0;
            if ((a29 > b29) && (a29 > c29) && (b29 < a29) && (b29 < c29))
            {
                big29 = a29;
                small = b29;
                Console.WriteLine($"Сумма большего и меньшего чисел:" + (big + small));
            }

            else if ((a29 > b29) && (a29 > c29) && (c29 < a29) && (c29 < b29))
            {
                big29 = a29;
                small = c29;
                Console.WriteLine($"Сумма большего и меньшего чисел:" + (big + small));
            }

            else if ((b29 > a29) && (b29 > c29) && (a29 < b29) && (a29 < c29))
            {
                big29 = b29;
                small = a29;
                Console.WriteLine($"Сумма большего и меньшего чисел:" + (big + small));
            }

            else if ((b29 > a29) && (b29 > c29) && (c29 < a29) && (c29 < b29))
            {
                big29 = b29;
                small = c29;
                Console.WriteLine($"Сумма большего и меньшего чисел:" + (big + small));
            }

            else if ((c29 > b29) && (c29 > a29) && (a29 < b29) && (a29 < c29))
            {
                big29 = c29;
                small = a29;
                Console.WriteLine($"Сумма большего и меньшего чисел:" + (big + small));
            }

            else if ((c29 > b29) && (c29 > a29) && (b29 < a29) && (b29 < c29))
            {
                big29 = c29;
                small = b29;
                Console.WriteLine($"Сумма большего и меньшего чисел:" + (big + small));
            }

            //Task 30 (Подсчитать общее количество делителей натурального числа)

            Console.WriteLine("Введите число");
            int count30 = 0;
            int a30 = Convert.ToInt32(Console.ReadLine());
            for (int i30 = 1; i30 < 1000000; i30++)
                if (a30 % i30 == 0)
                {
                    count30++;
                    Console.Clear(); //очистила консоль, потому что мне кажется, что итерации мешают восприятию информации о том, сколько у числа делителей. Не придумала, как сделать по-другому
                    Console.WriteLine("Количество делителей вашего числа: " + count30);
                }


            //Task 31 (Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем вычисления дискриминанта.
            //Но Петя поведал ему о методе решения кубических уравнений вида A*X3 + B*X2 + C*X + D = 0.
            //На факультативе по математике Васе задали решить около ста уравнений как раз такого вида.
            //Но, к сожалению, Вася забыл формулы, о которых рассказывал ему Петя.
            //Но Васе было известно, что все корни уравнений – целые числа и находятся на отрезке [-100, 100].
            //Поэтому у Васи есть шанс найти их методом перебора, но для этого ему придется затратить уйму времени,
            //т.к. возможно необходимо будет осуществить перебор нескольких тысяч значений. Помогите Васе написать программу,
            //которая поможет ему найти корни кубических уравнений!)

            Console.WriteLine("Введите значение А");
            int a31 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение В");
            int b31 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение С");
            int c31 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение D");
            int d31 = Convert.ToInt32(Console.ReadLine());
            for (int i31 = -100; i31 < 200; i31++)
                if ((a31 * i31 * i31 * i31 + b31 * i31 * i31 + c31 * i31 + d31) == 0)
                {
                    Console.WriteLine("Корень вашего уравнения: " + i31);
                }




            //Task 32 (Заданы первый и второй элементы арифметической прогрессии.
            //Требуется написать программу, которая вычислит элемент прогрессии по ее номеру. )

            Console.WriteLine("Введите первый элемент прогрессии");
            int first30 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй элемент прогрессии");
            int second30 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер элемента прогрессии, значение которого необходимо найти");
            int no30 = int.Parse(Console.ReadLine()); //ввод номера элемента прогрессии
            int d30 = second30 - first30;
            int n30 = first30 + (no30 - 1) * d30;
            Console.WriteLine("Элемент прогрессии: ");

            //Task 33 (Если я пенсионер или студент и не трудоустроен, то получаю кредит,
            //а если трудоустроен не получаю кредит. Ну а если я, и пенсионер и студент,(трудоустройство тут не имеет значения)
            //то не должен получить. Необходимо вводить строки, содержащие информацию о том, студент, пенсионер или кто-то ещё.
            //Вывести информацию: дадут кредит или нет.)

            Console.WriteLine("Чтобы узнать получите ли кредит, Вам нужно ответить на несколько вопросовю");
            Console.WriteLine("Ответ должен быть написан маленькими буквами");
            Console.WriteLine("Вы пенсионер?");
            string info31 = Console.ReadLine();
            Console.WriteLine("Вы студент?");
            string sinfo31 = Console.ReadLine();
            Console.WriteLine("Вы трудоустроены?");
            string work31 = Console.ReadLine();
            if (info31 == "да" && sinfo31 == "нет" && work31 == "нет")
            {
                Console.WriteLine("Вы получите кредит");

            }

            else if (info31 == "нет" && sinfo31 == "да" && work31 == "нет")
            {
                Console.WriteLine("Вы получите кредит");

            }

            else if (info31 == "да" && sinfo31 == "нет" && work31 == "да")
            {
                Console.WriteLine("Вы не получите кредит");
            }

            else if (info31 == "нет" && sinfo31 == "да" && work31 == "да")
            {
                Console.WriteLine("Вы не получите кредит ");
            }

            else if (info31 == "да" && sinfo31 == "да" && work31 == "нет")
            {
                Console.WriteLine("Вы не получите кредит");
            }

            //Task 34 (Составить программу, которая: а) запрашивает имя человека и повторяет его на экране; б) запрашивает
            //имя человека и повторяет его на экране с приветствием.)

            Console.WriteLine("Введите имя");
            string name32 = Console.ReadLine();
            Console.WriteLine(name32);
            Console.WriteLine($"Привет, " + name32);

            //Task35 (Воспроизвести разговор Гарри и дневника Тома Реддла.
            //Пользователь здоровается с консолью. Консоль спрашивает, как зовут пользователя.
            //Пользователь называет имя. Консоль пишет: привет, <имя пользователя>.
            //После этого пользователь спрашивает, знает ли консоль что-то о тайной комнате.
            //Консоль отвечает «Да». После этого пользователь спрашивает, может ли рассказать.
            //Консоль отвечает «Нет». Спустя 5 секунд консоль дополняет «но могу показать». Консоль меняет цвет на любой случайный цвет.)

            string a33 = Console.ReadLine();
            if (a33 == "привет")
            {
                Console.WriteLine("как тебя зовут?");
            }
            string name33 = Console.ReadLine();
            Console.WriteLine($"Привет, " + name33);
            string ask33 = Console.ReadLine();
            if (ask33 == "ты знаешь что-то о тайной комнате?")
            {
                Console.WriteLine("нет");
                Console.WriteLine("да");
                Thread.Sleep(5000);
                Console.WriteLine("но могу показать");
                Console.ForegroundColor = ConsoleColor.Red; //получилось только изменить цвет текста
                Console.WriteLine();
            }

            //Task 36 (Вычислить контрольную цифру штрихкода(EAN13).  а) 12 цифр определяются случайным образом
            //б) 12 цифр вводит пользователь)

            Console.WriteLine("");
            Random rnd = new Random();
            int r361 = rnd.Next(10);
            int r362 = rnd.Next(10);
            int r363 = rnd.Next(10);
            int r364 = rnd.Next(10);
            int r365 = rnd.Next(10);
            int r366 = rnd.Next(10);
            int r367 = rnd.Next(10);
            int r368 = rnd.Next(10);
            int r369 = rnd.Next(10);
            int r3610 = rnd.Next(10);
            int r3611 = rnd.Next(10);
            int r3612 = rnd.Next(10);

            int c36 = ((r361 + r363 + r365 + r367 + r369 + r361) + 3 * (r362 + r364 + r366 + r368 + r3610 + r3612));
            int co36 = c36 % 10;
            int con36 = (10 - co36) % 10;

            Console.WriteLine("Штрихкод из случайных цифр:" + r361 + r362 + r363 + r364 + r365 + r366 + r367 + r368 + r369 + r3610 + r3611 + r3612);
            Console.WriteLine($"Контрольная цифра штрихкода из случайных цифр: " + con36);
            Console.WriteLine("Введите цифры штрихкода через enter.");
            int u361 = Convert.ToInt32(Console.ReadLine());
            int u362 = Convert.ToInt32(Console.ReadLine());
            int u363 = Convert.ToInt32(Console.ReadLine());
            int u364 = Convert.ToInt32(Console.ReadLine());
            int u365 = Convert.ToInt32(Console.ReadLine());
            int u366 = Convert.ToInt32(Console.ReadLine());
            int u367 = Convert.ToInt32(Console.ReadLine());
            int u368 = Convert.ToInt32(Console.ReadLine());
            int u369 = Convert.ToInt32(Console.ReadLine());
            int u3610 = Convert.ToInt32(Console.ReadLine());
            int u3611 = Convert.ToInt32(Console.ReadLine());
            int u3612 = Convert.ToInt32(Console.ReadLine());
            int cont36 = ((u361 + u363 + u365 + u367 + u369 + u361) + 3 * (u362 + u364 + u366 + u368 + u3610 + u3612));
            int contr36 = cont36 % 10;
            int contro36 = (10 - contr36) % 10;

            Console.WriteLine("Штрихкод из случайных цифр:" + u361 + u362 + u363 + u364 + u365 + u366 + u367 + u368 + u369 + u3610
                + u3611 + u3612);
            Console.WriteLine($"Контрольная цифра штрихкода из случайных цифр: " + contro36);











        }
    }
    }





