using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Aritmetica
    {
        public enum ConversaoTemperatura {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        public int Somar(int x, int y) {
            return x+y;
        }
        /// Operação Subtração

        public int Subtrair(int x, int y) {
            return x-y;
        }    

        public int Multiplicar(int x, int y) {
            return x*y;
        }    

        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura) {
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
