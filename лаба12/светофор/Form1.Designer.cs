namespace сВЕТОФОР
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
            this.panel1Red = new System.Windows.Forms.Panel();
            this.panel2Green = new System.Windows.Forms.Panel();
            this.panel3Eloy = new System.Windows.Forms.Panel();
            this.buttoNsTART = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1Red
            // 
            this.panel1Red.Location = new System.Drawing.Point(26, 12);
            this.panel1Red.Name = "panel1Red";
            this.panel1Red.Size = new System.Drawing.Size(65, 58);
            this.panel1Red.TabIndex = 0;
            this.panel1Red.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2Green
            // 
            this.panel2Green.Location = new System.Drawing.Point(26, 140);
            this.panel2Green.Name = "panel2Green";
            this.panel2Green.Size = new System.Drawing.Size(65, 58);
            this.panel2Green.TabIndex = 1;
            // 
            // panel3Eloy
            // 
            this.panel3Eloy.Location = new System.Drawing.Point(26, 76);
            this.panel3Eloy.Name = "panel3Eloy";
            this.panel3Eloy.Size = new System.Drawing.Size(65, 58);
            this.panel3Eloy.TabIndex = 2;
            // 
            // buttoNsTART
            // 
            this.buttoNsTART.Location = new System.Drawing.Point(26, 219);
            this.buttoNsTART.Name = "buttoNsTART";
            this.buttoNsTART.Size = new System.Drawing.Size(65, 32);
            this.buttoNsTART.TabIndex = 3;
            this.buttoNsTART.Text = "СТАРТ";
            this.buttoNsTART.UseVisualStyleBackColor = true;
            this.buttoNsTART.Click += new System.EventHandler(this.buttoNsTART_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 263);
            this.Controls.Add(this.buttoNsTART);
            this.Controls.Add(this.panel3Eloy);
            this.Controls.Add(this.panel2Green);
            this.Controls.Add(this.panel1Red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1Red;
        private System.Windows.Forms.Panel panel2Green;
        private System.Windows.Forms.Panel panel3Eloy;
        private System.Windows.Forms.Button buttoNsTART;
        private System.Windows.Forms.Timer timer1;
    }
}

