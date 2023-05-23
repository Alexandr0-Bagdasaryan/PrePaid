using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Prepaid
{
    public partial class Form1 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        NpgsqlConnection con;
        public Form1(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            updateCon();
        }
        void updateCon()
        {
            String sql = "Select * From products";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            DB.DataSource = dt;
            DB.Columns[0].HeaderText = "ID";
            DB.Columns[1].HeaderText = "Èìÿ";
            DB.Columns[2].HeaderText = "Âåñ";
            int wid = this.Size.Width;
            int hid = this.Size.Height;
            Console.WriteLine(wid + " " + hid);
            DB.Height = hid;
            DB.Width = wid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void èçìåíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("UPDATE prodcuts SET name_product=:name WHERE ID=:id", this.con);
            int id = (int)DB.CurrentRow.Cells["ID"].Value;
            string name = (string)DB.CurrentRow.Cells["name_product"].Value;
            string weight = (string)(DB.CurrentRow.Cells["weight_product"].Value);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("name_product", name);
            command.Parameters.AddWithValue("weight_product", weight);
            Form f = new Form2(this.con, id, name, weight);
            f.ShowDialog();
            updateCon();
        }

        private void Delete(int id)
        {
            NpgsqlCommand command = new NpgsqlCommand("Delete from products where ID=:id", con);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
        }

        private void äîáàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Form2(con);
            f1.ShowDialog();
            updateCon();
        }

        private void óäàëèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)DB.CurrentRow.Cells["ID"].Value;
            Delete(id);
            updateCon();
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ñêðûâàåì òåêóùóþ ôîðìó
            Form previousForm = Application.OpenForms[Application.OpenForms.Count - 2]; // Ïîëó÷àåì ññûëêó íà ïðåäûäóùóþ ôîðìó
            previousForm.Show(); // Îòîáðàæàåì ïðåäûäóùóþ ôîðìó

        }

        private void ýêñïîðòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DB.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < DB.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = DB.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < DB.Rows.Count; i++)
                {
                    for (int j = 0; j < DB.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = DB.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
        // Exit from the application 
        //// creating Excel Application  
        //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
        //// creating new WorkBook within Excel application  
        //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
        //// creating new Excelsheet in workbook  
        //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
        //// see the excel sheet behind the program  
        //app.Visible = true;
        //// get the reference of first sheet. By default its name is Sheet1.  
        //// store its reference to worksheet  
        //worksheet = (Microsoft.Office.Interop.Excel._Worksheet?)workbook.Sheets["Sheet1"];
        //worksheet = (Microsoft.Office.Interop.Excel._Worksheet?)workbook.ActiveSheet;
        //// changing the name of active sheet  
        //worksheet.Name = "Exported from gridview";
        //// storing header part in Excel  
        //for (int i = 1; i < DB.Columns.Count + 1; i++)
        //{
        //    worksheet.Cells[1, i] = DB.Columns[i - 1].HeaderText;
        //}
        //// storing Each row and column value to excel sheet  
        //for (int i = 0; i < DB.Rows.Count - 1; i++)
        //{
        //    for (int j = 0; j < DB.Columns.Count; j++)
        //    {
        //        worksheet.Cells[i + 2, j + 1] = DB.Rows[i].Cells[j].Value.ToString();
        //    }
        //}
        //// save the application  
        //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        //// Exit from the application  
    
    }
}