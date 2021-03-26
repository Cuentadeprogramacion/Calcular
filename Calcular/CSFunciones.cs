using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular
{
    class CSFunciones
    {
        public static int Suma(int num1,int num2)
        {
            int suma = num1 + num2;
            return (suma);
        }

        public static int Multiplicacion(int num1, int num2)
        {
            int multiplicacion = num1 * num2;
            return (multiplicacion);
        }

        public static int Division(int num1, int num2)
        {
            int multiplicacion = num1 / num2;
            return (multiplicacion);
        }
        public static int Resta(int num1, int num2)
        {
            int multiplicacion = num1 - num2;
            return (multiplicacion);
        }


        public static void MostrarResultados(int operador1, int operador2, int suma, int resta, int multiplicacion, int division)
        {
            Console.WriteLine("El número " + operador1 + " y " + operador2 + " la suma = " + suma + " la resta = " + resta + " la multiplicación = " + multiplicacion + " y la división = " + division);
        }
    }
}
