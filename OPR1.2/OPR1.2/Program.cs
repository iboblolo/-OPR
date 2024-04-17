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
        public static bool operator <(LongLong a1, LongLong a2)
        {
            if (a1.main < a2.main)
                return true;
            else if (a1.main > a2.main)
                return false;
            else
            {
                if (a1.dop == a2.dop && a1.dop < a2.dop)
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
                if (a1.dop == a2.dop && a1.dop > a2.dop)
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

            LongLong l = new LongLong(54, 234);


            Console.WriteLine(l - 100);
            Console.WriteLine(l + 100);

            LongLong l2 = new LongLong(1);

            Console.WriteLine(l < l2);
            Console.WriteLine(l > l2);
        }
    }

}

