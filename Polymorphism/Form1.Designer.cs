namespace Polymorphism
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
            this.btnDogalGaz = new System.Windows.Forms.Button();
            this.btnSu = new System.Windows.Forms.Button();
            this.btnElektrik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDogalGaz
            // 
            this.btnDogalGaz.Location = new System.Drawing.Point(104, 167);
            this.btnDogalGaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDogalGaz.Name = "btnDogalGaz";
            this.btnDogalGaz.Size = new System.Drawing.Size(151, 66);
            this.btnDogalGaz.TabIndex = 5;
            this.btnDogalGaz.Text = "Dogal Gaz";
            this.btnDogalGaz.UseVisualStyleBackColor = true;
            this.btnDogalGaz.Click += new System.EventHandler(this.btnDogalGaz_Click_1);
            // 
            // btnSu
            // 
            this.btnSu.Location = new System.Drawing.Point(104, 93);
            this.btnSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSu.Name = "btnSu";
            this.btnSu.Size = new System.Drawing.Size(151, 70);
            this.btnSu.TabIndex = 4;
            this.btnSu.Text = "Su";
            this.btnSu.UseVisualStyleBackColor = true;
            this.btnSu.Click += new System.EventHandler(this.btnSu_Click_1);
            // 
            // btnElektrik
            // 
            this.btnElektrik.Location = new System.Drawing.Point(104, 26);
            this.btnElektrik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnElektrik.Name = "btnElektrik";
            this.btnElektrik.Size = new System.Drawing.Size(151, 62);
            this.btnElektrik.TabIndex = 3;
            this.btnElektrik.Text = "Elektirik";
            this.btnElektrik.UseVisualStyleBackColor = true;
            this.btnElektrik.Click += new System.EventHandler(this.btnElektrik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 302);
            this.Controls.Add(this.btnDogalGaz);
            this.Controls.Add(this.btnSu);
            this.Controls.Add(this.btnElektrik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDogalGaz;
        private System.Windows.Forms.Button btnSu;
        private System.Windows.Forms.Button btnElektrik;
    }
}

