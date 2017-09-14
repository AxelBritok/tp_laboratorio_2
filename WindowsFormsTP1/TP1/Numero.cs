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
        
    }
}
