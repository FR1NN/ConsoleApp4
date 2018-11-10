using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    abstract class Figure
    {
        public string Type { get; protected set; }

        public abstract float Square();

        public override string ToString()
        {
            return this.Type + " площадью " + this.Square().ToString();
        }
    }

    class Rectangle : Figure, IPrint
    {
        public float width { get; set; }
        public float height { get; set; }

        public override float Square()
        {
            return width * height;
        }

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
            this.Type = "Прямоугольник";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Quadre : Rectangle, IPrint
    {
        public Quadre(float width) : base(width, width)
        {
            this.Type = "Квадрат";
        }
    }

    class Circle : Figure, IPrint
    {
        public float r { get; set; }

        public Circle(float r)
        {
            this.r = r;
            this.Type = "Круг";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString()); ;
        }

        public override float Square()
        {
            return 3.1415926535f * r * r;
        }
    }

    interface IPrint
    {
        void Print();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle_1 = new Rectangle(2, 6);
            Quadre quadre_1 = new Quadre(8);
            Circle circle_1 = new Circle(10);

            rectangle_1.Print();
            quadre_1.Print();
            circle_1.Print();

            Console.ReadKey();

        }
    }
}
