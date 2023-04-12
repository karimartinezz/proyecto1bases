namespace Presentacion
{
    partial class paciente_funcionario
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
            this.paciente = new System.Windows.Forms.Button();
            this.funcionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paciente
            // 
            this.paciente.Location = new System.Drawing.Point(138, 185);
            this.paciente.Name = "paciente";
            this.paciente.Size = new System.Drawing.Size(160, 68);
            this.paciente.TabIndex = 0;
            this.paciente.Text = "Paciente\r\n";
            this.paciente.UseVisualStyleBackColor = true;
            this.paciente.Click += new System.EventHandler(this.paciente_Click);
            // 
            // funcionario
            // 
            this.funcionario.Location = new System.Drawing.Point(405, 185);
            this.funcionario.Name = "funcionario";
            this.funcionario.Size = new System.Drawing.Size(159, 68);
            this.funcionario.TabIndex = 1;
            this.funcionario.Text = "Funcionario";
            this.funcionario.UseVisualStyleBackColor = true;
            this.funcionario.Click += new System.EventHandler(this.funcionario_Click);
            // 
            // paciente_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.funcionario);
            this.Controls.Add(this.paciente);
            this.Name = "paciente_funcionario";
            this.Text = "paciente_funcionario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button paciente;
        private System.Windows.Forms.Button funcionario;
    }
}