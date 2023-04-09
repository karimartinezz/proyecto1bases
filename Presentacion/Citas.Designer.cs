namespace Presentacion
{
    partial class Citas
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
            this.SuspendLayout();
            // 
            // registrarCita
            // 
            this.registrarCita.Location = new System.Drawing.Point(182, 48);
            this.registrarCita.Name = "registrarCita";
            this.registrarCita.Size = new System.Drawing.Size(115, 42);
            this.registrarCita.TabIndex = 1;
            this.registrarCita.Text = "registrar cita";
            this.registrarCita.UseVisualStyleBackColor = true;
            this.registrarCita.Click += new System.EventHandler(this.registrarCita_Click);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrarCita);
            this.Name = "Citas";
            this.Text = "Citas";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button registrarCita;
    }
}