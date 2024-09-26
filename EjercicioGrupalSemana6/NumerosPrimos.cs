using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EjercicioGrupalSemana6
{
    public class NumerosPrimos
    {
        public object[] CalculosPrimos(int empezar, int terminar)
        {
            Stopwatch instanteX = new Stopwatch();
            instanteX.Start();

            int cantidadPrimos = 0;
            var primos = new List<int>();

            for (int num = empezar; num <= terminar; num++)
            {
                if (EsPrimo(num))
                {
                    primos.Add(num);
                    cantidadPrimos++;
                }
            }

            instanteX.Stop();
            double resultadoDeDemora = (double)instanteX.ElapsedTicks / Stopwatch.Frequency * 1000; // Milisegundos
            return new object[] { primos.ToArray(), cantidadPrimos, resultadoDeDemora };
        }

        private bool EsPrimo(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
    }
}
