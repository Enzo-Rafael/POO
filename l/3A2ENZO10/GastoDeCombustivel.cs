using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A2ENZO10
{
    class GastoDeCombustivel
    {
        public double Metade(double S1, double S2, double S3, double S4)

        {
            return (S1 + S2 + S3 + S4) / 4;
        } 
        public double Km(int KM) 
        {
            return 10000 - KM;        
        }
         public double IPVP(double Pessoa)
        {
            return Pessoa * 0.04;
        }
        public double IPVC(double Caixa)
        {
            return Caixa * 0.03;
        }
        public double IPVTP(double Lotado)
        {
            return Lotado * 0.02;
        }

    }


}
