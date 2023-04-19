namespace Presentacion
{
    partial class reasignacionCita
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cedulaFuncionario = new System.Windows.Forms.TextBox();
            this.asignar = new System.Windows.Forms.Button();
            this.cedula = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(207, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "ingrese su cedula y la fecha y hora de la cita";
            // 
            // cedulaFuncionario
            // 
            this.cedulaFuncionario.Location = new System.Drawing.Point(70, 123);
            this.cedulaFuncionario.Name = "cedulaFuncionario";
            this.cedulaFuncionario.Size = new System.Drawing.Size(124, 20);
            this.cedulaFuncionario.TabIndex = 15;
            // 
            // asignar
            // 
            this.asignar.Location = new System.Drawing.Point(327, 291);
            this.asignar.Name = "asignar";
            this.asignar.Size = new System.Drawing.Size(98, 36);
            this.asignar.TabIndex = 14;
            this.asignar.Text = "Reasignar cita";
            this.asignar.UseVisualStyleBackColor = true;
            this.asignar.Click += new System.EventHandler(this.asignar_Click);
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(130, 194);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(124, 20);
            this.cedula.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MMMM-dd  |  HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(467, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2023, 4, 8, 18, 58, 38, 0);
            // 
            // reasignacionCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cedulaFuncionario);
            this.Controls.Add(this.asignar);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Name = "reasignacionCita";
            this.Text = "reasignacionCita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cedulaFuncionario;
        private System.Windows.Forms.Button asignar;
        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}