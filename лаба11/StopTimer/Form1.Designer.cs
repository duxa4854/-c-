namespace StopTimer
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
            this.label1 = new System.Windows.Forms.Label();
            this.startBTN = new System.Windows.Forms.Button();
            this.resetBTN = new System.Windows.Forms.Button();
            this.stopBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.Chartreuse;
            this.startBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startBTN.Location = new System.Drawing.Point(24, 181);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(150, 60);
            this.startBTN.TabIndex = 1;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // resetBTN
            // 
            this.resetBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.resetBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetBTN.Location = new System.Drawing.Point(196, 181);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(150, 60);
            this.resetBTN.TabIndex = 2;
            this.resetBTN.Text = "Reset";
            this.resetBTN.UseVisualStyleBackColor = false;
            this.resetBTN.Click += new System.EventHandler(this.stopBTN_Click);
            // 
            // stopBTN
            // 
            this.stopBTN.BackColor = System.Drawing.Color.Red;
            this.stopBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.stopBTN.Location = new System.Drawing.Point(373, 181);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(150, 60);
            this.stopBTN.TabIndex = 3;
            this.stopBTN.Text = "Stop";
            this.stopBTN.UseVisualStyleBackColor = false;
            this.stopBTN.Click += new System.EventHandler(this.resetBTN_Click);
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
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(532, 261);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button resetBTN;
        private System.Windows.Forms.Button stopBTN;
        private System.Windows.Forms.Timer timer1;
    }
}

