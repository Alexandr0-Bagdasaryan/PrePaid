namespace Prepaid
{
    partial class Form7
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Cancel_Button = new Button();
            Conf_Button = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(Cancel_Button);
            panel1.Controls.Add(Conf_Button);
            panel1.Location = new Point(52, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 214);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 110);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 6;
            label3.Text = "Адрес";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 81);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 5;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(91, 32);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 4;
            label1.Text = "Клиент";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // Cancel_Button
            // 
            Cancel_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cancel_Button.Location = new Point(33, 168);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(75, 23);
            Cancel_Button.TabIndex = 0;
            Cancel_Button.Text = "Отмена";
            Cancel_Button.UseVisualStyleBackColor = true;
            Cancel_Button.Click += Cancel_Button_Click;
            // 
            // Conf_Button
            // 
            Conf_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Conf_Button.Location = new Point(150, 168);
            Conf_Button.Name = "Conf_Button";
            Conf_Button.Size = new Size(93, 23);
            Conf_Button.TabIndex = 1;
            Conf_Button.Text = "Подтвердить";
            Conf_Button.UseVisualStyleBackColor = true;
            Conf_Button.Click += Conf_Button_Click_1;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 281);
            Controls.Add(panel1);
            Name = "Form7";
            Text = "Form7";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Cancel_Button;
        private Button Conf_Button;
    }
}