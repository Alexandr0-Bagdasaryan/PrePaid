using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prepaid
{
    public partial class Form6 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        NpgsqlConnection con;
        public Form6(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            updateCon();
        }
        void updateCon()
        {
            String sql = "Select * From contract_info";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            con_info.DataSource = dt;
            con_info.Columns[0].HeaderText = "ID_Контракта";
            con_info.Columns[1].HeaderText = "ID_Товара";
            con_info.Columns[2].HeaderText = "Количество";
            con_info.Columns[3].HeaderText = "Цена";
            int wid = this.Size.Width;
            int hid = this.Size.Height;
            Console.WriteLine(wid + " " + hid);
            con_info.Height = hid;
            con_info.Width = wid;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Скрываем текущую форму
            Form previousForm = Application.OpenForms[Application.OpenForms.Count - 2]; // Получаем ссылку на предыдущую форму
            previousForm.Show(); // Отображаем предыдущую форму
        }
    }
}
