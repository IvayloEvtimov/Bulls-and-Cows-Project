namespace Bulls_and_Cows
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
            this.EasyBtn = new System.Windows.Forms.Button();
            this.HardBtn = new System.Windows.Forms.Button();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // EasyBtn
            // 
            this.EasyBtn.Location = new System.Drawing.Point(52, 54);
            this.EasyBtn.Name = "EasyBtn";
            this.EasyBtn.Size = new System.Drawing.Size(133, 50);
            this.EasyBtn.TabIndex = 0;
            this.EasyBtn.Text = "Easy";
            this.EasyBtn.UseVisualStyleBackColor = true;
            this.EasyBtn.Click += new System.EventHandler(this.EasyBtn_Click);
            // 
            // HardBtn
            // 
            this.HardBtn.Location = new System.Drawing.Point(249, 54);
            this.HardBtn.Name = "HardBtn";
            this.HardBtn.Size = new System.Drawing.Size(132, 50);
            this.HardBtn.TabIndex = 1;
            this.HardBtn.Text = "Hard";
            this.HardBtn.UseVisualStyleBackColor = true;
            this.HardBtn.Click += new System.EventHandler(this.HardBtn_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(169, 124);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(93, 23);
            this.HelpBtn.TabIndex = 2;
            this.HelpBtn.Text = "How To Play";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bulls and Cows";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.HardBtn);
            this.Controls.Add(this.EasyBtn);
            this.Name = "Form1";
            this.Text = "Bulls and Cows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EasyBtn;
        private System.Windows.Forms.Button HardBtn;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

