namespace Programm
{
    class Programm
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите грани треугольника");
                int[] edges = new int[3];
                for (int i = 0; i < edges.Length; i++)
                {
                    edges[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Введите углы треугольника");
                int[] angles = new int[3];
                for (int i = 0; i < angles.Length; i++)
                {
                    angles[i] = Convert.ToInt32(Console.ReadLine());
                }
                Triangle t = new Triangle(edges, angles);

                Console.WriteLine("Введите грани для равнобедренного трегольника");

                int[] edges2 = new int[3];
                for (int i = 0; i < edges.Length; i++)
                {
                    edges2[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Введите углы для равнобедренного трегольника");
                int[] angles2 = new int[3];
                for (int i = 0; i < angles.Length; i++)
                {
                    angles2[i] = Convert.ToInt32(Console.ReadLine());
                }
                IsoscelesTriangle it = new IsoscelesTriangle(edges2, angles2);

                Console.WriteLine("Введите грани для прямоугольного трегольника");

                int[] edges5 = new int[3];
                for (int i = 0; i < edges.Length; i++)
                {
                    edges5[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Введите углы для прямоугольного трегольника");
                int[] angles5 = new int[3];
                for (int i = 0; i < angles.Length; i++)
                {
                    angles5[i] = Convert.ToInt32(Console.ReadLine());
                }
                RightAngledTriangle rt = new RightAngledTriangle(edges5, angles5);

                Console.WriteLine("Введите сторону для равностороннего треугольника");

                int edge = Convert.ToInt32(Console.ReadLine());

                EquilateralTriangle et = new EquilateralTriangle(edge);

                Console.WriteLine("Введите грани для четырёхугольника");

                int[] edges3 = new int[4];
                for (int i = 0; i < edges3.Length; i++)
                {
                    edges3[i] = Convert.ToInt32(Console.ReadLine());
                }


                Console.WriteLine("Введите углы для четырёхугольника");
                int[] angles3 = new int[4];
                for (int i = 0; i < angles3.Length; i++)
                {
                    angles3[i] = Convert.ToInt32(Console.ReadLine());
                }
                Quadrilateral q = new Quadrilateral(edges3, angles3);

                Console.WriteLine("Введите сторону для квадрата");

                int edge2 = Convert.ToInt32(Console.ReadLine());

                Square sq = new Square(edge2);

                List<GeometryFigure> list = new List<GeometryFigure>()
            {
                t,
                it,
                rt,
                et,
                q,
                sq
            };
                foreach (GeometryFigure f in list)
                {
                    Console.WriteLine(f.Area().ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }

    abstract class GeometryFigure
    {
        protected int angCount;
        protected int edgeCount;
        protected int[] edges;
        protected int[] angles;

        public abstract double Area();
    }
    class Triangle : GeometryFigure
    {
        public Triangle(int[] _edges, int[] _angles)
        {
            angCount = 3;
            edgeCount = 3;

            edges = _edges;
            angles = _angles;

            if(angles.Length != angCount) 
            {
                Console.WriteLine("Неверное число углов для треугольника");
                throw new Exception("Неверное число углов для треугольника");
            }
                
            if (edges.Length != edgeCount)
            {
                Console.WriteLine("Неверное число граней для треугольника");
                throw new Exception("Неверное число граней для треугольника");
            }
            if(angles.Sum() != 180) 
            {
                Console.WriteLine("Сумма углов треугольника должна быть равна 180");
                throw new Exception("Неверное число углов для треугольника");
            }

            if (edges[0] + edges[1] < edges[2] || edges[0] + edges[2] < edges[1]
                || edges[1] + edges[2] < edges[0]) 
            {
                Console.WriteLine("Сумма 2х сторон треугольника должна быть больше, чем последняя сторона");
                throw new Exception("Сумма 2х сторон треугольника должна быть больше, чем последняя сторона");
            }

        }
        public override double Area()
        {
            double p = Convert.ToDouble(edges.Sum()) / 2;
            return Math.Sqrt(p * (p - edges[0]) * (p - edges[1]) * (p - edges[2]));
        }
    }
    class IsoscelesTriangle : Triangle 
    {
        public IsoscelesTriangle(int[] _edges, int[] _angles) : base(_edges, _angles)
        {
            if (angles[0] != angles[1] && angles[0] != angles[2]
                && angles[1] != angles[2])
            {
                Console.WriteLine("В равнобедренном треугольнике хотя бы 2 угла должны быть равны");
                throw new Exception("В равнобедренном треугольнике хотя бы 2 угла должны быть равны");
            }
            if (edges[0] != edges[1] && edges[0] != edges[2]
                && edges[1] != edges[2])
            {
                Console.WriteLine("В равнобедренном треугольнике хотя бы 2 стороны должны быть равны");
                throw new Exception("В равнобедренном треугольнике хотя бы 2 стороны должны быть равны");
            }
        }
    }
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(int _edge) : base([_edge, _edge, _edge], [60, 60, 60])
        {
        }
    }
    
    class RightAngledTriangle : Triangle
    {
        public RightAngledTriangle(int[] _edges, int[] _angles) : base(_edges, _angles)
        {
            if (angles[0] != 90 && angles[1] != 90
                && angles[2] != 90)
            {
                Console.WriteLine("В прямоугольном треугольнике хотя бы 1 угол дожен быть 90 градусов");
                throw new Exception("В прямоугольном треугольнике хотя бы 1 угол дожен быть 90 градусов");
            }
        }
    }

    class Quadrilateral : GeometryFigure
    {
        public Quadrilateral(int[] _edges, int[] _angles)
        {
            angCount = 4;
            edgeCount = 4;

            edges = _edges;
            angles = _angles;

            if (angles.Length != angCount)
                Console.WriteLine("Неверное число углов для четырёхугольника");
            if (edges.Length != edgeCount)
                Console.WriteLine("Неверное число граней для четырёхугольника");
            if (angles.Sum() != 360)
            {
                Console.WriteLine("Сумма углов четырёхугольника должна быть равна 360");
                throw new Exception("Сумма углов четырёхугольника должна быть равна 360");
            }
        }
        public override double Area()
        {
            double p = Convert.ToDouble(edges.Sum()) / 2;

            return Math.Sqrt((p - edges[0]) * (p - edges[1]) * (p - edges[2]) * (p - edges[3]) 
                -( edges[0] * edges[1] * edges[2] * edges[3]) * Math.Cos(Math.PI * ((angles[0] + angles[2])/2) / 180) 
                * Math.Cos(Math.PI * ((angles[0] + angles[2]) / 2) / 180));
        }
    }

    class Square : Quadrilateral
    {
        public Square(int _edge): base([_edge , _edge , _edge  , _edge], [90, 90, 90, 90])
        {
        }
    }

}
