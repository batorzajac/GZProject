namespace GZProject
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
            this.loginRegBox = new System.Windows.Forms.TextBox();
            this.hasloRegBox = new System.Windows.Forms.TextBox();
            this.imieRegBox = new System.Windows.Forms.TextBox();
            this.nazwiskoRegBox = new System.Windows.Forms.TextBox();
            this.emailRegBox = new System.Windows.Forms.TextBox();
            this.dataurReg = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.anulujRegButton = new System.Windows.Forms.Button();
            this.confirmRegButton = new System.Windows.Forms.Button();
            this.ValidateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginRegBox
            // 
            this.loginRegBox.Location = new System.Drawing.Point(179, 29);
            this.loginRegBox.Name = "loginRegBox";
            this.loginRegBox.Size = new System.Drawing.Size(200, 20);
            this.loginRegBox.TabIndex = 0;
            this.loginRegBox.TextChanged += new System.EventHandler(this.loginRegBox_TextChanged);
            // 
            // hasloRegBox
            // 
            this.hasloRegBox.Location = new System.Drawing.Point(179, 55);
            this.hasloRegBox.Name = "hasloRegBox";
            this.hasloRegBox.Size = new System.Drawing.Size(200, 20);
            this.hasloRegBox.TabIndex = 1;
            this.hasloRegBox.TextChanged += new System.EventHandler(this.hasloRegBox_TextChanged);
            // 
            // imieRegBox
            // 
            this.imieRegBox.Location = new System.Drawing.Point(179, 81);
            this.imieRegBox.Name = "imieRegBox";
            this.imieRegBox.Size = new System.Drawing.Size(200, 20);
            this.imieRegBox.TabIndex = 2;
            // 
            // nazwiskoRegBox
            // 
            this.nazwiskoRegBox.Location = new System.Drawing.Point(179, 107);
            this.nazwiskoRegBox.Name = "nazwiskoRegBox";
            this.nazwiskoRegBox.Size = new System.Drawing.Size(200, 20);
            this.nazwiskoRegBox.TabIndex = 3;
            // 
            // emailRegBox
            // 
            this.emailRegBox.Location = new System.Drawing.Point(179, 133);
            this.emailRegBox.Name = "emailRegBox";
            this.emailRegBox.Size = new System.Drawing.Size(200, 20);
            this.emailRegBox.TabIndex = 4;
            this.emailRegBox.TextChanged += new System.EventHandler(this.emailRegBox_TextChanged);
            // 
            // dataurReg
            // 
            this.dataurReg.Location = new System.Drawing.Point(179, 159);
            this.dataurReg.Name = "dataurReg";
            this.dataurReg.Size = new System.Drawing.Size(200, 20);
            this.dataurReg.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Imię";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nazwisko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data urodzenia";
            // 
            // anulujRegButton
            // 
            this.anulujRegButton.Location = new System.Drawing.Point(180, 229);
            this.anulujRegButton.Name = "anulujRegButton";
            this.anulujRegButton.Size = new System.Drawing.Size(75, 23);
            this.anulujRegButton.TabIndex = 12;
            this.anulujRegButton.Text = "Anuluj";
            this.anulujRegButton.UseVisualStyleBackColor = true;
            // 
            // confirmRegButton
            // 
            this.confirmRegButton.Location = new System.Drawing.Point(304, 229);
            this.confirmRegButton.Name = "confirmRegButton";
            this.confirmRegButton.Size = new System.Drawing.Size(75, 23);
            this.confirmRegButton.TabIndex = 13;
            this.confirmRegButton.Text = "Zarejestruj";
            this.confirmRegButton.UseVisualStyleBackColor = true;
            this.confirmRegButton.Click += new System.EventHandler(this.confirmRegButton_Click);
            // 
            // ValidateLabel
            // 
            this.ValidateLabel.AutoSize = true;
            this.ValidateLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ValidateLabel.Location = new System.Drawing.Point(0, 286);
            this.ValidateLabel.Name = "ValidateLabel";
            this.ValidateLabel.Size = new System.Drawing.Size(72, 13);
            this.ValidateLabel.TabIndex = 14;
            this.ValidateLabel.Text = "Wypełnij pola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 299);
            this.Controls.Add(this.ValidateLabel);
            this.Controls.Add(this.confirmRegButton);
            this.Controls.Add(this.anulujRegButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataurReg);
            this.Controls.Add(this.emailRegBox);
            this.Controls.Add(this.nazwiskoRegBox);
            this.Controls.Add(this.imieRegBox);
            this.Controls.Add(this.hasloRegBox);
            this.Controls.Add(this.loginRegBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginRegBox;
        private System.Windows.Forms.TextBox hasloRegBox;
        private System.Windows.Forms.TextBox imieRegBox;
        private System.Windows.Forms.TextBox nazwiskoRegBox;
        private System.Windows.Forms.TextBox emailRegBox;
        private System.Windows.Forms.DateTimePicker dataurReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button anulujRegButton;
        private System.Windows.Forms.Button confirmRegButton;
        private System.Windows.Forms.Label ValidateLabel;
    }
}