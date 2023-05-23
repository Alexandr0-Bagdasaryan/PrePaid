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
    public partial class Form4 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        NpgsqlConnection con;
        public Form4(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            updateCon();
        }

        void updateCon()
        {
            String sql = "Select * From clients";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            Clients.DataSource = dt;
            Clients.Columns[0].HeaderText = "ID";
            Clients.Columns[1].HeaderText = "Имя Клиента";
            Clients.Columns[2].HeaderText = "Адрес";
            int wid = this.Size.Width;
            int hid = this.Size.Height;
            Console.WriteLine(wid + " " + hid);
            Clients.Height = hid;
            Clients.Width = wid;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Form7(con);
            f1.ShowDialog();
            updateCon();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("UPDATE clients SET name_client=:name WHERE ID=:id", this.con);
            int id = (int)Clients.CurrentRow.Cells["ID"].Value;
            string name = (string)Clients.CurrentRow.Cells["name_client"].Value;
            string address = (string)(Clients.CurrentRow.Cells["address_client"].Value);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("name_client", name);
            command.Parameters.AddWithValue("address_client", address);
            Form f = new Form7(this.con, id, name, address);
            f.ShowDialog();
            updateCon();
        }
        private void Delete(int id)
        {
            NpgsqlCommand command = new NpgsqlCommand("Delete from clients where ID=:id", con);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)Clients.CurrentRow.Cells["ID"].Value;
            Delete(id);
            updateCon();
        }
    }
}
