using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Reporte
    {
        string nombre;
        int milimetros;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Milimetros { get => milimetros; set => milimetros = value; }
    }
}