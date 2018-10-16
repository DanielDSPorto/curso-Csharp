using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    class Rectangle
    {
        public Rectangle(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }
        public double largura
        {
            get; set;
        }

        public double altura
        {
            get; set;
        }

        public double area()
        {
            return this.largura * this.altura;
        }
        public double perimetro()
        {
            return 2 * (this.largura + this.altura);
        }
        public double diagonal()
        {
            return Math.Sqrt(Math.Pow(this.largura, 2) + Math.Pow(this.altura, 2));
        }

        public void print()
        {
            Console.WriteLine(string.Format("a altura do triangulo em questão é {0} e a largura é {1}. Sua área é {2}, seu perímetro é {3} e sua diagonal vale {4}",altura.ToString("F2"),
                largura.ToString("F2"),area().ToString("F2"),perimetro().ToString("F2"),diagonal().ToString("F2")));
        }
    }


}
