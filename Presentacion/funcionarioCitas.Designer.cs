namespace Presentacion
{
    partial class funcionarioCitas
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
            this.cancelarCita = new System.Windows.Forms.Button();
            this.reasignacionCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelarCita
            // 
            this.cancelarCita.Location = new System.Drawing.Point(102, 166);
            this.cancelarCita.Name = "cancelarCita";
            this.cancelarCita.Size = new System.Drawing.Size(139, 53);
            this.cancelarCita.TabIndex = 0;
            this.cancelarCita.Text = "Cancelar Cita";
            this.cancelarCita.UseVisualStyleBackColor = true;
            this.cancelarCita.Click += new System.EventHandler(this.cancelarCita_Click);
            // 
            // reasignacionCita
            // 
            this.reasignacionCita.Location = new System.Drawing.Point(490, 166);
            this.reasignacionCita.Name = "reasignacionCita";
            this.reasignacionCita.Size = new System.Drawing.Size(138, 52);
            this.reasignacionCita.TabIndex = 1;
            this.reasignacionCita.Text = "Reasignar Cita";
            this.reasignacionCita.UseVisualStyleBackColor = true;
            this.reasignacionCita.Click += new System.EventHandler(this.reasignacionCita_Click);
            // 
            // funcionarioCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reasignacionCita);
            this.Controls.Add(this.cancelarCita);
            this.Name = "funcionarioCitas";
            this.Text = "funcionarioCitas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelarCita;
        private System.Windows.Forms.Button reasignacionCita;
    }
}