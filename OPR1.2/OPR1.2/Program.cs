namespace Programm
{
    class LongLong
    {

        public long main;
        public long Main
        {
            get { return main; }
            set
            {
                main = value;
            }
        }
        public ulong dop;
        public ulong Dop
        {
            set
            {
                dop = value;
            }
            get { return dop; }
        }
        public LongLong()
        {
            main = 0;
            dop = 0;
        }
        public LongLong(long _grad)
        {
            Main = _grad;
        }
        public LongLong(long _grad, ulong _min)
        {
            Main = _grad;
            Dop = _min;
        }
        public override string ToString()
        {
            return $"M {main}; D {dop}";
        }
        public static LongLong operator +(LongLong a1, ulong m)
        {
            return new LongLong(a1.main, a1.dop + m);
        }
        public static LongLong operator -(LongLong a1, ulong m)
        {
            return new LongLong(a1.main, a1.dop - m);
        }
        public static LongLong operator +(LongLong a1, LongLong a2)
        {
            return new LongLong(a1.main + a2.main, a1.dop + a2.dop);
        }
        public static LongLong operator -(LongLong a1, LongLong a2)
        {
            return new LongLong(a1.main - a2.main, a1.dop - a2.dop);
        }
        public static LongLong operator *(LongLong a1, LongLong a2)
        {
            return new LongLong(a1.main * a2.main, a1.dop * a2.dop);
        }
        public static LongLong operator /(LongLong a1, LongLong a2)
        {
            return new LongLong(a1.main / a2.main, a1.dop / a2.dop);
        }
        public static bool operator <(LongLong a1, LongLong a2)
        {
            if (a1.main < a2.main)
                return true;
            else if (a1.main > a2.main)
                return false;
            else
            {
                if (a1.main == a2.main && a1.dop < a2.dop)
                    return true;
                else return false;
            }
        }
        public static bool operator >(LongLong a1, LongLong a2)
        {
            if (a1.main > a2.main)
                return true;
            else if (a1.main < a2.main)
                return false;
            else
            {
                if (a1.main == a2.main && a1.dop > a2.dop)
                    return true;
                else return false;
            }
        }
    }


    class Programm
    {
        static void Main()
        {
            Console.WriteLine("Задание 2");

            LongLong l = new LongLong();

            LongLong l2 = new LongLong();

            Console.WriteLine("Какую операцию необходимо выполнить?\n1 - Сложить" +
                   "\n2 - Вычесть\n3 - Умножить\n4 - Разделить " +
                   "\n5 - Сравнить");
            string ans = Console.ReadLine();

            try
            {
                if (ans == "1")
                {
                    Console.WriteLine("Введите главную часть первого LongLong");
                    l.main = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Введите дополнительную часть первого LongLong");
                    l.dop = Convert.ToUInt64(Console.ReadLine());

                    Console.WriteLine("Введите главную часть второго LongLong");
                    l2.main = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Введите дополнительную часть второго LongLong");
                    l2.dop = Convert.ToUInt64(Console.ReadLine());

                    Console.WriteLine(l + l2);
                }
                if (ans == "2")
                {
                    Console.WriteLine("Введите главную часть первого LongLong");
                    l.main = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Введите дополнительную часть первого LongLong");
                    l.dop = Convert.ToUInt64(Console.ReadLine());

                    Console.WriteLine("Введите главную часть второго LongLong");
                    l2.main = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Введите дополнительную часть второго LongLong");
                    l2.dop = Convert.ToUInt64(Console.ReadLine());

                    Console.WriteLine(l - l2);
                }
                if (ans == "3")
                {
                    Console.WriteLine("Введите главную часть первого LongLong");
                    l.main = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Введите дополнительную часть первого LongLong");
                    l.dop = Convert.ToUInt64(Console.ReadLine());

                    Console.WriteLine("Введите главную часть второго LongLong");
                    l2.main = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Введите дополнительную часть второго LongLong");
                    l2.dop = Convert.ToUInt64(Console.ReadLine());

                    Console.WriteLine(l * l2);
                }
                if (ans == "4")
                {
                    Console.WriteLine("Введите главную часть первого LongLong");
                    l.main = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Введите дополнительную часть первого LongLong");
                    l.dop = Convert.ToUInt64(Console.ReadLine());

                    Console.WriteLine("Введите главную часть второго LongLong");
                    l2.main = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Введите дополнительную часть второго LongLong");
                    l2.dop = Convert.ToUInt64(Console.ReadLine());

                    Console.WriteLine(l / l2);
                }
                if (ans == "5")
                {
                    Console.WriteLine("Введите главную часть первого LongLong");
                    l.main = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Введите дополнительную часть первого LongLong");
                    l.dop = Convert.ToUInt64(Console.ReadLine());

                    Console.WriteLine("Введите главную часть второго LongLong");
                    l2.main = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Введите дополнительную часть второго LongLong");
                    l2.dop = Convert.ToUInt64(Console.ReadLine());

                    if (l > l2) Console.WriteLine("Первый больше");
                    else Console.WriteLine("Второй больше");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}

