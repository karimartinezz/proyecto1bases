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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empezar
            // 
            this.empezar.BackColor = System.Drawing.Color.MidnightBlue;
            this.empezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empezar.ForeColor = System.Drawing.Color.AliceBlue;
            this.empezar.Location = new System.Drawing.Point(192, 217);
            this.empezar.Name = "empezar";
            this.empezar.Size = new System.Drawing.Size(139, 47);
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
            this.pausa.Location = new System.Drawing.Point(431, 217);
            this.pausa.Name = "pausa";
            this.pausa.Size = new System.Drawing.Size(137, 47);
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
            this.label1.Location = new System.Drawing.Point(230, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Solicitud de cita vía audio";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(601, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MMMM-dd  |  HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2023, 4, 8, 18, 58, 38, 0);
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(320, 327);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(116, 43);
            this.registrar.TabIndex = 7;
            this.registrar.Text = "registrar cita";
            this.registrar.UseVisualStyleBackColor = true;
            // 
            // audioCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pausa);
            this.Controls.Add(this.empezar);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button registrar;
    }
}