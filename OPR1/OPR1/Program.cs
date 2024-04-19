namespace Programm
{
    class Angle
    {

        public int grad;
        public int Grad
        {
            get { return grad; }
            set
            {
                grad = value;
                while (grad >= 360)
                {
                    grad -= 360;
                }
                while (grad < 0)
                {
                    grad += 360;
                }

            }
        }
        public int min;
        public int Min
        {
            set
            {
                min= value;
                while (min >= 60)
                {
                    grad += 1;
                    min -= 60;
                }
                while(min < 0)
                {
                    grad -= 1;
                    min += 60;
                }
            }
            get { return min; }
            
        }
        public Angle()
        {
            grad = 0;
            min = 0;

        }
        public Angle(int _grad)
        {
            Grad = _grad;
        }
        public Angle(int _grad, int _min)
        {
            Grad = _grad;
            Min = _min;
        }
        public override string ToString()
        {
            return $"G {grad}; M {min}";
        }
        public double toRadians()
        {
            return ((Convert.ToDouble(grad) + 
                (Convert.ToDouble(min) / 60)) * (Math.PI / 180)) ;
        }
        public double GetSinus()
        {
            return Math.Sin(this.toRadians());
        }
        public static Angle operator +(Angle a1, int m)
        {
            return new Angle(a1.grad, a1.min + m);
        }
        public static Angle operator -(Angle a1, int m)
        {
            return new Angle(a1.grad, a1.min - m);
        }
        public static Angle operator +(Angle a1, Angle a2)
        {
            return new Angle(a1.grad + a2.grad, a1.min + a2.min);
        }
        public static Angle operator -(Angle a1, Angle a2)
        {
            return new Angle(a1.grad - a2.grad, a1.min - a2.min);
        }
        public static bool operator <(Angle a1, Angle a2)
        {
            if(a1.grad < a2.grad)
                return true;
            else if(a1.grad > a2.grad)
                return false;
            else
            {
                if (a1.min == a2.min && a1.min < a2.min)
                    return true ;
                else return false;
            }
        }
        public static bool operator >(Angle a1, Angle a2)
        {
            if (a1.grad > a2.grad)
                return true;
            else if (a1.grad < a2.grad)
                return false;
            else
            {
                if (a1.min == a2.min && a1.min > a2.min)
                    return true;
                else return false;
            }
        }
    }


    class Programm
    {
        static void Main()
        {
            Console.WriteLine("Задание 1");
            try
            {
                Angle angle = new Angle();
                Angle angle2 = new Angle();

                Console.WriteLine("Какую операцию необходимо выполнить?\n1 - Сложить" +
                   "\n2 - Вычесть\n3 - Сравнить\n4 - Перевести угол в радианы " +
                   "\n5 - Получить синус");
                string ans = Console.ReadLine();

                if (ans == "1")
                {
                    Console.WriteLine("Введите градус первого угла");
                    angle.grad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите минуты первого угла");
                    angle.min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите градус второго угла");
                    angle2.grad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите минуты второго угла");
                    angle2.min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(angle + angle2);
                }
                if (ans == "2")
                {
                    Console.WriteLine("Введите градус первого угла");
                    angle.grad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите минуты первого угла");
                    angle.min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите градус второго угла");
                    angle2.grad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите минуты второго угла");
                    angle2.min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(angle - angle2);
                }
                if (ans == "3")
                {
                    Console.WriteLine("Введите градус первого угла");
                    angle.grad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите минуты первого угла");
                    angle.min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите градус второго угла");
                    angle2.grad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите минуты второго угла");
                    angle2.min = Convert.ToInt32(Console.ReadLine());

                    if (angle > angle2) Console.WriteLine("Первый угол больше");
                    else Console.WriteLine("Второй угол больше");
                }
                if (ans == "4")
                {
                    Console.WriteLine("Введите градус угла");
                    angle.grad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите минуты угла");
                    angle.min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(angle.toRadians());
                }
                if (ans == "5")
                {
                    Console.WriteLine("Введите градус угла");
                    angle.grad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите минуты угла");
                    angle.min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(angle.GetSinus());
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message.ToString()); }
        }
    }

}
