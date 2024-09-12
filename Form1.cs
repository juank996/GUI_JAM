using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

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
          // Declaración de componentes
          private ComboBox cbCabezal, cbCliente, cbLocacion, cbCreadoPor;
          private TextBox txtRIG, txtWELL, txtHora, txtTecnicos, txtDescripcion, txtRepresentante, txtFSO;
          private Label lblPlantillaStatus;
          private PictureBox pbPreview;
          private DateTimePicker dtpFecha;
          private Button btnLimpiar, btnExportar;
          private CheckBox cbDarkMode, cbSoloCaratula;
        }
        public MainForm()
        {
            InitializeComponent();
            this.Size = new Size(1280, 720);
            this.MinimumSize = new Size(1280, 720);
            this.MaximumSize = new Size(1920, 1080);
            this.Text = "GUI JAM - Llenado de Plantillas";
            this.BackColor = Color.FromArgb(45, 45, 48);  // Dark mode por defecto

            InitializeUI();
        }

        private void InitializeUI()
        {
            // Texto "Caract. Especiales" con los switches
            Label lblCaractEspeciales = new Label()
            {
                Text = "Caract. Especiales",
                Location = new Point(20, 20),
                AutoSize = true,
                ForeColor = Color.White
            };
            this.Controls.Add(lblCaractEspeciales);

            // Switch de Dark/Light Mode
            cbDarkMode = new CheckBox()
            {
                Text = "Dark",
                Location = new Point(150, 20),
                ForeColor = Color.White,
                AutoSize = true,
                Checked = true
            };
            cbDarkMode.CheckedChanged += new EventHandler(ToggleDarkMode);
            this.Controls.Add(cbDarkMode);

            // Switch "Solo Caratula"
            cbSoloCaratula = new CheckBox()
            {
                Text = "Solo Carátula",
                Location = new Point(250, 20),
                ForeColor = Color.White,
                AutoSize = true
            };
            this.Controls.Add(cbSoloCaratula);

            // Texto "Tipo de cabezal"
            Label lblTipoCabezal = new Label()
            {
                Text = "Tipo de cabezal",
                Location = new Point(20, 60),
                AutoSize = true,
                ForeColor = Color.White
            };
            this.Controls.Add(lblTipoCabezal);

            // ComboBox para cabezal
            cbCabezal = new ComboBox()
            {
                Location = new Point(150, 60),
                Width = 200
            };
            cbCabezal.Items.AddRange(new string[] { "Cabezal Hibrido", "Cabezal Robusto", "Cabezal CFB", "Cabezal HES", "BPV.Lub", "BPV.Lub Seccion C", "BPV.Lub Seccion C & T" });
            this.Controls.Add(cbCabezal);

            // Label para el estado de la plantilla
            lblPlantillaStatus = new Label()
            {
                Text = "Plantilla no disponible",
                Location = new Point(20, 100),
                AutoSize = true,
                ForeColor = Color.White,
                BackColor = Color.Red,
                Width = 300
            };
            this.Controls.Add(lblPlantillaStatus);

            // PictureBox para la vista previa
            pbPreview = new PictureBox()
            {
                Location = new Point(400, 20),
                Size = new Size(200, 200),
                ImageLocation = "C:/Users/jc11r/Desktop/GUI_JAM/previews/Empty.jpg",
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            this.Controls.Add(pbPreview);

            // Comboboxes y Entryboxes
            CreateLabeledTextBox("Cliente", ref cbCliente, new string[] { "", "YPF", "SHELL" }, 20, 140);
            CreateLabeledTextBox("RIG", ref txtRIG, 20, 180);
            CreateLabeledTextBox("WELL", ref txtWELL, 20, 220);

            // DateTimePicker para la fecha solicitada
            Label lblFechaSolicitada = new Label()
            {
                Text = "Fecha solicitada",
                Location = new Point(20, 260),
                AutoSize = true,
                ForeColor = Color.White
            };
            this.Controls.Add(lblFechaSolicitada);
            dtpFecha = new DateTimePicker()
            {
                Format = DateTimePickerFormat.Short,
                Location = new Point(150, 260)
            };
            this.Controls.Add(dtpFecha);

            // EntryBox para la hora solicitada
            CreateLabeledTextBox("Hora solicitada", ref txtHora, 20, 300);

            // TextBox para los técnicos
            CreateLabeledTextBox("Tecnicos", ref txtTecnicos, 20, 340);

            // TextBox para la descripción del trabajo
            CreateLabeledTextBox("Descripción del trabajo", ref txtDescripcion, 20, 380, width: 300, multiline: true);

            // TextBox para el representante
            CreateLabeledTextBox("Representante", ref txtRepresentante, 20, 460);

            // Combobox para locación
            CreateLabeledTextBox("Locación", ref cbLocacion, new string[] { "", "Añelo", "Río Neuquén" }, 20, 500);

            // EntryBox para FSO
            Label lblFSO = new Label()
            {
                Text = "FSO",
                Location = new Point(20, 540),
                AutoSize = true,
                ForeColor = Color.White
            };
            this.Controls.Add(lblFSO);
            Label lblFSOPrefix = new Label()
            {
                Text = "000-",
                Location = new Point(150, 540),
                AutoSize = true,
                ForeColor = Color.White
            };
            this.Controls.Add(lblFSOPrefix);
            txtFSO = new TextBox()
            {
                Location = new Point(190, 540),
                Width = 60,
                MaxLength = 4
            };
            this.Controls.Add(txtFSO);

            // Combobox para "Creado por"
            CreateLabeledTextBox("Creado por", ref cbCreadoPor, new string[] { "", "Balacero", "Bart S", "Moledor" }, 20, 580);

            // Botón Limpiar
            btnLimpiar = new Button()
            {
                Text = "Limpiar",
                Location = new Point(400, 600),
                Width = 100
            };
            btnLimpiar.Click += BtnLimpiar_Click;
            this.Controls.Add(btnLimpiar);

            // Botón Exportar
            btnExportar = new Button()
            {
                Text = "Exportar",
                Location = new Point(520, 600),
                Width = 100
            };
            btnExportar.Click += BtnExportar_Click;
            this.Controls.Add(btnExportar);
        }

        // Método para crear etiquetas y textboxes
        private void CreateLabeledTextBox(string labelText, ref TextBox textBox, int x, int y, int width = 200, bool multiline = false)
        {
            Label label = new Label()
            {
                Text = labelText,
                Location = new Point(x, y),
                AutoSize = true,
                ForeColor = Color.White
            };
            this.Controls.Add(label);

            textBox = new TextBox()
            {
                Location = new Point(150, y),
                Width = width,
                Multiline = multiline
            };
            this.Controls.Add(textBox);
        }

        // Método para crear etiquetas y comboboxes
        private void CreateLabeledTextBox(string labelText, ref ComboBox comboBox, string[] items, int x, int y)
        {
            Label label = new Label()
            {
                Text = labelText,
                Location = new Point(x, y),
                AutoSize = true,
                ForeColor = Color.White
            };
            this.Controls.Add(label);

            comboBox = new ComboBox()
            {
                Location = new Point(150, y),
                Width = 200
            };
            comboBox.Items.AddRange(items);
            this.Controls.Add(comboBox);
        }

        // Eventos de los botones
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            // Lógica para limpiar todos los campos
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            // Lógica para exportar la información a Excel y PDF
        }

        private void ToggleDarkMode(object sender, EventArgs e)
        {
            // Lógica para alternar entre modo Dark y Light
        }
    }
}
