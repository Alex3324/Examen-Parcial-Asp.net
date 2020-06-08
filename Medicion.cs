using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Medicion
    {
        String id;
        int milimetros;
        DateTime fecha;

        public string Id { get => id; set => id = value; }
        public int Milimetros { get => milimetros; set => milimetros = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}