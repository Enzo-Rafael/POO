using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAreas
{
    class AreaPerimetro
    {
        //Retângulo
        public double AreaRetangulo(double valorBase, double valorAltura)
        {
            return valorBase * valorAltura;
        }

        public double PerimetroRetangulo(double valorBase, double ValorAltura)
        {
            return (2 * valorBase + 2 * ValorAltura);
        }

        //Quadrado
        public double AreaQuadrado(double lado)
        {
            return lado * lado;
        }

    public double PerimetroQuadrado(double lado)
        {
            return lado * 4;
        }

        //Triângulo
        public double AreaTriangulo(double valorBase, double valorAltura)
        {
            return (valorBase * valorAltura) / 2;
        }

        public double PerimetroTriangulo(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 + lado3;
        }

        //Trapézio

        public double AreaTrapezio(double BaseMaior, double BaseMenor, double Altura)
        {
            return (BaseMenor + BaseMaior) * Altura / 2;    
        }

        public double PerimetroTrapezio(double lado1, double lado2, double lado3, double lado4)
        {
            return lado1 + lado2 + lado3 + lado4;
        }
    }
}
