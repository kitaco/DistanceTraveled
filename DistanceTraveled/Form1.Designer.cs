namespace DistanceTraveled
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
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.fivehourButton = new System.Windows.Forms.Button();
            this.eighthourButton = new System.Windows.Forms.Button();
            this.twelvehourButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(109, 38);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 26);
            this.speedTextBox.TabIndex = 0;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(43, 41);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(60, 20);
            this.speedLabel.TabIndex = 1;
            this.speedLabel.Text = "Speed:";
            // 
            // fivehourButton
            // 
            this.fivehourButton.Location = new System.Drawing.Point(47, 80);
            this.fivehourButton.Name = "fivehourButton";
            this.fivehourButton.Size = new System.Drawing.Size(88, 30);
            this.fivehourButton.TabIndex = 2;
            this.fivehourButton.Text = "5 Hours";
            this.fivehourButton.UseVisualStyleBackColor = true;
            this.fivehourButton.Click += new System.EventHandler(this.fivehourButton_Click);
            // 
            // eighthourButton
            // 
            this.eighthourButton.Location = new System.Drawing.Point(141, 80);
            this.eighthourButton.Name = "eighthourButton";
            this.eighthourButton.Size = new System.Drawing.Size(88, 30);
            this.eighthourButton.TabIndex = 3;
            this.eighthourButton.Text = "8 Hours";
            this.eighthourButton.UseVisualStyleBackColor = true;
            this.eighthourButton.Click += new System.EventHandler(this.eighthourButton_Click);
            // 
            // twelvehourButton
            // 
            this.twelvehourButton.Location = new System.Drawing.Point(235, 80);
            this.twelvehourButton.Name = "twelvehourButton";
            this.twelvehourButton.Size = new System.Drawing.Size(88, 30);
            this.twelvehourButton.TabIndex = 4;
            this.twelvehourButton.Text = "12 Hours";
            this.twelvehourButton.UseVisualStyleBackColor = true;
            this.twelvehourButton.Click += new System.EventHandler(this.twelvehourButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(107, 177);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 33);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(188, 177);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 33);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(47, 133);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(149, 20);
            this.distanceLabel.TabIndex = 7;
            this.distanceLabel.Text = "Distanced Traveled:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(202, 132);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 23);
            this.outputLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 248);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.twelvehourButton);
            this.Controls.Add(this.eighthourButton);
            this.Controls.Add(this.fivehourButton);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.speedTextBox);
            this.Name = "Form1";
            this.Text = "Distance Traveled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button fivehourButton;
        private System.Windows.Forms.Button eighthourButton;
        private System.Windows.Forms.Button twelvehourButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}

