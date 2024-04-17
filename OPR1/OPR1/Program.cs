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
            return ((grad + (min / 60)) * (3.14 / 180)) ;
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


            Angle angle = new Angle(366, 151);
            Console.WriteLine(angle);

            Console.WriteLine(angle.toRadians());

            Angle t = angle - 100;
            Console.WriteLine(t);

            Console.WriteLine(angle > angle - 100);
            Console.WriteLine(angle > angle + 100);
            Console.WriteLine(angle < angle - 100);
            Console.WriteLine(angle < angle + 100);
            Console.WriteLine(angle.GetSinus());

        }
    }

}
