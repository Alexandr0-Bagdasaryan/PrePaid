using Microsoft.Office.Interop.Excel;
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
    public partial class Form7 : Form
    {

        NpgsqlConnection con;
        int id;
        public Form7(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            this.id = 0;
        }
        public Form7(NpgsqlConnection con, int id, string name, string address)
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = address;
            this.con = con;
            this.id = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Conf_Button_Click(object sender, EventArgs e)
        {

        }

        private void Conf_Button_Click_1(object sender, EventArgs e)
        {
            if (id == 0)
            {
                try
                {

                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO clients(name_client,address_client) VALUES (:name,:address)", con);
                    command.Parameters.AddWithValue("name", textBox1.Text);
                    command.Parameters.AddWithValue("address", textBox2.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка записи в БД");
                }
            }
            else
            {
                try
                {

                    NpgsqlCommand command = new NpgsqlCommand("UPDATE clients SET name_client=:name,address_client=:address WHERE ID=:id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("name", textBox1.Text);
                    command.Parameters.AddWithValue("address", textBox2.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch
                {

                }
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
