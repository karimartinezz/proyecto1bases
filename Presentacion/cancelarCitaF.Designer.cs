namespace Presentacion
{
    partial class cancelarCitaF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.cedulaFuncionario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MMMM-dd  |  HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(434, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2023, 4, 8, 18, 58, 38, 0);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(220, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "ingrese su cedula y la fecha y hora de la cita";
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(97, 205);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(124, 20);
            this.cedula.TabIndex = 9;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(294, 302);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(98, 36);
            this.cancelar.TabIndex = 10;
            this.cancelar.Text = "Cancelar cita";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // cedulaFuncionario
            // 
            this.cedulaFuncionario.Location = new System.Drawing.Point(37, 134);
            this.cedulaFuncionario.Name = "cedulaFuncionario";
            this.cedulaFuncionario.Size = new System.Drawing.Size(124, 20);
            this.cedulaFuncionario.TabIndex = 11;
            // 
            // cancelarCitaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cedulaFuncionario);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "cancelarCitaF";
            this.Text = "cancelarCitaF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox cedulaFuncionario;
    }
}