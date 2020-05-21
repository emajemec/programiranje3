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
            this.Gumb1 = new System.Windows.Forms.Button();
            this.Gumb2 = new System.Windows.Forms.Button();
            this.barve = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stevec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gumb1
            // 
            this.Gumb1.Location = new System.Drawing.Point(61, 113);
            this.Gumb1.Name = "Gumb1";
            this.Gumb1.Size = new System.Drawing.Size(142, 41);
            this.Gumb1.TabIndex = 0;
            this.Gumb1.Text = "Barvi se ne ujemata";
            this.Gumb1.UseVisualStyleBackColor = true;
            this.Gumb1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // Gumb2
            // 
            this.Gumb2.Location = new System.Drawing.Point(275, 113);
            this.Gumb2.Name = "Gumb2";
            this.Gumb2.Size = new System.Drawing.Size(136, 41);
            this.Gumb2.TabIndex = 1;
            this.Gumb2.Text = "Barvi se ujemata";
            this.Gumb2.UseVisualStyleBackColor = true;
            this.Gumb2.Click += new System.EventHandler(this.Form1_Load);
            // 
            // barve
            // 
            this.barve.AutoSize = true;
            this.barve.Location = new System.Drawing.Point(217, 50);
            this.barve.Name = "barve";
            this.barve.Size = new System.Drawing.Size(0, 13);
            this.barve.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(204, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // stevec
            // 
            this.stevec.AutoSize = true;
            this.stevec.Location = new System.Drawing.Point(217, 207);
            this.stevec.Name = "stevec";
            this.stevec.Size = new System.Drawing.Size(35, 13);
            this.stevec.TabIndex = 7;
            this.stevec.Text = "label1";
            this.stevec.TextChanged += new System.EventHandler(this.Gumb1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 272);
            this.Controls.Add(this.stevec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barve);
            this.Controls.Add(this.Gumb2);
            this.Controls.Add(this.Gumb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gumb1;
        private System.Windows.Forms.Button Gumb2;
        private System.Windows.Forms.Label barve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stevec;
    }
}

