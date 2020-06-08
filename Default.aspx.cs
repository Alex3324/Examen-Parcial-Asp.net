using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        static List<Departamento> departamentos = new List<Departamento>();
        static List<Medicion> mediciones = new List<Medicion>();
        static List<Reporte> reportes = new List<Reporte>();

        protected void Page_Load(object sender, EventArgs e)
        {
            /*Postback: esta función es verdadera si la página se está recargando
             * y es falsa cuando se carga por primera vez en la ejecución */

            //El siguiente If verifica si no es PostBack entonces ejecuta el código, 
            //es decir, que lo ejecuta solo si es la primera vez que se carga la página
            //las demás veces que se recarga ya no lo vuelve a ejecutar.
            //Esta validación la tenemos que hacer porque cuando se selecciona un departamento
            //la página se vuelve a recargar para ejecutar el código asociado con la acción de seleccionar
            //aunque en nuestro caso no tengamos ningun código que se ejecute al seleccionar, pero
            //en ASP .Net siempre se hace esa recarga de la página
            //y entonces al recargarse cada vez seleccionaría al primer datos del dropdown y no
            //el dato que efectivamente habíamos seleccionado.
            if (!IsPostBack)
            {
                //Leer el archivo con mediciones cada vez que se cargue o recargue la página
                //para que la lista de mediciones siempre tenga los datos correctos
                var archivo = Server.MapPath("~/Mediciones.txt");

                FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Medicion medida = new Medicion();

                    medida.Id = reader.ReadLine();
                    medida.Milimetros = Convert.ToInt32(reader.ReadLine());
                    medida.Fecha = Convert.ToDateTime(reader.ReadLine());

                    mediciones.Add(medida);

                }

                reader.Close();
                //Leer el archivo de Departamentos cada vez que se cargue o recargue la página
                //para que la lista de departamentos este siempre con datos
                archivo = Server.MapPath("~/Departamentos.txt");

                stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Departamento deptemp = new Departamento();
                    deptemp.Id = reader.ReadLine();
                    deptemp.Nombre = reader.ReadLine();

                    departamentos.Add(deptemp);
                }

                reader.Close();

                   

                ddlDepartamento.DataValueField = "Id";
                ddlDepartamento.DataTextField = "Nombre";
                ddlDepartamento.DataSource = departamentos;
                ddlDepartamento.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var archivo = Server.MapPath("~/Mediciones.txt");

            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(ddlDepartamento.SelectedValue);
            writer.WriteLine(txtMilimetros.Text);
            writer.WriteLine(DateTime.Now.Date);
            
                        
            writer.Close();
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            

            //Recorrer todas las mediciones, y en cada una ir buscando su nombre
            //guardar los datos en la tercer lista para mostrarla
            foreach (var m in mediciones)
            {
                //buscar el id de la medición en la lista de departamentos para averiguar su nombre
                Departamento depto = departamentos.Find(d => d.Id == m.Id);

                //Crear un objeto temporal reporte e ingresarle el nombre del departamento y
                //los milimetros de la medicion
                Reporte repo = new Reporte();

                repo.Milimetros = m.Milimetros;
                repo.Nombre = depto.Nombre;

                //agregarlo a la lista de reportes
                reportes.Add(repo);

            }

            //Mostrar los reportes en el Gridview

            grvReporte.DataSource = reportes;
            grvReporte.DataBind();

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            double promedio = mediciones.Average(m => m.Milimetros);

            lblPromedio.Text = promedio.ToString();
            //lblPromedio.Visible = true;

        }
    }
}