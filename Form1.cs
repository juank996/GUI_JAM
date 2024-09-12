using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GUI_JAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código adicional para inicializar el formulario, si es necesario
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Código para limpiar los campos del formulario
            textBoxFsoNumber.Clear();
            textBoxDescripcionTrabajo.Clear();
            textBoxCliente.Clear();
            textBoxWell.Clear();
            textBoxRepresentante.Clear();
            dateTimePickerFecha.Value = DateTime.Now;
            timePickerHora.Value = DateTime.Now;
            textBoxRig.Clear();
            textBoxCreadoPor.Clear();
            textBoxTecnico1.Clear();
            textBoxTecnico2.Clear();
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            // Código para exportar datos a Excel y PDF
            // Aquí deberás implementar la lógica específica para exportar los datos.
            string fsoNumber = textBoxFsoNumber.Text;
            string descripcionTrabajo = textBoxDescripcionTrabajo.Text;
            string cliente = textBoxCliente.Text;
            string well = textBoxWell.Text;
            string representante = textBoxRepresentante.Text;
            string fecha = dateTimePickerFecha.Value.ToString("yyyy-MM-dd");
            string hora = timePickerHora.Value.ToString("HH:mm");
            string rig = textBoxRig.Text;
            string creadoPor = textBoxCreadoPor.Text;
            string tecnico1 = textBoxTecnico1.Text;
            string tecnico2 = textBoxTecnico2.Text;

            // Aquí deberás implementar la lógica para crear y llenar el archivo Excel
            // y luego convertirlo a PDF. Usa las librerías adecuadas que has instalado.

            // Ejemplo (deberás ajustar según tu lógica):
            // string excelPath = ExportarAExcel(fsoNumber, descripcionTrabajo, cliente, well, representante, fecha, hora, rig, creadoPor, tecnico1, tecnico2);
            // ExportarAPDF(excelPath);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.ComponentModel.IContainer components = null;

        // Métodos para exportar a Excel y PDF (deberás implementar estos métodos)
        private string ExportarAExcel(string fsoNumber, string descripcionTrabajo, string cliente, string well, string representante, string fecha, string hora, string rig, string creadoPor, string tecnico1, string tecnico2)
        {
            // Implementa aquí la lógica para exportar a Excel
            // Esta función debe devolver la ruta del archivo Excel creado
            throw new NotImplementedException();
        }

        private void ExportarAPDF(string excelPath)
        {
            // Implementa aquí la lógica para convertir el archivo Excel a PDF
            throw new NotImplementedException();
        }
    }
}
