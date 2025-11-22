namespace DZ_11
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
            this.wordLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.intupBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wordLabel
            // 
            this.wordLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordLabel.ForeColor = System.Drawing.Color.Black;
            this.wordLabel.Location = new System.Drawing.Point(178, 75);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(158, 64);
            this.wordLabel.TabIndex = 0;
            this.wordLabel.Text = "Слово";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(122, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(201, 20);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Правильно: 0 | Ошибок: 0";
            // 
            // intupBox1
            // 
            this.intupBox1.Location = new System.Drawing.Point(107, 142);
            this.intupBox1.Name = "intupBox1";
            this.intupBox1.Size = new System.Drawing.Size(243, 20);
            this.intupBox1.TabIndex = 3;
            this.intupBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.intupBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.intupBox1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.wordLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox intupBox1;
    }
}

