namespace Presentacion
{
    partial class pacienteCitas
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
            this.registrarCita = new System.Windows.Forms.Button();
            this.cancelarCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrarCita
            // 
            this.registrarCita.Location = new System.Drawing.Point(152, 48);
            this.registrarCita.Name = "registrarCita";
            this.registrarCita.Size = new System.Drawing.Size(147, 60);
            this.registrarCita.TabIndex = 1;
            this.registrarCita.Text = "registrar cita";
            this.registrarCita.UseVisualStyleBackColor = true;
            this.registrarCita.Click += new System.EventHandler(this.registrarCita_Click);
            // 
            // cancelarCita
            // 
            this.cancelarCita.Location = new System.Drawing.Point(397, 48);
            this.cancelarCita.Name = "cancelarCita";
            this.cancelarCita.Size = new System.Drawing.Size(161, 48);
            this.cancelarCita.TabIndex = 2;
            this.cancelarCita.Text = "cancelar cita";
            this.cancelarCita.UseVisualStyleBackColor = true;
            this.cancelarCita.Click += new System.EventHandler(this.cancelarCita_Click);
            // 
            // pacienteCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelarCita);
            this.Controls.Add(this.registrarCita);
            this.Name = "pacienteCitas";
            this.Text = "Citas";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button registrarCita;
        private System.Windows.Forms.Button cancelarCita;
    }
}