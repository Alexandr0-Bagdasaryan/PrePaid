namespace Prepaid
{
    partial class Form3
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
            Contracts = new Button();
            Report = new Button();
            Clients = new Button();
            Goods = new Button();
            SuspendLayout();
            // 
            // Contracts
            // 
            Contracts.BackColor = SystemColors.ActiveBorder;
            Contracts.Font = new Font("Vladimir Script", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Contracts.Location = new Point(12, 125);
            Contracts.Name = "Contracts";
            Contracts.Size = new Size(124, 30);
            Contracts.TabIndex = 8;
            Contracts.Text = "Договоры";
            Contracts.UseVisualStyleBackColor = false;
            Contracts.Click += Contracts_Click;
            // 
            // Report
            // 
            Report.BackColor = SystemColors.ActiveBorder;
            Report.Font = new Font("Vladimir Script", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Report.Location = new Point(12, 175);
            Report.Name = "Report";
            Report.Size = new Size(124, 30);
            Report.TabIndex = 7;
            Report.Text = "Отчет";
            Report.UseVisualStyleBackColor = false;
            Report.Click += Report_Click;
            // 
            // Clients
            // 
            Clients.BackColor = SystemColors.ActiveBorder;
            Clients.Font = new Font("Vladimir Script", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Clients.Location = new Point(12, 75);
            Clients.Name = "Clients";
            Clients.Size = new Size(124, 30);
            Clients.TabIndex = 6;
            Clients.Text = "Клиенты";
            Clients.UseVisualStyleBackColor = false;
            Clients.Click += Clients_Click;
            // 
            // Goods
            // 
            Goods.BackColor = SystemColors.ActiveBorder;
            Goods.Font = new Font("Vladimir Script", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Goods.ForeColor = SystemColors.ControlText;
            Goods.Location = new Point(12, 22);
            Goods.Name = "Goods";
            Goods.Size = new Size(124, 30);
            Goods.TabIndex = 5;
            Goods.Text = "Товары";
            Goods.UseVisualStyleBackColor = false;
            Goods.Click += Goods_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 254);
            Controls.Add(Contracts);
            Controls.Add(Report);
            Controls.Add(Clients);
            Controls.Add(Goods);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Contracts;
        private Button Report;
        private Button Clients;
        private Button Goods;
    }
}