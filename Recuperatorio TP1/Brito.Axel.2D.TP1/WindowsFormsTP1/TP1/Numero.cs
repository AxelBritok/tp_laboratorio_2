using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Numero
    {
        /// <summary>
        /// atributo privado de tipo double llamado numero
        /// </summary>
        private double numero;
        
        /// <summary>
        /// constructor por defecto, inicializa numero en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Sobrecargar de constructor con un string ingresando por parametro para inicializar numero
        /// </summary>
        /// <param name="numero"> numero contiene un string que puede ser un numero </param>
        public Numero(string numero)
        {
            setNumero(numero);
        }

        /// <summary>
        /// Sobrecargar de constructor con un double ingresando por parametro para inicializar numero
        /// </summary>
        /// <param name="numero">numero contiene un double para inicializar el atributo numero</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// getNumero tiene la funcion de actuar como un getter para retornar el atributo numero
        /// </summary>
        /// <returns> retorna el atributo numero</returns>
        public double getNumero()
        {
            return this.numero;
        }

        /// <summary>
        /// funcion encargada de validar un numero con el TryParse
        /// </summary>
        /// <param name="numeroString"> numero contiene un string que sera validado con el fin de que sea un numero </param>
        /// <returns> retorna el resultado de la validacion </returns>
        private double validarNumero(string numeroString)
        {
            double retorno;

            double.TryParse(numeroString, out retorno);

            return retorno;
        }

        /// <summary>
        /// la funcion se encarga de settear el atributo numero
        /// </summary>
        /// <param name="numero"> numero contiene un string que puede ser un numero </param>
        private void setNumero(string numero)
        {
            this.numero = validarNumero(numero);
        }
        /// <summary>
        /// Sobrecarga del mas
        /// </summary>
        /// <param name="n1">Numero1 a para realizar la cuenta</param>
        /// <param name="n2">Numero2 a para realizar la cuenta</param>
        /// <returns></returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1 + n2;
        }
        /// <summary>
        /// Sobrecarga de la resta
        /// </summary>
        /// <param name="n1">Numero1 a para realizar la cuenta</param>
        /// <param name="n2">Numero2 a para realizar la cuenta</param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1 - n2;
        }

        /// <summary>
        /// Sobrecarga de la multiplicacion
        /// </summary>
        /// <param name="n1">Numero1 a para realizar la cuenta</param>
        /// <param name="n2">Numero2 a para realizar la cuenta</param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1 * n2;
        }
        /// <summary>
        /// Sobrecarga de la division
        /// </summary>
        /// <param name="n1">Numero1 a para realizar la cuenta</param>
        /// <param name="n2">Numero2 a para realizar la cuenta</param>
        /// <returns></returns>
        public static double operator /(Numero n1, Numero n2)
        {
            return n1 / n2;
        }
        /// <summary>
        /// Funcion encargada de transformar un binario a decimal
        /// </summary>
        /// <param name="numero">numero a convertir</param>
        /// <returns></returns>
        public string BinarioDecimal(string numero)
        {
            int y = numero.Length;
            int binario = int.Parse(numero);
            double sumador = 0;

            for (int i = 0; i < y; i++)
            {
                int ultimo_numero = binario % 10;
                binario = binario / 10;
                if (ultimo_numero == 0 || ultimo_numero == 1)
                {
                    sumador = sumador + (Math.Pow(2, i) * ultimo_numero);
                }
                else
                {
                    
                    i = y + 1;
                    return "Valor Invalido";
                }
            }

            return sumador.ToString();
        }
        /// <summary>
        /// Funcion encargada de transformar un binario a binario
        /// </summary>
        /// <param name="numero">numero a convertir</param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {

            String cad = "";

            if (numero > 0)
            {
                
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cad = "0" + cad;
                    }
                    else
                    {
                        cad = "1" + cad;
                    }
                    numero = (int)(numero / 2);
                }
            }
            else
            {
                if (numero == 0)
                {
                    cad = "0";
                }
                else 
                {
                    cad = "Numero Invalido";
                }
            }
            
            return cad;
        }
        /// <summary>
        /// Funcion encargada de transformar un binario a binario
        /// </summary>
        /// <param name="numero">numero a convertir</param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
             return DecimalBinario(Convert.ToDouble(numero));
        }


        }
    }

