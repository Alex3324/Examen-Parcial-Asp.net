using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Departamento
    {
        string id;
        string nombre;

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}