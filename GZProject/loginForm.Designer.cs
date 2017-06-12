namespace GZProject
{
    partial class loginForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hasloAutBox = new System.Windows.Forms.TextBox();
            this.loginAutBox = new System.Windows.Forms.TextBox();
            this.logowanieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(74, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Rejestracja";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(74, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "Zaloguj jako gość";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(35, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Hasło";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(35, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Login";
            // 
            // hasloAutBox
            // 
            this.hasloAutBox.Location = new System.Drawing.Point(74, 60);
            this.hasloAutBox.Name = "hasloAutBox";
            this.hasloAutBox.Size = new System.Drawing.Size(130, 20);
            this.hasloAutBox.TabIndex = 9;
            // 
            // loginAutBox
            // 
            this.loginAutBox.Location = new System.Drawing.Point(74, 21);
            this.loginAutBox.Name = "loginAutBox";
            this.loginAutBox.Size = new System.Drawing.Size(130, 20);
            this.loginAutBox.TabIndex = 8;
            // 
            // logowanieButton
            // 
            this.logowanieButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logowanieButton.Location = new System.Drawing.Point(74, 105);
            this.logowanieButton.Name = "logowanieButton";
            this.logowanieButton.Size = new System.Drawing.Size(130, 41);
            this.logowanieButton.TabIndex = 7;
            this.logowanieButton.Text = "Zaloguj";
            this.logowanieButton.UseVisualStyleBackColor = true;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 269);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hasloAutBox);
            this.Controls.Add(this.loginAutBox);
            this.Controls.Add(this.logowanieButton);
            this.Name = "loginForm";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hasloAutBox;
        private System.Windows.Forms.TextBox loginAutBox;
        private System.Windows.Forms.Button logowanieButton;
    }
}