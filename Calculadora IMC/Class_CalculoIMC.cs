using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_IMC
{
    internal class Class_CalculoIMC
    {

        private double _peso;
        private double _altura;
        public void set_peso(double _peso)
        {
            this._peso = _peso;
        }
        public double get_peso()
        {
            return _peso;
        }
        public void set_altura(double _altura)
        {
            this._altura = _altura;
        }
        public double get_altura()
        {
            return _altura;
        }
       

       


        public double Calcular()
        {
            double peso = get_peso();
            double altura = get_altura();
            double imc = peso / (Math.Pow(altura, 2));
            return imc;
        }

        public string sit()
        {
            string situacao="";
           if(Calcular()<18.5)
            {
                situacao = "Abaixo do peso normal";

            }
           else if(Calcular()>=18.5 && Calcular() <= 24.9)
            {
                situacao = "Peso normal";
            }
            else if (Calcular() >= 25 && Calcular() <= 29.9)
            {
                situacao = "Excesso de Peso";
            }
            else if (Calcular() >= 30 && Calcular() <= 34.9)
            {
                situacao = "Obesidade classe I";
            }
            else if (Calcular() >= 35 && Calcular() <= 39.9)
            {
                situacao = "Obesidade classe II";
            }
            else if (Calcular() >= 40)
            {
                situacao = "Obesidade classe III";
            }
           return situacao;
        }
        


    }
}
