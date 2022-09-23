using System;

namespace Tumakov
{
    class Tumakov
    {
        static void Main(string[] args)
        {
            ex1();
        }
        enum Account : int
        {
            Current = 400000,
            Saving = 6000
        }
        public static void ex1()
        {
            Console.WriteLine("Создать перечислимый тип данных, отображающий виды банковского счета (текущий и сберегательный). Создать " +
                "переменную типа перечисления, присвоить ей значение и вывести это значение на печать");

            Console.WriteLine("Значение текущего счета: ");
            Console.WriteLine((int)Tumakov.Account.Current);
            Console.WriteLine("Значение сберегательного счета: ");
            Console.WriteLine((int)Tumakov.Account.Saving);
        }
        public static void ex2()
        {
            Console.WriteLine("Cоздать структуру данных, которая хранит информацию о банковском счете - его номер, тип и баланс. " +
                    "Создать переменную такого типа, заполнить структуру значениями и напечатать результат");
            Accountstruct newaccount;
            newaccount.number = "5536 8422 8834 5673";
            newaccount.type = "current";
            newaccount.balance = 33456.82;

            Console.WriteLine("Номер счета: " + newaccount.number);
            Console.WriteLine("Тип счета: " + newaccount.type);
            Console.WriteLine("Баланс счета: " + newaccount.balance);


        }

        public struct Accountstruct
        {
            public string number;
            public string type;
            public double balance;
        }

        public static void ex3()
        {
            Console.WriteLine("Создать перечислимый тип ВУЗ. Создать структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру " +
                "данными и распечатать");
            Employee newEmployee;
            newEmployee.firstName = Console.ReadLine();




        }

        enum Uni
        {
            КФУ,
            КАИ,
            КХТИ
        }

        public struct Employee
        {
            public string firstName;
            public int Uni;
        }
    }
}
