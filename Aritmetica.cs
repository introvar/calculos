﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal static class Aritmetica
    {
        public enum ConversaoTemperatura {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        public static int Somar(int x, int y) {
            return x+y;
        }
        /// Operação Subtração

        public static int Subtrair(int x, int y) {
            return x-y;
        }    

        public static int Multiplicar(int x, int y) {
            return x*y;
        }    

        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura) {
            if(conversao == ConversaoTemperatura.CelsiusFahrenheit) {
                return temperatura*1.8000 + 32;
            }
            else if(conversao == ConversaoTemperatura.FahrenheitCelsius) {
                return (temperatura-32)/1.8000;
            }
            return -1;
        }
    }
}
