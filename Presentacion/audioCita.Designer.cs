namespace Presentacion
{
    partial class audioCita
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
            this.empezar = new System.Windows.Forms.Button();
            this.pausa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empezar
            // 
            this.empezar.Location = new System.Drawing.Point(69, 157);
            this.empezar.Name = "empezar";
            this.empezar.Size = new System.Drawing.Size(137, 34);
            this.empezar.TabIndex = 2;
            this.empezar.Text = "Empezar";
            this.empezar.UseVisualStyleBackColor = true;
            this.empezar.Click += new System.EventHandler(this.empezar_Click);
            // 
            // pausa
            // 
            this.pausa.Enabled = false;
            this.pausa.Location = new System.Drawing.Point(342, 157);
            this.pausa.Name = "pausa";
            this.pausa.Size = new System.Drawing.Size(137, 34);
            this.pausa.TabIndex = 3;
            this.pausa.Text = "Terminar";
            this.pausa.UseVisualStyleBackColor = true;
            this.pausa.Click += new System.EventHandler(this.pausa_Click);
            // 
            // audioCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pausa);
            this.Controls.Add(this.empezar);
            this.Name = "audioCita";
            this.Text = "audioCita";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button empezar;
        private System.Windows.Forms.Button pausa;
    }
}