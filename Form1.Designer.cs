namespace GUI_JAM
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.textBoxFsoNumber = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionTrabajo = new System.Windows.Forms.TextBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxWell = new System.Windows.Forms.TextBox();
            this.textBoxRepresentante = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.timePickerHora = new System.Windows.Forms.DateTimePicker();
            this.textBoxRig = new System.Windows.Forms.TextBox();
            this.textBoxCreadoPor = new System.Windows.Forms.TextBox();
            this.textBoxTecnico1 = new System.Windows.Forms.TextBox();
            this.textBoxTecnico2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(12, 12);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 0;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Location = new System.Drawing.Point(93, 12);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(75, 23);
            this.buttonExportar.TabIndex = 1;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // textBoxFsoNumber
            // 
            this.textBoxFsoNumber.Location = new System.Drawing.Point(12, 41);
            this.textBoxFsoNumber.Name = "textBoxFsoNumber";
            this.textBoxFsoNumber.Size = new System.Drawing.Size(156, 23);
            this.textBoxFsoNumber.TabIndex = 2;
            // 
            // textBoxDescripcionTrabajo
            // 
            this.textBoxDescripcionTrabajo.Location = new System.Drawing.Point(12, 70);
            this.textBoxDescripcionTrabajo.Name = "textBoxDescripcionTrabajo";
            this.textBoxDescripcionTrabajo.Size = new System.Drawing.Size(156, 23);
            this.textBoxDescripcionTrabajo.TabIndex = 3;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(12, 99);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(156, 23);
            this.textBoxCliente.TabIndex = 4;
            // 
            // textBoxWell
            // 
            this.textBoxWell.Location = new System.Drawing.Point(12, 128);
            this.textBoxWell.Name = "textBoxWell";
            this.textBoxWell.Size = new System.Drawing.Size(156, 23);
            this.textBoxWell.TabIndex = 5;
            // 
            // textBoxRepresentante
            // 
            this.textBoxRepresentante.Location = new System.Drawing.Point(12, 157);
            this.textBoxRepresentante.Name = "textBoxRepresentante";
            this.textBoxRepresentante.Size = new System.Drawing.Size(156, 23);
            this.textBoxRepresentante.TabIndex = 6;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(12, 186);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(156, 23);
            this.dateTimePickerFecha.TabIndex = 7;
            // 
            // timePickerHora
            // 
            this.timePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerHora.Location = new System.Drawing.Point(12, 215);
            this.timePickerHora.Name = "timePickerHora";
            this.timePickerHora.Size = new System.Drawing.Size(156, 23);
            this.timePickerHora.TabIndex = 8;
            // 
            // textBoxRig
            // 
            this.textBoxRig.Location = new System.Drawing.Point(12, 244);
            this.textBoxRig.Name = "textBoxRig";
            this.textBoxRig.Size = new System.Drawing.Size(156, 23);
            this.textBoxRig.TabIndex = 9;
            // 
            // textBoxCreadoPor
            // 
            this.textBoxCreadoPor.Location = new System.Drawing.Point(12, 273);
            this.textBoxCreadoPor.Name = "textBoxCreadoPor";
            this.textBoxCreadoPor.Size = new System.Drawing.Size(156, 23);
            this.textBoxCreadoPor.TabIndex = 10;
            // 
            // textBoxTecnico1
            // 
            this.textBoxTecnico1.Location = new System.Drawing.Point(12, 302);
            this.textBoxTecnico1.Name = "textBoxTecnico1";
            this.textBoxTecnico1.Size = new System.Drawing.Size(156, 23);
            this.textBoxTecnico1.TabIndex = 11;
            // 
            // textBoxTecnico2
            // 
            this.textBoxTecnico2.Location = new System.Drawing.Point(12, 331);
            this.textBoxTecnico2.Name = "textBoxTecnico2";
            this.textBoxTecnico2.Size = new System.Drawing.Size(156, 23);
            this.textBoxTecnico2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.textBoxTecnico2);
            this.Controls.Add(this.textBoxTecnico1);
            this.Controls.Add(this.textBoxCreadoPor);
            this.Controls.Add(this.textBoxRig);
            this.Controls.Add(this.timePickerHora);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.textBoxRepresentante);
            this.Controls.Add(this.textBoxWell);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.textBoxDescripcionTrabajo);
            this.Controls.Add(this.textBoxFsoNumber);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonLimpiar);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.TextBox textBoxFsoNumber;
        private System.Windows.Forms.TextBox textBoxDescripcionTrabajo;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxWell;
        private System.Windows.Forms.TextBox textBoxRepresentante;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.DateTimePicker timePickerHora;
        private System.Windows.Forms.TextBox textBoxRig;
        private System.Windows.Forms.TextBox textBoxCreadoPor;
        private System.Windows.Forms.TextBox textBoxTecnico1;
        private System.Windows.Forms.TextBox textBoxTecnico2;
    }
}
