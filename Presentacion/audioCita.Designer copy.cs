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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empezar
            // 
            this.empezar.BackColor = System.Drawing.Color.MidnightBlue;
            this.empezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empezar.ForeColor = System.Drawing.Color.AliceBlue;
            this.empezar.Location = new System.Drawing.Point(389, 302);
            this.empezar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.empezar.Name = "empezar";
            this.empezar.Size = new System.Drawing.Size(278, 91);
            this.empezar.TabIndex = 2;
            this.empezar.Text = "grabar";
            this.empezar.UseVisualStyleBackColor = false;
            this.empezar.Click += new System.EventHandler(this.empezar_Click);
            // 
            // pausa
            // 
            this.pausa.BackColor = System.Drawing.Color.MidnightBlue;
            this.pausa.Enabled = false;
            this.pausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pausa.Location = new System.Drawing.Point(866, 302);
            this.pausa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pausa.Name = "pausa";
            this.pausa.Size = new System.Drawing.Size(274, 91);
            this.pausa.TabIndex = 3;
            this.pausa.Text = "Detener";
            this.pausa.UseVisualStyleBackColor = false;
            this.pausa.Click += new System.EventHandler(this.pausa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(459, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Solicitud de cita vía audio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(636, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // audioCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pausa);
            this.Controls.Add(this.empezar);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "audioCita";
            this.Text = "audioCita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button empezar;
        private System.Windows.Forms.Button pausa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}