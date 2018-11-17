using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Excepcion : Exception
    {
        public Excepcion(String msgError) : base(msgError)
        {
        }
    }
}