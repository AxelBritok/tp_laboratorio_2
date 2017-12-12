using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.ComponentModel;

namespace Hilo
{
    public class Descargador
    {
        
        public delegate void Porciento(int porciento);
        public delegate void FinDeLaDescarga(string html);

        
        public event Porciento Porcentaje;
        public event FinDeLaDescarga DescargaFinalizada;


        private string html;
        private Uri direccion;


        /// <summary>
        /// Constructor del descargador
        /// </summary>
        /// <param name="direccion"></param>
        public Descargador(Uri direccion)
        {
            this.html = "";
            this.direccion = direccion;
        }

        public void IniciarDescarga()
        {
            try
            {
                WebClient cliente = new WebClient();
                cliente.DownloadProgressChanged += this.WebClientDownloadProgressChanged;
                cliente.DownloadStringCompleted += this.WebClientDownloadCompleted;

                cliente.DownloadStringAsync(this.direccion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Porcentaje(e.ProgressPercentage);
        }
        private void WebClientDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            this.html = e.Result;
            this.DescargaFinalizada(this.html);
        }
    }
}
