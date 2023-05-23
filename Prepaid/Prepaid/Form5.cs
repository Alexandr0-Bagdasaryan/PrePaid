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
    public partial class Form5 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        NpgsqlConnection con;


        public Form5(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            updateCon();
        }
        void updateCon()
        {
            String sql = "Select * From contract_data";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            contract_data.DataSource = dt;
            contract_data.Columns[0].HeaderText = "ID_Контракта";
            contract_data.Columns[1].HeaderText = "ID_Клиента";
            contract_data.Columns[2].HeaderText = "Сумма заказа";
            contract_data.Columns[3].HeaderText = "Предоплата";
            int wid = this.Size.Width;
            int hid = this.Size.Height;
            Console.WriteLine(wid + " " + hid);
            contract_data.Height = hid;
            contract_data.Width = wid;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void подробнееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Form6(con);
            f1.ShowDialog();
        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;

            try
            {
                // Создаем заголовки столбцов Excel
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    sheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                // Заполняем ячейки значениями из DataGridView
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        sheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Сохраняем файл Excel на диск
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FileName = "Export.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Данные успешно экспортированы в файл Excel.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            //for (int i = 1; i < contract_data.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = contract_data.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < contract_data.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < contract_data.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = contract_data.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //// save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //// Exit from the application  
            //app.Quit();
        }
    }
}
