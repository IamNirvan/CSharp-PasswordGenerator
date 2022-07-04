namespace passwordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.copyButton = new System.Windows.Forms.Button();
            this.generatedPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.passwordLengthTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.specialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.alphabeticCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyButton.BackgroundImage")));
            this.copyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.copyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.copyButton.FlatAppearance.BorderSize = 0;
            this.copyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.copyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.Location = new System.Drawing.Point(370, 175);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(35, 35);
            this.copyButton.TabIndex = 5;
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // generatedPasswordTextBox
            // 
            this.generatedPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.generatedPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generatedPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generatedPasswordTextBox.Enabled = false;
            this.generatedPasswordTextBox.Location = new System.Drawing.Point(0, 0);
            this.generatedPasswordTextBox.Margin = new System.Windows.Forms.Padding(20);
            this.generatedPasswordTextBox.MaximumSize = new System.Drawing.Size(500, 50);
            this.generatedPasswordTextBox.MinimumSize = new System.Drawing.Size(323, 50);
            this.generatedPasswordTextBox.Multiline = true;
            this.generatedPasswordTextBox.Name = "generatedPasswordTextBox";
            this.generatedPasswordTextBox.Size = new System.Drawing.Size(416, 50);
            this.generatedPasswordTextBox.TabIndex = 8;
            this.generatedPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.AutoSize = true;
            this.passwordLengthLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLengthLabel.Location = new System.Drawing.Point(13, 77);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Size = new System.Drawing.Size(129, 19);
            this.passwordLengthLabel.TabIndex = 10;
            this.passwordLengthLabel.Text = "Password length";
            // 
            // passwordLengthTextBox
            // 
            this.passwordLengthTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordLengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLengthTextBox.Location = new System.Drawing.Point(148, 77);
            this.passwordLengthTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.passwordLengthTextBox.Name = "passwordLengthTextBox";
            this.passwordLengthTextBox.Size = new System.Drawing.Size(114, 19);
            this.passwordLengthTextBox.TabIndex = 0;
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.BlueViolet;
            this.generateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateButton.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.generateButton.FlatAppearance.BorderSize = 0;
            this.generateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.generateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Location = new System.Drawing.Point(11, 12);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(188, 44);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.Color.IndianRed;
            this.clearButton.Location = new System.Drawing.Point(216, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(189, 44);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.buttonsPanel.Controls.Add(this.clearButton);
            this.buttonsPanel.Controls.Add(this.generateButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 226);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(416, 66);
            this.buttonsPanel.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Location = new System.Drawing.Point(148, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 2);
            this.panel1.TabIndex = 16;
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersCheckBox.ForeColor = System.Drawing.Color.Black;
            this.numbersCheckBox.Location = new System.Drawing.Point(12, 153);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(151, 23);
            this.numbersCheckBox.TabIndex = 2;
            this.numbersCheckBox.Text = "Include numbers";
            this.numbersCheckBox.UseVisualStyleBackColor = true;
            this.numbersCheckBox.CheckedChanged += new System.EventHandler(this.numbersCheckBox_CheckedChanged);
            // 
            // specialCharsCheckBox
            // 
            this.specialCharsCheckBox.AutoSize = true;
            this.specialCharsCheckBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialCharsCheckBox.ForeColor = System.Drawing.Color.Black;
            this.specialCharsCheckBox.Location = new System.Drawing.Point(12, 182);
            this.specialCharsCheckBox.Name = "specialCharsCheckBox";
            this.specialCharsCheckBox.Size = new System.Drawing.Size(219, 23);
            this.specialCharsCheckBox.TabIndex = 3;
            this.specialCharsCheckBox.Text = "Include special characters";
            this.specialCharsCheckBox.UseVisualStyleBackColor = true;
            this.specialCharsCheckBox.CheckedChanged += new System.EventHandler(this.specialCharsCheckBox_CheckedChanged);
            // 
            // alphabeticCharsCheckBox
            // 
            this.alphabeticCharsCheckBox.AutoSize = true;
            this.alphabeticCharsCheckBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphabeticCharsCheckBox.ForeColor = System.Drawing.Color.Black;
            this.alphabeticCharsCheckBox.Location = new System.Drawing.Point(12, 124);
            this.alphabeticCharsCheckBox.Name = "alphabeticCharsCheckBox";
            this.alphabeticCharsCheckBox.Size = new System.Drawing.Size(245, 23);
            this.alphabeticCharsCheckBox.TabIndex = 1;
            this.alphabeticCharsCheckBox.Text = "Include alphabetic characters";
            this.alphabeticCharsCheckBox.UseVisualStyleBackColor = true;
            this.alphabeticCharsCheckBox.CheckedChanged += new System.EventHandler(this.alphabeticCharsCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(416, 292);
            this.Controls.Add(this.alphabeticCharsCheckBox);
            this.Controls.Add(this.specialCharsCheckBox);
            this.Controls.Add(this.numbersCheckBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.passwordLengthTextBox);
            this.Controls.Add(this.passwordLengthLabel);
            this.Controls.Add(this.generatedPasswordTextBox);
            this.Controls.Add(this.copyButton);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox generatedPasswordTextBox;
        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.TextBox passwordLengthTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox numbersCheckBox;
        private System.Windows.Forms.CheckBox specialCharsCheckBox;
        private System.Windows.Forms.CheckBox alphabeticCharsCheckBox;
    }
}

