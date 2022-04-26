using System;

namespace App2021
{
    internal class ContasNumericas
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public int Somar()
        {
            return Numero1 + Numero2;
        }
        public int Subtrair()
        {
            return Numero1 - Numero2;
        }
        public double Mutiplicar()
        {
            return Numero1 * Numero2;
        }
        public double Dividir()
        {
            return Numero1 / Numero2;
        }
    }
}