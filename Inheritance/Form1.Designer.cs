namespace Inheritance
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
            this.btnUcgen = new System.Windows.Forms.Button();
            this.btnKare = new System.Windows.Forms.Button();
            this.btnDikdortgen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcgen
            // 
            this.btnUcgen.Location = new System.Drawing.Point(113, 82);
            this.btnUcgen.Name = "btnUcgen";
            this.btnUcgen.Size = new System.Drawing.Size(132, 64);
            this.btnUcgen.TabIndex = 1;
            this.btnUcgen.Text = "Üçgenin Alanı";
            this.btnUcgen.UseVisualStyleBackColor = true;
            this.btnUcgen.Click += new System.EventHandler(this.btnUcgen_Click);
            // 
            // btnKare
            // 
            this.btnKare.Location = new System.Drawing.Point(113, 12);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(132, 64);
            this.btnKare.TabIndex = 0;
            this.btnKare.Text = "Karenin Alanı";
            this.btnKare.UseVisualStyleBackColor = true;
            this.btnKare.Click += new System.EventHandler(this.btnKare_Click);
            // 
            // btnDikdortgen
            // 
            this.btnDikdortgen.Location = new System.Drawing.Point(113, 152);
            this.btnDikdortgen.Name = "btnDikdortgen";
            this.btnDikdortgen.Size = new System.Drawing.Size(132, 64);
            this.btnDikdortgen.TabIndex = 2;
            this.btnDikdortgen.Text = "Dikdörtgenin Alanı";
            this.btnDikdortgen.UseVisualStyleBackColor = true;
            this.btnDikdortgen.Click += new System.EventHandler(this.btnDikdortgen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 322);
            this.Controls.Add(this.btnDikdortgen);
            this.Controls.Add(this.btnKare);
            this.Controls.Add(this.btnUcgen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcgen;
        private System.Windows.Forms.Button btnKare;
        private System.Windows.Forms.Button btnDikdortgen;
    }
}

