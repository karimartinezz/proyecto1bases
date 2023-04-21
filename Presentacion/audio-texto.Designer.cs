namespace Presentacion
{
    partial class audio_texto
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
            this.texto = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.BackColor = System.Drawing.Color.MidnightBlue;
            this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.texto.Location = new System.Drawing.Point(326, 330);
            this.texto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(320, 96);
            this.texto.TabIndex = 0;
            this.texto.Text = "texto";
            this.texto.UseVisualStyleBackColor = false;
            this.texto.Click += new System.EventHandler(this.texto_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudio.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAudio.Location = new System.Drawing.Point(908, 330);
            this.btnAudio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(320, 96);
            this.btnAudio.TabIndex = 1;
            this.btnAudio.Text = "audio";
            this.btnAudio.UseVisualStyleBackColor = false;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(326, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(902, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione como desea agendar su cita";
       
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(637, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 83);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // audio_texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.texto);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "audio_texto";
            this.Text = "audio_texto";
            this.Load += new System.EventHandler(this.audio_texto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button texto;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}