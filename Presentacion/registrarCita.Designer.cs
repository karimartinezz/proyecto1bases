namespace Presentacion
{
    partial class registrarCita
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
            this.area = new System.Windows.Forms.TextBox();
            this.observaciones = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.devolverse = new System.Windows.Forms.Button();
            this.cedula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(337, 178);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(100, 20);
            this.area.TabIndex = 2;
            this.area.TextChanged += new System.EventHandler(this.area_TextChanged);
            // 
            // observaciones
            // 
            this.observaciones.Location = new System.Drawing.Point(517, 178);
            this.observaciones.Name = "observaciones";
            this.observaciones.Size = new System.Drawing.Size(100, 20);
            this.observaciones.TabIndex = 3;
            this.observaciones.TextChanged += new System.EventHandler(this.observaciones_TextChanged);
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(337, 282);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 4;
            this.registrar.Text = "registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MMMM-dd  |  HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2023, 4, 8, 18, 58, 38, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // devolverse
            // 
            this.devolverse.Location = new System.Drawing.Point(670, 391);
            this.devolverse.Name = "devolverse";
            this.devolverse.Size = new System.Drawing.Size(81, 25);
            this.devolverse.TabIndex = 6;
            this.devolverse.Text = "devolverse";
            this.devolverse.UseVisualStyleBackColor = true;
            this.devolverse.Click += new System.EventHandler(this.devolverse_Click_1);
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(150, 178);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(100, 20);
            this.cedula.TabIndex = 7;
            this.cedula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // registrarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.devolverse);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.observaciones);
            this.Controls.Add(this.area);
            this.Name = "registrarCita";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.TextBox observaciones;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button devolverse;
        private System.Windows.Forms.TextBox cedula;
    }
}

