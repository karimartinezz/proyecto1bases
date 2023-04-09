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
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(62, 107);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(160, 50);
            this.texto.TabIndex = 0;
            this.texto.Text = "texto";
            this.texto.UseVisualStyleBackColor = true;
            this.texto.Click += new System.EventHandler(this.texto_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.Location = new System.Drawing.Point(471, 107);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(160, 50);
            this.btnAudio.TabIndex = 1;
            this.btnAudio.Text = "audio";
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // audio_texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.texto);
            this.Name = "audio_texto";
            this.Text = "audio_texto";
            this.Load += new System.EventHandler(this.audio_texto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button texto;
        private System.Windows.Forms.Button btnAudio;
    }
}