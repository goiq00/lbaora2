using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Web;
using System.Security.Cryptography.X509Certificates;

namespace lbaora2
{
    public partial class Form1 : Form
    {
        string name = "";
        string filename = "";
        DataSet dataSet = new DataSet();
        string Select1;
        OleDbConnection StrCon;
        OleDbCommand command1;
        OleDbDataAdapter adapt1;

        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            dataGridView1.DataSource = Data.filteredStudents;
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* OpenFileDialog f1=new OpenFileDialog();
            if(f1.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    if (f1.FileName != null)
                    {
                        name = f1.FileName.Remove(f1.FileName.LastIndexOf("\\"));
                        filename = f1.FileName.Remove(0, f1.FileName.LastIndexOf("\\") + 1);
                        Select1 = "SELECT * FROM[" + filename + "]";
                        StrCon = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + name + ";Extended Propereties=text");
                        command1 = new OleDbCommand(Select1, StrCon);
                        adapt1 = new OleDbDataAdapter(command1);
                        StrCon.Open();
                        adapt1.Fill(dataSet);
                        dataGridView1.DataSource = dataSet.Tables[0];
                        StrCon.Close();
                    }
                }
                 catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                    
            }
        */}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Save();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void info_Click(object sender, EventArgs e)
        {

        }

        private void infoPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Data.filter = textBox1.Text;
            
            if(textBox1.Text=="")
            {
                dataGridView1.DataSource = Data.students;
            }
            else
            {
                Data.ApplyFilter();
                string s = String.Join("", Data.filteredStudents);
                statusBar.Text = $"Поставили фильтр {Data.filter} {s}";
                dataGridView1.Refresh();
                dataGridView1.DataSource = null; 
                dataGridView1.DataSource = Data.filteredStudents;

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Text = "Сохранено в students.json";
            Data.Save();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Text = "Загружено из файла students.json";
            Data.Load();
            textBox1.Text = "";
            dataGridView1.DataSource= Data.students;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.New();
            dataGridView1.Refresh();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Data.students;
            textBox1.Text = "";
           
        }

        private void удалитьВыделенныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Text = $"удаляем выделенных ";
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                statusBar.Text +=$"удаляю этого студента {row.DataBoundItem}";
                Data.Delete((Student) row.DataBoundItem);
            }
             
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = Data.students;
            textBox1.Text = "";
        }
    }
}
