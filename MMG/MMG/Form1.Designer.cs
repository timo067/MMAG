namespace MMG
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
            button1 = new Button();
            medianLabel = new Label();
            modeLabel = new Label();
            averageLabel = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(586, 351);
            button1.Name = "button1";
            button1.Size = new Size(109, 55);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // medianLabel
            // 
            medianLabel.AutoSize = true;
            medianLabel.Location = new Point(420, 138);
            medianLabel.Name = "medianLabel";
            medianLabel.Size = new Size(59, 20);
            medianLabel.TabIndex = 2;
            medianLabel.Text = "median";
            // 
            // modeLabel
            // 
            modeLabel.AutoSize = true;
            modeLabel.Location = new Point(431, 207);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new Size(48, 20);
            modeLabel.TabIndex = 3;
            modeLabel.Text = "mode";
            // 
            // averageLabel
            // 
            averageLabel.AutoSize = true;
            averageLabel.Location = new Point(420, 266);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(62, 20);
            averageLabel.TabIndex = 4;
            averageLabel.Text = "average";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(395, 27);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(averageLabel);
            Controls.Add(modeLabel);
            Controls.Add(medianLabel);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label medianLabel;
        private Label modeLabel;
        private Label averageLabel;
        private TextBox textBox1;
    }
}