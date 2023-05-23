namespace Prepaid
{
    partial class Form5
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
            menuStrip1 = new MenuStrip();
            подробнееToolStripMenuItem = new ToolStripMenuItem();
            экспортToolStripMenuItem = new ToolStripMenuItem();
            contract_data = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contract_data).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { подробнееToolStripMenuItem, экспортToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(619, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // подробнееToolStripMenuItem
            // 
            подробнееToolStripMenuItem.Name = "подробнееToolStripMenuItem";
            подробнееToolStripMenuItem.Size = new Size(81, 20);
            подробнееToolStripMenuItem.Text = "Подробнее";
            подробнееToolStripMenuItem.Click += подробнееToolStripMenuItem_Click;
            // 
            // экспортToolStripMenuItem
            // 
            экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            экспортToolStripMenuItem.Size = new Size(64, 20);
            экспортToolStripMenuItem.Text = "Экспорт";
            экспортToolStripMenuItem.Click += экспортToolStripMenuItem_Click;
            // 
            // contract_data
            // 
            contract_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contract_data.Location = new Point(0, 27);
            contract_data.Name = "contract_data";
            contract_data.RowTemplate.Height = 25;
            contract_data.Size = new Size(607, 294);
            contract_data.TabIndex = 1;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 333);
            Controls.Add(contract_data);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contract_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem подробнееToolStripMenuItem;
        private DataGridView contract_data;
        private ToolStripMenuItem экспортToolStripMenuItem;
    }
}