namespace Naloga_3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ura = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.Minuta = new System.Windows.Forms.Label();
            this.Sekunda = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ura
            // 
            this.Ura.AutoSize = true;
            this.Ura.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ura.Location = new System.Drawing.Point(67, 42);
            this.Ura.Name = "Ura";
            this.Ura.Size = new System.Drawing.Size(55, 39);
            this.Ura.TabIndex = 0;
            this.Ura.Text = "00";
            this.Ura.Click += new System.EventHandler(this.Ura_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(161, 108);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "STOP";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Minuta
            // 
            this.Minuta.AutoSize = true;
            this.Minuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Minuta.Location = new System.Drawing.Point(131, 42);
            this.Minuta.Name = "Minuta";
            this.Minuta.Size = new System.Drawing.Size(55, 39);
            this.Minuta.TabIndex = 2;
            this.Minuta.Text = "00";
            this.Minuta.Click += new System.EventHandler(this.Minuta_Click);
            // 
            // Sekunda
            // 
            this.Sekunda.AutoSize = true;
            this.Sekunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sekunda.Location = new System.Drawing.Point(192, 42);
            this.Sekunda.Name = "Sekunda";
            this.Sekunda.Size = new System.Drawing.Size(55, 39);
            this.Sekunda.TabIndex = 3;
            this.Sekunda.Text = "00";
            this.Sekunda.Click += new System.EventHandler(this.label3_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(64, 108);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 4;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 173);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Sekunda);
            this.Controls.Add(this.Minuta);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Ura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Ura;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label Minuta;
        private System.Windows.Forms.Label Sekunda;
        private System.Windows.Forms.Button Start;
    }
}

