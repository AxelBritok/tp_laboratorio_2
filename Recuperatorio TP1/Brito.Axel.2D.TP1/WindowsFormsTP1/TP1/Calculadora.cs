using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Calculadora
    {
        /// <summary>
        /// operar tiene la funcion de realizar operaciones de suma, resta, multiplicacion y division.
        /// </summary>
        /// <param name="numero1"> numero1 es uno de los operadores para realizar las operaciones </param>
        /// <param name="numero2"> numero2 es el otro numero operador para realizar las operaciones </param>
        /// <param name="operador"> operador es el signo que dira de que tipo sera la operacion </param>
        /// <returns> return retornara la variable retorno que contiene el resultado de la operacion </returns>
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double retorno = 0;

            switch (operador)
            {
                
                case "-":
                    retorno = numero1.getNumero() - numero2.getNumero();
                    break;
                case "*":
                    retorno = numero1.getNumero() * numero2.getNumero();
                    break;
                case "/":
                    if (numero2.getNumero() == 0)
                    {
                        retorno = 0;
                        break;
                    }
                    else
                    {
                        retorno = numero1.getNumero() / numero2.getNumero();
                        break;
                    }
                default:
                        retorno = numero1.getNumero() + numero2.getNumero();
                    break;

            }

            return retorno;
        }


        /// <summary>
        /// validarOperador tiene la funcion de validar un operador para que no tenga acceso cualquier string.
        /// </summary>
        /// <param name="operador"> El parametro operador traera un string que sera validado  </param>
        /// <returns> return retornara la variable retorno que varia entre "+" o operador dependiendo del if o else</returns>
        public static string validarOperador(string operador)
        {
            string retorno;

            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                retorno = "+";
            }
            else
            {
                retorno = operador;
            }

            return retorno;
        }

    }
}
