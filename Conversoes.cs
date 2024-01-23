using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal static class Conversoes
    {
        public enum ConversaoTemperatura {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        public enum ConversaoDistancia {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
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

        public static double ConverterDistancias(ConversaoDistancia conversao, double distancia) {
            if(conversao == ConversaoDistancia.MetrosMilhas) {
                return distancia * 0.0006213712;
            }
            else if(conversao == ConversaoDistancia.MilhasMetros) {
                return distancia * 1609.344;
            }
            return -1;
        }
    }
}
