using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;

namespace Json
{
    public partial class _Default : Page
    {
        static List<Alumno> alumnos = new List<Alumno>();
        static List<int> Notastemp = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GuardarJsaon()
        {
            string json = JsonConvert.SerializeObject(alumnos);
            string archivo = Server.MapPath("Alumnos.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Carne = TextboxCarne.Text;
            alumno.Nombre = TextBoxNombre.Text;
            alumno.Apellido = TextBoxApellido.Text;
            alumno.Notas = Notastemp;

            alumnos.Add(alumno);

            GuardarJsaon();
            Notastemp.Clear();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int notaTemp = Convert.ToInt16(TextBoxNota.Text);
            Notastemp.Add(notaTemp);
            GridView1.DataSource = Notastemp;
            GridView1.DataBind();
        }
    }
}