﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException : Exception
    {

        private static string message = "No hay profesor para la clase.";

        public SinProfesorException()
            : base(SinProfesorException.message)
        {

        }

    }

}