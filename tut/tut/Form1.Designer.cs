namespace tut
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
            this.connor = new System.Windows.Forms.Button();
            this.connor2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connor
            // 
            this.connor.Location = new System.Drawing.Point(149, 109);
            this.connor.Name = "connor";
            this.connor.Size = new System.Drawing.Size(75, 23);
            this.connor.TabIndex = 0;
            this.connor.Text = "connor";
            this.connor.UseVisualStyleBackColor = true;
            this.connor.Click += new System.EventHandler(this.connor_Click);
            // 
            // connor2
            // 
            this.connor2.Location = new System.Drawing.Point(149, 166);
            this.connor2.Name = "connor2";
            this.connor2.Size = new System.Drawing.Size(75, 23);
            this.connor2.TabIndex = 1;
            this.connor2.Text = "connor2";
            this.connor2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connor2);
            this.Controls.Add(this.connor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connor;
        private System.Windows.Forms.Button connor2;
    }
}

