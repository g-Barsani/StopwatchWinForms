namespace StopwatchWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timespan = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timespan
            // 
            this.timespan.AutoSize = true;
            this.timespan.Font = new System.Drawing.Font("Segoe UI Semilight", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timespan.ForeColor = System.Drawing.Color.White;
            this.timespan.Location = new System.Drawing.Point(78, 26);
            this.timespan.Name = "timespan";
            this.timespan.Size = new System.Drawing.Size(627, 128);
            this.timespan.TabIndex = 0;
            this.timespan.Text = "00:00:00:0000";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.DarkOrange;
            this.start.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start.Location = new System.Drawing.Point(106, 193);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(131, 55);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.DarkOrange;
            this.pause.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pause.Location = new System.Drawing.Point(322, 193);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(131, 55);
            this.pause.TabIndex = 1;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = false;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.DarkOrange;
            this.reset.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset.Location = new System.Drawing.Point(538, 193);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(131, 55);
            this.reset.TabIndex = 1;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.start);
            this.Controls.Add(this.timespan);
            this.Name = "Form1";
            this.Text = "Stopwatch by Gabriel B.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label timespan;
        private Button start;
        private Button pause;
        private Button reset;
    }
}