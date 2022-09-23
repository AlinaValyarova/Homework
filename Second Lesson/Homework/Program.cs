using System;
using System.Text;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ex7();
        }

        public static void ex1()
        {
            Console.WriteLine("Создать структуру  студента. У студента есть Фамилия, Имя, его Идентификатор, Дата Рождения," +
                "категория алкоголизма (a – студент алкоголик, b – студент любитель выпить, но не алкоголик," +
                " c – студент пьет по праздникам, d – студент не пьет), также есть у студент объем выпитого алкоголя" +
                "Создать 5 студентов с различными параметрами. Посчитать общий объем алкоголя и кто сколько процентов выпил");

            Student studentOne;
            studentOne.SecondName = "Иванов ";
            studentOne.FirstName = "Сергей ";
            studentOne.Id = 4532;
            studentOne.Birthdate = "10.12.01";
            studentOne.Category = "a";
            studentOne.Volume = 4;

            Student studentTwo;
            studentTwo.SecondName = "Карпов ";
            studentTwo.FirstName = "Александр ";
            studentTwo.Id = 8321;
            studentTwo.Birthdate = "17.02.01";
            studentTwo.Category = "b";
            studentTwo.Volume = 3;

            Student studentThree;
            studentThree.SecondName = "Смирнова ";
            studentThree.FirstName = "Екатерина ";
            studentThree.Id = 5679;
            studentThree.Birthdate = "25.04.01";
            studentThree.Category = "c";
            studentThree.Volume = 2;

            Student studentFour;
            studentFour.SecondName = "Вишников ";
            studentFour.FirstName = "Михаил ";
            studentFour.Id = 8976;
            studentFour.Birthdate = "11.05.01";
            studentFour.Category = "c";
            studentFour.Volume = 0.9;

            Student studentFive;
            studentFive.SecondName = "Маслова ";
            studentFive.FirstName = "Виктория ";
            studentFive.Id = 7893;
            studentFive.Birthdate = "22.08.01";
            studentFive.Category = "d";
            studentFive.Volume = 0;

            double FullVolume = studentOne.Volume + studentTwo.Volume + studentThree.Volume + studentFour.Volume + studentFive.Volume;

            Console.WriteLine(studentOne.FirstName + studentTwo.SecondName + "Процент выпитого алкоголя: " + (studentOne.Volume / FullVolume) * 100);
            Console.WriteLine(studentTwo.FirstName + studentTwo.SecondName + "Процент выпитого алкоголя: " + (studentTwo.Volume / FullVolume) * 100);
            Console.WriteLine(studentThree.FirstName + studentThree.SecondName + "Процент выпитого алкоголя: " + (studentThree.Volume / FullVolume) * 100);
            Console.WriteLine(studentFour.FirstName + studentFour.SecondName + "Процент выпитого алкоголя: " + (studentFour.Volume / FullVolume) * 100);
            Console.WriteLine(studentFive.FirstName + studentFive.SecondName + "Процент выпитого алкоголя: " + (studentFive.Volume / FullVolume) * 100);
        }

        public struct Student
        {
            public string SecondName;
            public string FirstName;
            public int Id;
            public string Birthdate;
            public string Category;
            public double Volume;
        }

        public static void ex2()
        {
            Console.WriteLine(" Выведите на экран информацию о каждом типе данных в виде: " +
                "Тип данных – максимальное значение – минимальное значение");
            Console.WriteLine("Тип данных: byte" + " максимальное значение: " + Byte.MaxValue + " минимальное значение: " + Byte.MinValue);
            Console.WriteLine("Тип данных: sbyte" + " максимальное значение: " + SByte.MaxValue + " минимальное значение: " + SByte.MinValue);
            Console.WriteLine("Тип данных: short" + " максимальное значение: " + Int16.MaxValue + " минимальное значение: " + Int16.MinValue);
            Console.WriteLine("Тип данных: ushort" + " максимальное значение: " + UInt16.MaxValue + " минимальное значение: " + UInt16.MinValue);
            Console.WriteLine("Тип данных: int" + " максимальное значение: " + Int32.MaxValue + " минимальное значение: " + Int32.MinValue);
            Console.WriteLine("Тип данных: uint" + " максимальное значение: " + UInt32.MaxValue + " минимальное значение: " + UInt32.MinValue);
            Console.WriteLine("Тип данных: long" + " максимальное значение: " + Int64.MaxValue + " минимальное значение: " + Int64.MinValue);
            Console.WriteLine("Тип данных: ulong" + " максимальное значение: " + UInt64.MaxValue + " минимальное значение: " + UInt64.MinValue);
            Console.WriteLine("Тип данных: float" + " максимальное значение: " + Single.MaxValue + " минимальное значение: " + Single.MinValue);
            Console.WriteLine("Тип данных: double" + " максимальное значение: " + Double.MaxValue + " минимальное значение: " + Double.MinValue);
            Console.WriteLine("Тип данных: decimal" + " максимальное значение: " + Decimal.MaxValue + " минимальное значение: " + Decimal.MaxValue);

        }

        public static void ex3()
        {
            Console.WriteLine(" Напишите программу, в которой принимаются данные пользователя в виде имени, " +
                "города, возраста и PIN - кода.Далее сохраните все значение в соответствующей переменной, " +
                "а затем распечатайте всю информацию в правильном формате.");
            User UserOne;
            Console.WriteLine("Введите имя");
            UserOne.FirstName = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            UserOne.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите город");
            UserOne.City = Console.ReadLine();
            Console.WriteLine("Введите PIN-код");
            UserOne.Pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Имя: " + UserOne.FirstName);
            Console.WriteLine("Возраст: " + UserOne.Age);
            Console.WriteLine("Город: " + UserOne.City);
            Console.WriteLine("PIN-код: " + UserOne.Pin);
        }

        public struct User
        {
            public string FirstName;
            public int Age;
            public string City;
            public int Pin;
        }

        public static void ex4()
        {
            Console.WriteLine("Напишите программу, которая преобразует имя в инициалы." +
              "На вход подаются два слова с одним пробелом.На консоль выводятся 2 заглавные буквы с разделяющий их точкой.");

            Console.WriteLine("Введите Фамилию и Имя");
            string Name = Console.ReadLine().Replace(" ", ".");
            var dot = ".";
            int IndexOfDot = Name.IndexOf(dot);
            char chr1 = Name[0];
            char chr2 = Name[IndexOfDot + 1];
            Console.WriteLine(chr1 + "." + chr2 );
        }

        public static void ex5()
        {
            Console.WriteLine("Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить," +
                " чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на ваш отпуск." +
                " Вам будет предоставлена стандартная цена (normPrice), скидка в DutyFree(salePrice) и стоимость отпуска (holidayPrice)." +
                " Например, если бутылка обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10 %, " +
                "вы сэкономите 1 фунт стерлингов на каждой бутылке.Если ваш отпуск стоит 500 фунтов стерлингов, ответ," +
                " который вы должны вернуть, будет 500.Все входные данные будут целыми числами." +
                "Пожалуйста, верните целое число.Округлить в меньшую сторону.");

            Console.WriteLine("Введите стандартную цену");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите процент скидки в DutyFree");
            int salePrice = Convert.ToInt32(Console.ReadLine());
            int profit = (normPrice * salePrice) / 100;
            Console.WriteLine("Введите стоимость отпуска");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            int amount = holidayPrice/ profit;
            Console.WriteLine("Необходимое количество бутылок: " + amount);
        }

        public static void ex6()
        {
            Console.WriteLine(" Таракан - одно из самых быстрых насекомых.Напишите функцию, которая принимает скорость" +
                " в км в час и возвращает ее в см в секунду, округленную до целого числа(= в меньшую сторону).Например: 1, 08-> 30");
            Console.WriteLine("Введите скорость таракана в км в час");
            double speed1 = Convert.ToDouble(Console.ReadLine());
            double speed2 = (speed1 * 100000) / 3600;
            Console.WriteLine(speed2);
        }

        public static void ex7()
        {
            string strInput = Console.ReadLine();
            StringBuilder strOutput = new StringBuilder();
            foreach (Char c in strInput.ToCharArray())
            {
                if (Char.IsLower(c))
                {
                    strOutput.Append(Char.ToUpper(c));
                }
                else
                {
                    strOutput.Append(Char.ToLower(c));
                }
            }
            Console.WriteLine(strOutput);
        }

    }
}

